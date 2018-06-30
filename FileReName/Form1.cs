#define Debug
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReName
{
    public partial class fmRename : Form
    {
        #region 全局变量
        /// <summary>
        /// 星号(*)的长度
        /// </summary>
        int len;

        #endregion

        public fmRename()
        {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            string strPath = txtPath.Text.Trim();
            if (strPath == "") return;
            DirectoryOpen(strPath);
        }
        /// <summary>
        /// 打开目录，并显示文件列表
        /// </summary>
        /// <param name="strPath">要打开的目录</param>
        private void DirectoryOpen(string strPath)
        {
            if (!Directory.Exists(strPath)) return;
            listName.Items.Clear();
            txtPath.Text = strPath;
            string[] strFiles= Directory.GetFiles(strPath);
            int count = strFiles.Count();
            string fileName;
            FileInfo fileInfo;
            for (int i = 0; i < count; i++)
            {
                fileName=strFiles[i];
                fileInfo=new FileInfo(fileName);
                fileName=fileInfo.Name;
                ListViewItem lItem = new ListViewItem(fileName);
                lItem.Tag = fileInfo.FullName;// fileName;
                //lItem.SubItems.Add()
                listName.Items.Add(lItem);
            }
        }
        /// <summary>
        /// 浏览按钮，弹出打开文件夹对话框，选择文件夹
        /// </summary>
        /// <param name="sender">按钮对象</param>
        /// <param name="e">事件</param>
        private void btnExplore_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fo = new FolderBrowserDialog();
            DialogResult diaResult=fo.ShowDialog(this);
            if(diaResult==DialogResult.OK)
            {
                string strPath = fo.DirectoryPath;
                DirectoryOpen(strPath);
                
            }
            fo.Dispose();
        }
        /// <summary>
        /// 预览新名称按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btViewName_Click(object sender, EventArgs e)
        {
            if (listName.Items.Count < 1) return;
            string strName=txtName.Text.Trim();
            if (strName == "") return;
            if (!CheckName(strName)) return;
            string strReplance=txtStart.Text.Trim();
            string newstr;
            int count=0;
            if(!int.TryParse(strReplance,out count))
            {
                return;
            }
            strReplance = "*".PadLeft(len, '*');
            
            foreach (ListViewItem lItem in listName.Items)
            {
                FileInfo fiInfo = new FileInfo(lItem.Tag.ToString());
                string ext = fiInfo.Extension;
                
                newstr = count.ToString().PadLeft(len, '0');
                string itemtxt = lItem.Text;
                
                string newName = strName.Replace("(" + strReplance + ")", newstr) + ext;
                lItem.SubItems.Clear();
                lItem.Text = itemtxt;
                lItem.SubItems.Add(newName);
                ++count;
            }
        }
        /// <summary>
        /// 判断新名称的格式是否正确
        /// </summary>
        /// <param name="name">新的名称</param>
        /// <returns>正确返回true，错误返回false.</returns>
        private bool CheckName(string name)
        {
            bool bo = true;
            string strStart=txtStart.Text.Trim();
            int i=0;
            if (strStart == "")
            {
                MessageBox.Show("请输入开始值！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if(!Int32.TryParse( strStart,out i))
                {
                    MessageBox.Show("开始值只能为数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            if (name.IndexOf("*") < 0 || name.IndexOf("(")<0)//格式不符合，退出
            {
                MessageBox.Show("名称格式不符合要求！","错误",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            len = 0; 
            int lenStart = 0;
            string str = "";
            lenStart = strStart.Length;
            i = name.IndexOf("(");
            name = name.Substring(i+1);
            while (name.Length > 0)
            {
                str = name.Substring(0, 1);
                if (str != "*")
                {
                    if (len < 1)
                    {
                        bo = CheckName(name);
                    }
                    if(str==")")
                    {
                        bo = true;
                        break;                            
                    }
                    else
                    {
                        MessageBox.Show("括号内，只能有'*'！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bo = false;
                        break;
                    }
                }
                else
                {
                    len += 1;
                    name = name.Substring(1);
                }
            }
            return bo;
        }
        /// <summary>
        /// 重命名按钮
        /// </summary>
        /// <param name="sender">按钮对象</param>
        /// <param name="e">事件对象</param>
        private void btnRename_Click(object sender, EventArgs e)
        {
            if (listName.Items.Count < 1) return;
            string strName = txtName.Text.Trim();
            if (strName == "") return;
            if (!CheckName(strName)) return;

            string strReplance = txtStart.Text.Trim();
            string newstr;
            int count = 0;
            if (!int.TryParse(strReplance, out count))
            {
                return;
            }
            strReplance = "*".PadLeft(len, '*');

            string path,fileNewName;
            
            foreach (ListViewItem lItem in listName.Items)
            {
                FileInfo fiInfo = new FileInfo(lItem.Tag.ToString());
                string ext = fiInfo.Extension;
                path = fiInfo.DirectoryName;

                newstr = count.ToString().PadLeft(len, '0');
                fileNewName = strName.Replace("(" + strReplance + ")", newstr) + ext;
                //lItem.SubItems.Clear();
                string itemtxt = lItem.Text;
                lItem.SubItems.Clear();
                lItem.Text = itemtxt;
                lItem.SubItems.Add(fileNewName);
                fiInfo.MoveTo(path +"\\"+ fileNewName);
                ++count;
            }
            MessageBox.Show("文件批量重命名完成！","完成",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

        }

        private void fmRename_Load(object sender, EventArgs e)
        {
            fmRename_ResizeEnd(null, null);
        }

        private void fmRename_ResizeEnd(object sender, EventArgs e)
        {

         

        }

        private void fmRename_ClientSizeChanged(object sender, EventArgs e)
        {
            int width = listName.PreferredSize.Width;
            if (listName.Columns.Count < 1) return;
            width = width / listName.Columns.Count;
            for (int i = 0; i < listName.Columns.Count; i++)
            {
                listName.Columns[i].Width = width;
            }
        }
        
    }
}
