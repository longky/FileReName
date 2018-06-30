namespace FileReName
{
    partial class fmRename
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnExplore = new System.Windows.Forms.Button();
            this.btViewName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.listName = new System.Windows.Forms.ListView();
            this.colOldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNewName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRename);
            this.panel1.Controls.Add(this.btnExplore);
            this.panel1.Controls.Add(this.btViewName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.btOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 0;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(294, 39);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(82, 21);
            this.txtStart.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "开始值:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "目  录:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "新名称:";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(463, 37);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 6;
            this.btnRename.Text = "重命名";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnExplore
            // 
            this.btnExplore.Location = new System.Drawing.Point(463, 13);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(77, 22);
            this.btnExplore.TabIndex = 2;
            this.btnExplore.Text = "浏览";
            this.btnExplore.UseVisualStyleBackColor = true;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // btViewName
            // 
            this.btViewName.Location = new System.Drawing.Point(382, 37);
            this.btViewName.Name = "btViewName";
            this.btViewName.Size = new System.Drawing.Size(75, 23);
            this.btViewName.TabIndex = 5;
            this.btViewName.Text = "预览新名称";
            this.btViewName.UseVisualStyleBackColor = true;
            this.btViewName.Click += new System.EventHandler(this.btViewName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 21);
            this.txtName.TabIndex = 3;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(65, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(311, 21);
            this.txtPath.TabIndex = 0;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(382, 12);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "打开目录";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // listName
            // 
            this.listName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOldName,
            this.colNewName});
            this.listName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listName.Location = new System.Drawing.Point(0, 71);
            this.listName.Name = "listName";
            this.listName.Size = new System.Drawing.Size(800, 379);
            this.listName.TabIndex = 1;
            this.listName.UseCompatibleStateImageBehavior = false;
            this.listName.View = System.Windows.Forms.View.Details;
            // 
            // colOldName
            // 
            this.colOldName.Text = "名称";
            // 
            // colNewName
            // 
            this.colNewName.Text = "新名称";
            // 
            // fmRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listName);
            this.Controls.Add(this.panel1);
            this.Name = "fmRename";
            this.Text = "文件批量重命名";
            this.Load += new System.EventHandler(this.fmRename_Load);
            this.ClientSizeChanged += new System.EventHandler(this.fmRename_ClientSizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.Button btViewName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListView listName;
        private System.Windows.Forms.ColumnHeader colOldName;
        private System.Windows.Forms.ColumnHeader colNewName;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

