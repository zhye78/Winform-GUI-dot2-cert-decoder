using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string openDirPath = null; //directory path
        private string openFilePath = null; //file path

        //디렉토리 오픈 버튼 클릭시 호출되는 함수
        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            openFilePath = null;

            try
            {
                folderBrowserDialog.SelectedPath = "C:\\";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    openDirPath = folderBrowserDialog.SelectedPath;
                    txtBoxOpen.Text = openDirPath;
                }

                if (!openDirPath.Equals("C:\\"))
                {
                    //listview 갱신 직전 세팅
                    setListView();
                    openFilePath = null;

                    //listview 갱신
                    this.listView.BeginUpdate(); // 업데이트가 끝날 때까지 UI 갱신 중지.
                    getFileList(openDirPath);
                    this.listView.EndUpdate();
                }
            }
            catch (Exception) { }
        }

        //파일 오픈 버튼 클릭시 호출되는 함수
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openDirPath = null;

            try
            {
                //디렉토리 말고 파일 가져오는 코드
                openFileDialog.InitialDirectory = "C:\\";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    openFilePath = openFileDialog.FileName;
                    txtBoxOpen.Text = openFilePath;
                }

                if (!openFilePath.Equals("C:\\"))
                {
                    //listview 갱신 직전 세팅
                    setListView();
                    openDirPath = null;

                    //listview 갱신
                    this.listView.BeginUpdate(); // 업데이트가 끝날 때까지 UI 갱신 중지.
                    getFileList(openFilePath);
                    this.listView.EndUpdate();
                }
            }
            catch (Exception) { }
        }

        //디렉토리나 파일을 드래그 후 드롭할 때 호출되는 함수
        private void dragDrop(object sender, DragEventArgs e)
        {
            string[] dragPath = (string[])e.Data.GetData(DataFormats.FileDrop); //get path
            FileAttributes attr = File.GetAttributes(dragPath[0]);

            //디렉토리 드래그,드롭
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                openDirPath = dragPath[0];
                openFilePath = null;
                txtBoxOpen.Text = openDirPath;

                //listview 갱신 직전 세팅
                setListView();

                //listview 갱신
                this.listView.BeginUpdate(); // 업데이트가 끝날 때까지 UI 갱신 중지.
                getFileList(openDirPath);
                this.listView.EndUpdate();
            }
            else //파일 드래그,드롭
            {
                openFilePath = dragPath[0];
                openDirPath = null;
                txtBoxOpen.Text = openFilePath;

                //listview 갱신 직전 세팅
                setListView();

                //listview 갱신
                this.listView.BeginUpdate(); // 업데이트가 끝날 때까지 UI 갱신 중지.
                getFileList(openFilePath);
                this.listView.EndUpdate();
            }
        }

        //디렉토리나 함수를 drag&drop 영역으로 끌어왔을 때 호출되는 함수
        private void dragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; //change cursor shape
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
