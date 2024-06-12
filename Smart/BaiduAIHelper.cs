using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baidu.Aip.Speech;
using System.IO;
using Baidu.Aip;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace Smart
{
    public class BaiduAIHelper
    {
        [DllImport("winmm.dll", SetLastError = true)]
        //#pragma warning disable IDE1006 // 命名样式
        static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        //#pragma warning restore IDE1006 // 命名样式
        private const int AudioSampleRate = 16000;

        private readonly Asr _asrClient;
        private readonly Tts _ttsClient;


        public BaiduAIHelper(string appId, string apiKey, string secretKey)
        {
            _asrClient = new Asr(appId, apiKey, secretKey);
            _ttsClient = new Tts(apiKey, secretKey);
        }

        public string RecognizeSpeech()
        {
            return "开灯";
            // 假设音频文件已经录制并保存在本地
            var data = File.ReadAllBytes("audio.wav");
            var result = _asrClient.Recognize(data, "wav", 16000);
            return result["result"][0].ToString();
        }

        public string RecognizeSpeech(Stream audioStream)
        {
            using (var memoryStream = new MemoryStream())
            {
                audioStream.CopyTo(memoryStream);
                var data = memoryStream.ToArray();
                // var base64Data = Convert.ToBase64String(data);
                var result = _asrClient.Recognize(data, "wav", 16000);
                return result["result"][0].ToString();
            }
        }

        public void SynthesizeSpeech(string text)
        {
            if (string.IsNullOrEmpty(text)) return;

            // 语音合成
            TtsResponse result;
            try
            {
                result = _ttsClient.Synthesis(text);
            }
            catch (AipException exp)
            {
                MessageBox.Show(exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (result.Success)
            {
                // 保存为mp3格式
                File.WriteAllBytes("temp.mp3", result.Data);

                // 播放音频文件
                mciSendString("open temp.mp3 alias temp_alias", null, 0, IntPtr.Zero);
                mciSendString("play temp_alias", null, 0, IntPtr.Zero);

                // 等待播放结束
                StringBuilder strReturn = new StringBuilder(64);
                do
                {
                    mciSendString("status temp_alias mode", strReturn, 64, IntPtr.Zero);
                } while (!strReturn.ToString().Contains("stopped"));

                // 关闭音频文件
                mciSendString("close temp_alias", null, 0, IntPtr.Zero);
            }
            else
                MessageBox.Show(result.ErrorMsg, "转换失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            /*
            var result = _ttsClient.Synthesis(text);
            if (result.ErrorCode == 0)
            {
                File.WriteAllBytes("output.mp3", result.Data);
                // 播放音频
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("output.mp3");
                player.Play();
            }
            */
        }
    }
}
