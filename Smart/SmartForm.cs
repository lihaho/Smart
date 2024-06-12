using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Smart
{
    public partial class Smart : Form
    {
        private BaiduAIHelper baiduAIHelper;
        private VoiceControl voiceControl;
        private bool voiceIsValid = false;
        private bool isSpeaking;
        private DateTime lastVoiceActivity;

        // 下面是麦克风录制声音用到
        private WaveInEvent waveIn;
        private MemoryStream memoryStream;
        private System.Threading.Timer timer;

        public Smart()
        {
            InitializeComponent();
            baiduAIHelper = new BaiduAIHelper("80081073", "9UbVh1wnQgEkRoclcohfB8Iy", "4btQhARRnh7LfDQsZX08T2sU9cx1D04t");
            voiceControl = new VoiceControl(baiduAIHelper, this);
            ListAudioDevices();
            InitializeImages();
        }

        private void InitializeImages()
        {
            voicePictureBox.Image = Properties.Resources.box;
        }

        private void btnStartListening_Click(object sender, EventArgs e)
        {
            startListen();
        }

        public void startListen()
        {
            string command = baiduAIHelper.RecognizeSpeech();
            string response = voiceControl.ProcessCommand(command);
            baiduAIHelper.SynthesizeSpeech(response);
        }

        // 更新UI上的设备状态
        public void UpdateDeviceStatus(string room, string device, string status)
        {
            if (device =="灯")
            {
                var label = keting;
                if (room == "主卧") { label = zhuwo; }
                if (room == "次卧") { label = ciwo; }
                if (status == "开")
                {
                    label.BackColor = Color.LightYellow;
                }
                if (status == "关")
                {
                    label.BackColor = Color.White;
                }
            }
            if (device == "空调")
            {
                var label = keting_ac;
                if (room == "主卧") { label = zhuwo_ac; }
                if (room == "次卧") { label = ciwo_ac; }
                if (status == "开")
                {
                    label.Image = Properties.Resources.air_condition_open;
                }
                if (status == "关")
                {
                    label.Image = Properties.Resources.air_condition_close;
                }
            }
        }

        // 更新UI上的设备状态
        public void RunDeviceMod(string mod)
        {
            if (mod == "离家")
            {
                keting.BackColor = Color.White;
                zhuwo.BackColor = Color.White;
                ciwo.BackColor = Color.White;
            }
        }

        private void wakeButton_Click(object sender, EventArgs e)
        {
            if (voiceIsValid)
            {
                wakeButton.Text = "音箱已关闭，点击打开";
                timer.Dispose();
                closeVoiceBox(null);
            } else
            {
                voiceIsValid = true;
                wakeButton.Text = "音箱已打开，点击关闭";
                doStartRecord();
                // string command = baiduAIHelper.RecognizeSpeech();
                // string response = voiceControl.ProcessCommand(command);
                //  baiduAIHelper.SynthesizeSpeech(response);
                timer = new System.Threading.Timer(closeVoiceBox, null, TimeSpan.FromMinutes(5), Timeout.InfiniteTimeSpan);
            }
        }

        private void closeVoiceBox(object state)
        {
            // 在UI线程中执行关闭音箱的操作
            this.Invoke((MethodInvoker)delegate
            {
                voiceIsValid = false;
                wakeButton.Text = "音箱已关闭，点击打开";
                voicePictureBox.Image = Properties.Resources.box;
                waveIn.StopRecording();
                toolStripStatusLabel1.Text = "音箱已关闭";
            });
        }

        // 下面是麦克风录制声音的逻辑
        private void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            Debug.WriteLine("OnDataAvailable...");
            if (voiceIsValid == false) { return; }
            if (memoryStream != null)
            {
                memoryStream.Write(e.Buffer, 0, e.BytesRecorded);
            }

            // 简单的静音检测和VAD
            float maxVolume = 0;
            for (int i = 0; i < e.BytesRecorded; i += 2)
            {
                short sample = BitConverter.ToInt16(e.Buffer, i);
                float volume = Math.Abs(sample / 32768f);
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                }
            }
            Debug.WriteLine($"Max Volume: {maxVolume}");

            if (maxVolume > 0.15) // 设定一个阈值
            {
                isSpeaking = true;
                lastVoiceActivity = DateTime.Now;
            }
            else
            {
                if (isSpeaking && (DateTime.Now - lastVoiceActivity).TotalMilliseconds > 500)
                {
                    isSpeaking = false;
                    waveIn.StopRecording();
                }
            }
        }

        private void startRecord_Click(object sender, EventArgs e)
        {
            doStartRecord();
        }

        private void doStartRecord()
        {
            voicePictureBox.Image = Properties.Resources.box_speaking;
            memoryStream = new MemoryStream();
            waveIn = new WaveInEvent();
            waveIn.WaveFormat = new WaveFormat(16000, 1); // 16kHz, Mono
            waveIn.BufferMilliseconds = 100; // 设置缓冲区大小为100毫秒
            waveIn.DataAvailable += OnDataAvailable;
            waveIn.RecordingStopped += OnRecordingStopped;
            toolStripStatusLabel1.Text = "startRecord_Click...";
            Debug.WriteLine("startRecord_Click...");
            waveIn.StartRecording();
            toolStripStatusLabel1.Text = "倾听中...";
            Debug.WriteLine("Recording...");
            isSpeaking = false;
            lastVoiceActivity = DateTime.Now;
        }

        private void stopRecord_Click(object sender, EventArgs e)
        {
            voicePictureBox.Image = Properties.Resources.box;
            waveIn.StopRecording();
        }

        private void ListAudioDevices()
        {
            Debug.WriteLine("Device list");
            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                var deviceInfo = WaveIn.GetCapabilities(i);
                Debug.WriteLine($"Device {i}: {deviceInfo.ProductName}");
            }
        }


        private void OnRecordingStopped(object sender, StoppedEventArgs e)
        {
            if (voiceIsValid == false) return;
            waveIn.Dispose();
            waveIn = null;

            toolStripStatusLabel1.Text = "处理中...";
            memoryStream.Position = 0; // Reset the position to the beginning of the stream

            string result = baiduAIHelper.RecognizeSpeech(memoryStream);
            toolStripStatusLabel1.Text = result;
            string response = voiceControl.ProcessCommand(result);
            baiduAIHelper.SynthesizeSpeech(response);
            doStartRecord();
        }
    }
}
