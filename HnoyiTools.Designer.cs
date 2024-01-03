namespace HnoyiTools
{
    partial class HnoyiTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HnoyiTools));
            this.label1 = new System.Windows.Forms.Label();
            this.SrcPathBox = new System.Windows.Forms.TextBox();
            this.DestPathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SrcPathbutton = new System.Windows.Forms.Button();
            this.DestPathbutton = new System.Windows.Forms.Button();
            this.MsgBox = new System.Windows.Forms.TextBox();
            this.BackWorker = new System.ComponentModel.BackgroundWorker();
            this.StartWorkButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ProgresLabel = new System.Windows.Forms.Label();
            this.StopWorkButton = new System.Windows.Forms.Button();
            this.MoveCheckBox = new System.Windows.Forms.CheckBox();
            this.RepeatCheckBox = new System.Windows.Forms.CheckBox();
            this.RenameCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "待整理目录：";
            // 
            // SrcPathBox
            // 
            this.SrcPathBox.Location = new System.Drawing.Point(137, 36);
            this.SrcPathBox.Name = "SrcPathBox";
            this.SrcPathBox.Size = new System.Drawing.Size(174, 21);
            this.SrcPathBox.TabIndex = 2;
            // 
            // DestPathBox
            // 
            this.DestPathBox.Location = new System.Drawing.Point(137, 90);
            this.DestPathBox.Name = "DestPathBox";
            this.DestPathBox.Size = new System.Drawing.Size(174, 21);
            this.DestPathBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "输出目录：";
            // 
            // SrcPathbutton
            // 
            this.SrcPathbutton.Location = new System.Drawing.Point(329, 34);
            this.SrcPathbutton.Name = "SrcPathbutton";
            this.SrcPathbutton.Size = new System.Drawing.Size(75, 23);
            this.SrcPathbutton.TabIndex = 5;
            this.SrcPathbutton.Text = "选择文件夹";
            this.SrcPathbutton.UseVisualStyleBackColor = true;
            this.SrcPathbutton.Click += new System.EventHandler(this.SrcPathbutton_Click);
            // 
            // DestPathbutton
            // 
            this.DestPathbutton.Location = new System.Drawing.Point(327, 90);
            this.DestPathbutton.Name = "DestPathbutton";
            this.DestPathbutton.Size = new System.Drawing.Size(75, 23);
            this.DestPathbutton.TabIndex = 6;
            this.DestPathbutton.Text = "选择文件夹";
            this.DestPathbutton.UseVisualStyleBackColor = true;
            this.DestPathbutton.Click += new System.EventHandler(this.DestPathbutton_Click);
            // 
            // MsgBox
            // 
            this.MsgBox.BackColor = System.Drawing.SystemColors.Info;
            this.MsgBox.Location = new System.Drawing.Point(54, 238);
            this.MsgBox.Multiline = true;
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.ReadOnly = true;
            this.MsgBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MsgBox.Size = new System.Drawing.Size(350, 111);
            this.MsgBox.TabIndex = 7;
            this.MsgBox.TextChanged += new System.EventHandler(this.MsgBox_TextChanged);
            // 
            // BackWorker
            // 
            this.BackWorker.WorkerReportsProgress = true;
            this.BackWorker.WorkerSupportsCancellation = true;
            this.BackWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackWorker_DoWork);
            this.BackWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackWorker_ProgressChanged);
            this.BackWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackWorker_RunWorkerCompleted);
            // 
            // StartWorkButton
            // 
            this.StartWorkButton.Location = new System.Drawing.Point(100, 369);
            this.StartWorkButton.Name = "StartWorkButton";
            this.StartWorkButton.Size = new System.Drawing.Size(75, 23);
            this.StartWorkButton.TabIndex = 8;
            this.StartWorkButton.Text = "开始整理";
            this.StartWorkButton.UseVisualStyleBackColor = true;
            this.StartWorkButton.Click += new System.EventHandler(this.StartWorkButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(54, 198);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(350, 23);
            this.progressBar.TabIndex = 10;
            // 
            // ProgresLabel
            // 
            this.ProgresLabel.AutoSize = true;
            this.ProgresLabel.Location = new System.Drawing.Point(54, 180);
            this.ProgresLabel.Name = "ProgresLabel";
            this.ProgresLabel.Size = new System.Drawing.Size(59, 12);
            this.ProgresLabel.TabIndex = 11;
            this.ProgresLabel.Text = "处理进度:";
            // 
            // StopWorkButton
            // 
            this.StopWorkButton.Location = new System.Drawing.Point(252, 369);
            this.StopWorkButton.Name = "StopWorkButton";
            this.StopWorkButton.Size = new System.Drawing.Size(75, 23);
            this.StopWorkButton.TabIndex = 12;
            this.StopWorkButton.Text = "停止";
            this.StopWorkButton.UseVisualStyleBackColor = true;
            this.StopWorkButton.Click += new System.EventHandler(this.StopWorkButton_Click);
            // 
            // MoveCheckBox
            // 
            this.MoveCheckBox.AutoSize = true;
            this.MoveCheckBox.Location = new System.Drawing.Point(54, 133);
            this.MoveCheckBox.Name = "MoveCheckBox";
            this.MoveCheckBox.Size = new System.Drawing.Size(108, 16);
            this.MoveCheckBox.TabIndex = 13;
            this.MoveCheckBox.Text = "移动(默认复制)";
            this.MoveCheckBox.UseVisualStyleBackColor = true;
            // 
            // RepeatCheckBox
            // 
            this.RepeatCheckBox.AutoSize = true;
            this.RepeatCheckBox.Checked = true;
            this.RepeatCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RepeatCheckBox.Location = new System.Drawing.Point(182, 133);
            this.RepeatCheckBox.Name = "RepeatCheckBox";
            this.RepeatCheckBox.Size = new System.Drawing.Size(48, 16);
            this.RepeatCheckBox.TabIndex = 14;
            this.RepeatCheckBox.Text = "去重";
            this.RepeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // RenameCheckBox
            // 
            this.RenameCheckBox.AutoSize = true;
            this.RenameCheckBox.Checked = true;
            this.RenameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RenameCheckBox.Location = new System.Drawing.Point(251, 133);
            this.RenameCheckBox.Name = "RenameCheckBox";
            this.RenameCheckBox.Size = new System.Drawing.Size(60, 16);
            this.RenameCheckBox.TabIndex = 15;
            this.RenameCheckBox.Text = "重命名";
            this.RenameCheckBox.UseVisualStyleBackColor = true;
            // 
            // HnoyiTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 427);
            this.Controls.Add(this.RenameCheckBox);
            this.Controls.Add(this.RepeatCheckBox);
            this.Controls.Add(this.MoveCheckBox);
            this.Controls.Add(this.StopWorkButton);
            this.Controls.Add(this.ProgresLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.StartWorkButton);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.DestPathbutton);
            this.Controls.Add(this.SrcPathbutton);
            this.Controls.Add(this.DestPathBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SrcPathBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HnoyiTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HnoyiTools--hayson(hnoyi@foxmail.com)";
            this.Load += new System.EventHandler(this.HnoyiTools_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SrcPathBox;
        private System.Windows.Forms.TextBox DestPathBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SrcPathbutton;
        private System.Windows.Forms.Button DestPathbutton;
        private System.Windows.Forms.TextBox MsgBox;
        private System.ComponentModel.BackgroundWorker BackWorker;
        private System.Windows.Forms.Button StartWorkButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label ProgresLabel;
        private System.Windows.Forms.Button StopWorkButton;
        private System.Windows.Forms.CheckBox MoveCheckBox;
        private System.Windows.Forms.CheckBox RepeatCheckBox;
        private System.Windows.Forms.CheckBox RenameCheckBox;
    }
}

