using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Threading;
namespace copyFile1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        string[] array = new string[2000];
        int Counter = 0;
        string Path;
        string LogPath;
        string ResultPath;
        private delegate void ShowFile(string i);
        private delegate void MouseCursor(bool busy);
    

        private void Source_Btn_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\Desktop"; //設定初始路徑
                                                        //ofd.Filter = "Excel檔案(*.xls)|*.xls|Csv檔案(*.csv)|*.csv|所有檔案(*.*)|*.*"; //設定“另存為檔案型別”或“檔案型別”框中出現的選擇內容
            ofd.Filter = "文字檔 (*.txt)|*.txt";
            ofd.FilterIndex = 1; //設定預設顯示檔案型別為Csv檔案(*.csv)|*.csv
            ofd.Title = "開啟檔案"; //獲取或設定檔案對話方塊標題
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(ofd.FileName);
                SourceFile_TB.Text = (ofd.FileName);
                while ((array[Counter] = file.ReadLine()) != null)
                {

                    //Console.Write(array[i] + "\n");

                    Counter++;
                }
            }

        }

        private void Dest_Btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Path = new FolderBrowserDialog();
            Path.ShowDialog();
            Console.Write(Path.SelectedPath + "\n");
            this.Path = Path.SelectedPath;
            DestFile_TB.Text = this.Path;
        }

        private void CopyRun_Btn_Click(object sender, EventArgs e)
        {
            
            Thread t = new Thread(RunCopyWork);
            t.Start();
          

        }

        private void RunCopyWork()
        {
            if (SourceFile_TB.Text == "" || DestFile_TB.Text == "" || LogFile_TB.Text == "" || ResultFile_TB.Text == "")
            {
                MessageBox.Show("folder error");
                return;
            }
               
            bool cursor = true;
            MouseCursor MC = new MouseCursor(MouseCursorInit);
            this.Invoke(MC,cursor);
             
            DirectoryInfo dir = new DirectoryInfo(Path + "\\");
            DirectoryInfo logDir = new DirectoryInfo(LogPath + "\\");
            DirectoryInfo resultDir = new DirectoryInfo(ResultPath + "\\");
            Directory.GetParent(Path);
            int flag;
            if (Directory.Exists(Directory.GetParent(Path)  + "\\temp"))
            {
                //資料夾存在
            }
            else
            {
                //新增資料夾
                Directory.CreateDirectory(Directory.GetParent(Path) + "\\temp");
                Directory.CreateDirectory(Directory.GetParent(Path) + "\\temp\\" + dir.Name);
                Directory.CreateDirectory(Directory.GetParent(Path) + "\\temp\\" + logDir.Name);
                Directory.CreateDirectory(Directory.GetParent(Path) + "\\temp\\" + resultDir.Name);
            }
            for (int i = 0; i < 2000; i++)
            {
                if (array[i] == null)
                {
                    cursor = false;
                    this.Invoke(MC, cursor);

                    if (CopyFailFile_TB.Text == "")
                    {
                       
                        MessageBox.Show("Copy Complete !");
                    }
                    else
                    {
                        MessageBox.Show("Copy Fail !");
                    }

                    return;
                }
                flag = 0;
                //  foreach (DirectoryInfo dChild in dir.GetDirectories(array[i]+"*"))
                foreach (FileInfo f in dir.GetFiles("*.txt"))
                {//如果用GetDirectories("ab*"),那麼全部以ab開頭的目錄會被顯示

                    Regex regex = new Regex(@array[i]);//查詢檔案名稱中有關鍵字的文件
                    Match m = regex.Match(f.ToString());
                    if (m.Success == true)
                    {
                        // Console.Write(f.Name + "<BR>");//列印目錄名
                        File.Copy(f.FullName, (Directory.GetParent(Path) + "\\temp\\" + dir.Name + "\\" + f.Name), true);

                        flag++; 
                    }

                    // Response.Write(dChild.FullName + "<BR>");//列印路徑和目錄名
                }

                if (flag < 2)
                {
                    ShowFile Sf = new ShowFile(ShowText);
                    this.Invoke(Sf, "NO Control_Log: " + array[i]);

                }

                bool haveWord = false;
                FindInDirectory(LogPath, array[i],ref haveWord, logDir.Name);
                if (!haveWord)
                {
                    ShowFile Sf = new ShowFile(ShowText);
                    this.Invoke(Sf,"NO LOG: " + array[i]);
                }

                haveWord = false;
                FindInDirectory(ResultPath, array[i], ref haveWord, resultDir.Name);
                if (!haveWord)
                {
                    ShowFile Sf = new ShowFile(ShowText);
                    this.Invoke(Sf, "NO Result: " + array[i]);
                }
            }

          
        }

        private void ShowText(string file)
        {
            CopyFailFile_TB.Text += file.ToString() + "\r\n";
        }

        private void MouseCursorInit(bool flag)
        {
            if (flag)
            {
                this.Cursor = Cursors.WaitCursor;//漏斗指標
                Source_Btn.Enabled = false;
                Dest_Btn.Enabled = false;
                CopyRun_Btn.Enabled = false;
                FindInLog_Btn.Enabled = false;
                FindInResult_Btn.Enabled = false;
            }
            else
            {
                this.Cursor = Cursors.Default;//還原預設
                Source_Btn.Enabled = true;
                Dest_Btn.Enabled = true;
                CopyRun_Btn.Enabled = true;
                FindInLog_Btn.Enabled = true;
                FindInResult_Btn.Enabled = true;
            }
        }

        /// <summary>
        /// 從檔案中找關鍵字
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="word"></param>
        private bool FindInFile(string filename, string word)
        {
            System.IO.StreamReader sr = System.IO.File.OpenText(filename);
            string s = sr.ReadToEnd();
            sr.Close();
            string[] temp = s.Split('\n');
            
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i].IndexOf(word) != -1)
                {
                    Console.WriteLine(string.Format(
                    "Found in: {0}\n{1}\nLine: {2} \n",
                    filename, temp[i].Trim(), i + 1));
                  
                    return true;
                  
                }

                
            }
            return false;

        }

        /// <summary>
        /// 從資料夾中找關鍵字
        /// </summary>
        /// <param name="foldername"></param>
        /// <param name="word"></param>
        private void FindInDirectory(string foldername, string word, ref bool haveWord, string creatFoldName)
        {
            
            System.IO.DirectoryInfo dif = new System.IO.DirectoryInfo(foldername);
          
            //遍歷資料夾中的各子資料夾
            foreach (System.IO.DirectoryInfo di in dif.GetDirectories())
            {
                FindInDirectory(di.FullName, word, ref haveWord, creatFoldName);
            }
            //查詢資料夾中的各個檔案
            foreach (System.IO.FileInfo f in dif.GetFiles())
            {
                bool haveFileFlag;
                haveFileFlag = FindInFile(f.FullName, word);
                haveWord |= haveFileFlag;
                if (haveFileFlag)
                {
                    Directory.CreateDirectory(Directory.GetParent(Path) + "\\temp\\" + creatFoldName + "\\" + dif.Name);
                    File.Copy(f.FullName, (Directory.GetParent(Path) + "\\temp\\" + creatFoldName + "\\" + dif.Name + "\\" + f.Name), true);
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FindInLog_Btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Path = new FolderBrowserDialog();
            Path.ShowDialog();
            Console.Write(Path.SelectedPath + "\n");
            LogPath = Path.SelectedPath;
            LogFile_TB.Text = LogPath;
        }

        private void FindInResult_Btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Path = new FolderBrowserDialog();
            Path.ShowDialog();
            Console.Write(Path.SelectedPath + "\n");
            ResultPath = Path.SelectedPath;
            ResultFile_TB.Text = ResultPath;
        }
    }
}
