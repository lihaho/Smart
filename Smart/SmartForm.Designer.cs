using System;

namespace Smart
{
    partial class Smart
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.wakeButton = new System.Windows.Forms.Button();
            this.startRecord = new System.Windows.Forms.Button();
            this.stopRecord = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.voicePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zhuwo = new System.Windows.Forms.Label();
            this.ciwo = new System.Windows.Forms.Label();
            this.keting = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.keting_ac = new System.Windows.Forms.PictureBox();
            this.ciwo_ac = new System.Windows.Forms.PictureBox();
            this.zhuwo_ac = new System.Windows.Forms.PictureBox();
            this.statusStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voicePictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keting_ac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciwo_ac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhuwo_ac)).BeginInit();
            this.SuspendLayout();
            // 
            // wakeButton
            // 
            this.wakeButton.Location = new System.Drawing.Point(71, 329);
            this.wakeButton.Name = "wakeButton";
            this.wakeButton.Size = new System.Drawing.Size(315, 78);
            this.wakeButton.TabIndex = 3;
            this.wakeButton.Text = "音箱已关闭，点击打开";
            this.wakeButton.UseVisualStyleBackColor = true;
            this.wakeButton.Click += new System.EventHandler(this.wakeButton_Click);
            // 
            // startRecord
            // 
            this.startRecord.Location = new System.Drawing.Point(32, 693);
            this.startRecord.Name = "startRecord";
            this.startRecord.Size = new System.Drawing.Size(132, 78);
            this.startRecord.TabIndex = 4;
            this.startRecord.Text = "开始录音";
            this.startRecord.UseVisualStyleBackColor = true;
            this.startRecord.Click += new System.EventHandler(this.startRecord_Click);
            // 
            // stopRecord
            // 
            this.stopRecord.Location = new System.Drawing.Point(179, 693);
            this.stopRecord.Name = "stopRecord";
            this.stopRecord.Size = new System.Drawing.Size(132, 78);
            this.stopRecord.TabIndex = 5;
            this.stopRecord.Text = "停止录音";
            this.stopRecord.UseVisualStyleBackColor = true;
            this.stopRecord.Click += new System.EventHandler(this.stopRecord_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip2.Location = new System.Drawing.Point(0, 1095);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1485, 41);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "欢迎使用";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(257, 31);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.ToolTipText = "欢迎使用";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.voicePictureBox);
            this.groupBox1.Controls.Add(this.stopRecord);
            this.groupBox1.Controls.Add(this.wakeButton);
            this.groupBox1.Controls.Add(this.startRecord);
            this.groupBox1.Location = new System.Drawing.Point(990, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 1012);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制区";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 642);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "手动控制";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "为节省测试资源，5分钟后自动关闭";
            // 
            // voicePictureBox
            // 
            this.voicePictureBox.Location = new System.Drawing.Point(115, 68);
            this.voicePictureBox.Name = "voicePictureBox";
            this.voicePictureBox.Size = new System.Drawing.Size(228, 227);
            this.voicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voicePictureBox.TabIndex = 6;
            this.voicePictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.zhuwo_ac);
            this.groupBox2.Controls.Add(this.ciwo_ac);
            this.groupBox2.Controls.Add(this.keting_ac);
            this.groupBox2.Controls.Add(this.zhuwo);
            this.groupBox2.Controls.Add(this.ciwo);
            this.groupBox2.Controls.Add(this.keting);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(30, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(915, 1012);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "效果展示";
            // 
            // zhuwo
            // 
            this.zhuwo.AutoSize = true;
            this.zhuwo.Location = new System.Drawing.Point(97, 566);
            this.zhuwo.MinimumSize = new System.Drawing.Size(270, 280);
            this.zhuwo.Name = "zhuwo";
            this.zhuwo.Size = new System.Drawing.Size(270, 280);
            this.zhuwo.TabIndex = 10;
            this.zhuwo.Text = "主卧";
            this.zhuwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ciwo
            // 
            this.ciwo.AutoSize = true;
            this.ciwo.Location = new System.Drawing.Point(152, 188);
            this.ciwo.MinimumSize = new System.Drawing.Size(220, 240);
            this.ciwo.Name = "ciwo";
            this.ciwo.Size = new System.Drawing.Size(220, 240);
            this.ciwo.TabIndex = 9;
            this.ciwo.Text = "次卧";
            this.ciwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keting
            // 
            this.keting.AutoSize = true;
            this.keting.Location = new System.Drawing.Point(386, 446);
            this.keting.MinimumSize = new System.Drawing.Size(300, 400);
            this.keting.Name = "keting";
            this.keting.Size = new System.Drawing.Size(300, 400);
            this.keting.TabIndex = 8;
            this.keting.Text = "客厅";
            this.keting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Smart.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(75, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(695, 919);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // keting_ac
            // 
            this.keting_ac.Image = global::Smart.Properties.Resources.air_condition_close;
            this.keting_ac.Location = new System.Drawing.Point(590, 737);
            this.keting_ac.Name = "keting_ac";
            this.keting_ac.Size = new System.Drawing.Size(96, 109);
            this.keting_ac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.keting_ac.TabIndex = 11;
            this.keting_ac.TabStop = false;
            // 
            // ciwo_ac
            // 
            this.ciwo_ac.Image = global::Smart.Properties.Resources.air_condition_close;
            this.ciwo_ac.Location = new System.Drawing.Point(276, 188);
            this.ciwo_ac.Name = "ciwo_ac";
            this.ciwo_ac.Size = new System.Drawing.Size(96, 109);
            this.ciwo_ac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ciwo_ac.TabIndex = 12;
            this.ciwo_ac.TabStop = false;
            // 
            // zhuwo_ac
            // 
            this.zhuwo_ac.Image = global::Smart.Properties.Resources.air_condition_close;
            this.zhuwo_ac.Location = new System.Drawing.Point(271, 737);
            this.zhuwo_ac.Name = "zhuwo_ac";
            this.zhuwo_ac.Size = new System.Drawing.Size(96, 109);
            this.zhuwo_ac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zhuwo_ac.TabIndex = 13;
            this.zhuwo_ac.TabStop = false;
            // 
            // Smart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1485, 1136);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Smart";
            this.Text = "Smart";
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voicePictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keting_ac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciwo_ac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhuwo_ac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button wakeButton;
        private System.Windows.Forms.Button startRecord;
        private System.Windows.Forms.Button stopRecord;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox voicePictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label keting;
        private System.Windows.Forms.Label ciwo;
        private System.Windows.Forms.Label zhuwo;
        private System.Windows.Forms.PictureBox keting_ac;
        private System.Windows.Forms.PictureBox zhuwo_ac;
        private System.Windows.Forms.PictureBox ciwo_ac;
    }
}

