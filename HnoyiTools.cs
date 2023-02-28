using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace HnoyiTools
{
    public partial class HnoyiTools : Form
    {
        public HnoyiTools()
        {
            InitializeComponent();
        }

        //记录文件总数，显示进度
        static long FileNum = 0;
        static bool MoveEnable = false;
        static bool RepeatCheckEnable = false;

        //随机数
        private static Random random = new Random();
        /// <summary>
        /// 随机字符串
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public string GetRandomStr(string chars, int length)
        {
            if (string.IsNullOrEmpty(chars))
            {
                chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghizklmnopqrstuvwxyz0123456789";
            }
            //const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void SrcPathbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择文件所在文件夹目录";  //提示的文字
            if (folder.ShowDialog() == DialogResult.OK)
            {
                SrcPathBox.Text = folder.SelectedPath;
            }

        }

        private void DestPathbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择文件所在文件夹目录";  //提示的文字
            if (folder.ShowDialog() == DialogResult.OK)
            {
                DestPathBox.Text = folder.SelectedPath;
            }
        }

        private void BackWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // 遍历所有文件
            var files = Directory.GetFiles(SrcPathBox.Text, "*.*", SearchOption.AllDirectories);
            int i = 0;

            foreach (var file in files)
            {
                //判断退出
                if (BackWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                //获取文件创建时间等信息
                FileInfo fi = new FileInfo(file);

                /*
                Console.WriteLine("创建时间:" + fi.CreationTime);
                Console.WriteLine("修改时间:" + fi.LastWriteTime);
                Console.WriteLine("访问时间:" + fi.LastAccessTime);
                */
                //取最早时间，copy的文件创建时间会很新
                DateTime Time = fi.CreationTime;
                if (DateTime.Compare(fi.CreationTime, fi.LastWriteTime) > 0)
                {
                    Time = fi.LastWriteTime;
                }

                //按年月方式创建目录
                string DestPath = DestPathBox.Text + @"\" + Time.Year + @"\" + Time.Month + @"\";
                if (!Directory.Exists(DestPath))
                {
                    Directory.CreateDirectory(DestPath);
                }

                //重命名文件
                string SourceFile = file;
                string DestFileName = Time.ToString("yyyy-MM-dd__HH_mm_ss") + fi.Extension;
                string DestFile = DestPath + DestFileName;

                //防止重名
                if (File.Exists(DestFile))
                {
                    if (RepeatCheckEnable)
                    {
                        var DestMd5 = new FileInfo(DestFile).GetMD5().ToHexString();
                        var SourceMd5 = new FileInfo(SourceFile).GetMD5().ToHexString();
                        if (DestMd5 == SourceMd5)
                        {
                            i++;
                            string Msg = "重复文件[" + fi.Name + "] 跳过\r\n";
                            BackWorker.ReportProgress(i, Msg);
                            continue;
                        }

                    }

                    DestFileName = Time.ToString("yyyy-MM-dd__HH_mm_ss") + "_" + GetRandomStr(null, 4) + fi.Extension;
                    DestFile = DestPath + DestFileName;
                }

                //移动文件
                if (MoveEnable)
                {
                    File.Move(SourceFile, DestFile);
                }
                else
                {
                    //默认复制文件
                    File.Copy(SourceFile, DestFile);
                }


                //通知进度
                string ProcessMsg = "原文件:[" + fi.Name + "] ---> " + "新文件:[" + DestFileName + "]\r\n";
                //Console.WriteLine(ProcessMsg);

                i++;
                BackWorker.ReportProgress(i, ProcessMsg);
            }

        }

        private void BackWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //BackWorker.ReportProgress方法传递过来的参数userState
            string state = (string)e.UserState;
            progressBar.Value = e.ProgressPercentage;
            ProgresLabel.Text = "处理进度:" + Convert.ToString(e.ProgressPercentage) + "/" + FileNum;
            MsgBox.Text += e.UserState.ToString();

        }

        private void BackWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(SrcPathBox.Text + "文件全部处理完成！");

            //计算过程中的异常会被抓住，在这里可以进行处理。
            //这里没做异常处理
            if (e.Error != null)
            {
                Type errorType = e.Error.GetType();
                switch (errorType.Name)
                {
                    case "ArgumentNullException":
                    case "MyException":
                        //do something.
                        break;
                    default:
                        //do something.
                        break;
                }
            }
        }

        private void StartWorkButton_Click(object sender, EventArgs e)
        {


            //判断是否正在运行异步操作
            if (BackWorker.IsBusy)
                return;

            if (SrcPathBox.Text.Length < 1 || DestPathBox.Text.Length < 1)
            {
                MessageBox.Show("请选择源文件目录和目标文件夹目录！");
                return;
            }
            //
            //判断文件操作模式
            if (MoveCheckBox.Checked)
            {
                MoveEnable = true;
            }

            //去重标志
            if (RepeatCheckBox.Checked)
            {
                RepeatCheckEnable = true;
            }

            //清空显示
            ProgresLabel.Text = "处理进度:";
            MsgBox.Text = "";

            //填充总文件数表示进度
            FileNum = progressBar.Maximum = Directory.GetFiles(SrcPathBox.Text, "*.*", SearchOption.AllDirectories).Length;

            //给业务传递参数，就是把前台的要处理的参数传递进去
            BackWorker.RunWorkerAsync();

            StopWorkButton.Enabled = true;
        }

        private void StopWorkButton_Click(object sender, EventArgs e)
        {
            //取消后台进程
            BackWorker.CancelAsync();
        }

        //增加消息换行
        private void MsgBox_TextChanged(object sender, EventArgs e)
        {
            MsgBox.SelectionStart = MsgBox.Text.Length;
            MsgBox.SelectionLength = 0;
            MsgBox.ScrollToCaret();
        }
    }
}
