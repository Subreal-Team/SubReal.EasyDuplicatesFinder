namespace SubReal.EasyDuplicateFinder
{
    partial class FindForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteOthersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewDublicates = new System.Windows.Forms.ListView();
            this.chkSelectAllFiles = new System.Windows.Forms.CheckBox();
            this.listView = new System.Windows.Forms.ListView();
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.btnStartFind = new System.Windows.Forms.Button();
            this.lblCountFindedFiles = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTimeWork = new System.Windows.Forms.Label();
            this.btnDuplicates = new System.Windows.Forms.Button();
            this.contextMenuListView.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuListView
            // 
            this.contextMenuListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showFileToolStripMenuItem,
            this.DeleteOthersToolStripMenuItem});
            this.contextMenuListView.Name = "contextMenuListView";
            this.contextMenuListView.Size = new System.Drawing.Size(181, 48);
            // 
            // showFileToolStripMenuItem
            // 
            this.showFileToolStripMenuItem.Name = "showFileToolStripMenuItem";
            this.showFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showFileToolStripMenuItem.Text = "Show file";
            this.showFileToolStripMenuItem.Click += new System.EventHandler(this.ShowFileToolStripMenuItem_Click);
            // 
            // DeleteOthersToolStripMenuItem
            // 
            this.DeleteOthersToolStripMenuItem.Name = "DeleteOthersToolStripMenuItem";
            this.DeleteOthersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteOthersToolStripMenuItem.Text = "Удалить остальные";
            this.DeleteOthersToolStripMenuItem.Click += new System.EventHandler(this.DeleteOthersToolStripMenuItem_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Укажите папку с файлами обновления";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.lst";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listViewDublicates, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkSelectAllFiles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1053, 549);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // listViewDublicates
            // 
            this.listViewDublicates.CheckBoxes = true;
            this.listViewDublicates.ContextMenuStrip = this.contextMenuListView;
            this.listViewDublicates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDublicates.FullRowSelect = true;
            this.listViewDublicates.GridLines = true;
            this.listViewDublicates.HideSelection = false;
            this.listViewDublicates.Location = new System.Drawing.Point(3, 266);
            this.listViewDublicates.MultiSelect = false;
            this.listViewDublicates.Name = "listViewDublicates";
            this.listViewDublicates.Size = new System.Drawing.Size(1047, 280);
            this.listViewDublicates.TabIndex = 6;
            this.listViewDublicates.UseCompatibleStateImageBehavior = false;
            this.listViewDublicates.View = System.Windows.Forms.View.Details;
            // 
            // chkSelectAllFiles
            // 
            this.chkSelectAllFiles.AutoSize = true;
            this.chkSelectAllFiles.Location = new System.Drawing.Point(2, 8);
            this.chkSelectAllFiles.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.chkSelectAllFiles.Name = "chkSelectAllFiles";
            this.chkSelectAllFiles.Size = new System.Drawing.Size(91, 17);
            this.chkSelectAllFiles.TabIndex = 5;
            this.chkSelectAllFiles.Text = "Выбрать все";
            this.chkSelectAllFiles.UseVisualStyleBackColor = true;
            this.chkSelectAllFiles.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // listView
            // 
            this.listView.CheckBoxes = true;
            this.listView.ContextMenuStrip = this.contextMenuListView;
            this.listView.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(3, 28);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1047, 232);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Location = new System.Drawing.Point(12, 12);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.Size = new System.Drawing.Size(390, 20);
            this.tbFolderPath.TabIndex = 1;
            this.tbFolderPath.Text = "c:\\iac";
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Image = global::SubReal.EasyDuplicateFinder.Properties.Resources.icon_folder_open;
            this.btnSelectDirectory.Location = new System.Drawing.Point(408, 10);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDirectory.TabIndex = 2;
            this.btnSelectDirectory.Text = "&Directory";
            this.btnSelectDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectDirectory.UseCompatibleTextRendering = true;
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.BtnSelectDirectory_Click);
            // 
            // btnStartFind
            // 
            this.btnStartFind.Location = new System.Drawing.Point(408, 39);
            this.btnStartFind.Name = "btnStartFind";
            this.btnStartFind.Size = new System.Drawing.Size(75, 23);
            this.btnStartFind.TabIndex = 3;
            this.btnStartFind.Text = "&Find";
            this.btnStartFind.UseVisualStyleBackColor = true;
            this.btnStartFind.Click += new System.EventHandler(this.BtnStartFind_Click);
            // 
            // lblCountFindedFiles
            // 
            this.lblCountFindedFiles.AutoSize = true;
            this.lblCountFindedFiles.Location = new System.Drawing.Point(12, 44);
            this.lblCountFindedFiles.Name = "lblCountFindedFiles";
            this.lblCountFindedFiles.Size = new System.Drawing.Size(30, 13);
            this.lblCountFindedFiles.TabIndex = 4;
            this.lblCountFindedFiles.Text = "Find ";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(507, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Убрать уникальные";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblTimeWork
            // 
            this.lblTimeWork.AutoSize = true;
            this.lblTimeWork.Location = new System.Drawing.Point(12, 67);
            this.lblTimeWork.Name = "lblTimeWork";
            this.lblTimeWork.Size = new System.Drawing.Size(35, 13);
            this.lblTimeWork.TabIndex = 10;
            this.lblTimeWork.Text = "label1";
            // 
            // btnDuplicates
            // 
            this.btnDuplicates.Location = new System.Drawing.Point(507, 44);
            this.btnDuplicates.Name = "btnDuplicates";
            this.btnDuplicates.Size = new System.Drawing.Size(75, 23);
            this.btnDuplicates.TabIndex = 11;
            this.btnDuplicates.Text = "Дубликаты";
            this.btnDuplicates.UseVisualStyleBackColor = true;
            this.btnDuplicates.Click += new System.EventHandler(this.Button2_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 632);
            this.Controls.Add(this.btnDuplicates);
            this.Controls.Add(this.lblTimeWork);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblCountFindedFiles);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnStartFind);
            this.Controls.Add(this.btnSelectDirectory);
            this.Controls.Add(this.tbFolderPath);
            this.MinimumSize = new System.Drawing.Size(696, 388);
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "win.edf";
            this.contextMenuListView.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuListView;
        private System.Windows.Forms.ToolStripMenuItem showFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteOthersToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listViewDublicates;
        private System.Windows.Forms.CheckBox chkSelectAllFiles;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox tbFolderPath;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.Button btnStartFind;
        private System.Windows.Forms.Label lblCountFindedFiles;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTimeWork;
        private System.Windows.Forms.Button btnDuplicates;
    }
}

