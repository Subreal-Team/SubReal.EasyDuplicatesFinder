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
            this.tableLayoutDuplicatesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelPathFind = new System.Windows.Forms.Panel();
            this.btnStartFind = new System.Windows.Forms.Button();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.panelStatistic = new System.Windows.Forms.Panel();
            this.lblTimeWork = new System.Windows.Forms.Label();
            this.lblCountFindedFiles = new System.Windows.Forms.Label();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tabFilesPage = new System.Windows.Forms.TabPage();
            this.tableLayoutFilesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chkSelectAllFiles = new System.Windows.Forms.CheckBox();
            this.listView = new System.Windows.Forms.ListView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDuplicatesPage = new System.Windows.Forms.TabPage();
            this.listViewAllDuplicates = new System.Windows.Forms.ListView();
            this.listViewDublicates = new System.Windows.Forms.ListView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.contextMenuListView.SuspendLayout();
            this.tableLayoutDuplicatesPanel.SuspendLayout();
            this.panelPathFind.SuspendLayout();
            this.panelStatistic.SuspendLayout();
            this.panelOperations.SuspendLayout();
            this.tabFilesPage.SuspendLayout();
            this.tableLayoutFilesPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDuplicatesPage.SuspendLayout();
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
            // tableLayoutDuplicatesPanel
            // 
            this.tableLayoutDuplicatesPanel.ColumnCount = 3;
            this.tableLayoutDuplicatesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.73154F));
            this.tableLayoutDuplicatesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutDuplicatesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.26846F));
            this.tableLayoutDuplicatesPanel.Controls.Add(this.panelPathFind, 0, 0);
            this.tableLayoutDuplicatesPanel.Controls.Add(this.panelStatistic, 1, 0);
            this.tableLayoutDuplicatesPanel.Controls.Add(this.panelOperations, 2, 0);
            this.tableLayoutDuplicatesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutDuplicatesPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutDuplicatesPanel.Name = "tableLayoutDuplicatesPanel";
            this.tableLayoutDuplicatesPanel.RowCount = 1;
            this.tableLayoutDuplicatesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutDuplicatesPanel.Size = new System.Drawing.Size(1165, 100);
            this.tableLayoutDuplicatesPanel.TabIndex = 12;
            // 
            // panelPathFind
            // 
            this.panelPathFind.Controls.Add(this.btnStartFind);
            this.panelPathFind.Controls.Add(this.btnSelectDirectory);
            this.panelPathFind.Controls.Add(this.tbFolderPath);
            this.panelPathFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPathFind.Location = new System.Drawing.Point(3, 3);
            this.panelPathFind.Name = "panelPathFind";
            this.panelPathFind.Size = new System.Drawing.Size(441, 94);
            this.panelPathFind.TabIndex = 0;
            // 
            // btnStartFind
            // 
            this.btnStartFind.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStartFind.Location = new System.Drawing.Point(353, 45);
            this.btnStartFind.Name = "btnStartFind";
            this.btnStartFind.Size = new System.Drawing.Size(75, 23);
            this.btnStartFind.TabIndex = 4;
            this.btnStartFind.Text = "&Find";
            this.btnStartFind.UseVisualStyleBackColor = true;
            this.btnStartFind.Click += new System.EventHandler(this.BtnStartFind_Click);
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSelectDirectory.Image = global::SubReal.EasyDuplicateFinder.Properties.Resources.icon_folder_open;
            this.btnSelectDirectory.Location = new System.Drawing.Point(353, 7);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDirectory.TabIndex = 3;
            this.btnSelectDirectory.Text = "&Directory";
            this.btnSelectDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectDirectory.UseCompatibleTextRendering = true;
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.BtnSelectDirectory_Click);
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFolderPath.Location = new System.Drawing.Point(9, 9);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.Size = new System.Drawing.Size(331, 20);
            this.tbFolderPath.TabIndex = 2;
            this.tbFolderPath.Text = "c:\\iac";
            // 
            // panelStatistic
            // 
            this.panelStatistic.Controls.Add(this.lblTimeWork);
            this.panelStatistic.Controls.Add(this.lblCountFindedFiles);
            this.panelStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStatistic.Location = new System.Drawing.Point(450, 3);
            this.panelStatistic.Name = "panelStatistic";
            this.panelStatistic.Size = new System.Drawing.Size(294, 94);
            this.panelStatistic.TabIndex = 1;
            // 
            // lblTimeWork
            // 
            this.lblTimeWork.AutoSize = true;
            this.lblTimeWork.Location = new System.Drawing.Point(16, 17);
            this.lblTimeWork.Name = "lblTimeWork";
            this.lblTimeWork.Size = new System.Drawing.Size(35, 13);
            this.lblTimeWork.TabIndex = 14;
            this.lblTimeWork.Text = "label1";
            // 
            // lblCountFindedFiles
            // 
            this.lblCountFindedFiles.AutoSize = true;
            this.lblCountFindedFiles.Location = new System.Drawing.Point(16, 55);
            this.lblCountFindedFiles.Name = "lblCountFindedFiles";
            this.lblCountFindedFiles.Size = new System.Drawing.Size(30, 13);
            this.lblCountFindedFiles.TabIndex = 13;
            this.lblCountFindedFiles.Text = "Find ";
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.btnRemove);
            this.panelOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOperations.Location = new System.Drawing.Point(750, 3);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(412, 94);
            this.panelOperations.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(18, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Убрать уникальные";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tabFilesPage
            // 
            this.tabFilesPage.Controls.Add(this.tableLayoutFilesPanel);
            this.tabFilesPage.Location = new System.Drawing.Point(4, 22);
            this.tabFilesPage.Name = "tabFilesPage";
            this.tabFilesPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilesPage.Size = new System.Drawing.Size(1157, 539);
            this.tabFilesPage.TabIndex = 0;
            this.tabFilesPage.Text = "Файлы";
            this.tabFilesPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutFilesPanel
            // 
            this.tableLayoutFilesPanel.ColumnCount = 1;
            this.tableLayoutFilesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutFilesPanel.Controls.Add(this.chkSelectAllFiles, 0, 0);
            this.tableLayoutFilesPanel.Controls.Add(this.listView, 0, 1);
            this.tableLayoutFilesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFilesPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutFilesPanel.Name = "tableLayoutFilesPanel";
            this.tableLayoutFilesPanel.RowCount = 2;
            this.tableLayoutFilesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutFilesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutFilesPanel.Size = new System.Drawing.Size(1151, 533);
            this.tableLayoutFilesPanel.TabIndex = 10;
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
            this.chkSelectAllFiles.Click += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // listView
            // 
            this.listView.CheckBoxes = true;
            this.listView.ContextMenuStrip = this.contextMenuListView;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(3, 31);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1145, 499);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabFilesPage);
            this.tabControl.Controls.Add(this.tabDuplicatesPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 100);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1165, 565);
            this.tabControl.TabIndex = 13;
            // 
            // tabDuplicatesPage
            // 
            this.tabDuplicatesPage.Controls.Add(this.splitter1);
            this.tabDuplicatesPage.Controls.Add(this.listViewAllDuplicates);
            this.tabDuplicatesPage.Controls.Add(this.listViewDublicates);
            this.tabDuplicatesPage.Location = new System.Drawing.Point(4, 22);
            this.tabDuplicatesPage.Name = "tabDuplicatesPage";
            this.tabDuplicatesPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabDuplicatesPage.Size = new System.Drawing.Size(1157, 539);
            this.tabDuplicatesPage.TabIndex = 1;
            this.tabDuplicatesPage.Text = "Дубликаты";
            this.tabDuplicatesPage.UseVisualStyleBackColor = true;
            // 
            // listViewAllDuplicates
            // 
            this.listViewAllDuplicates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAllDuplicates.GridLines = true;
            this.listViewAllDuplicates.HideSelection = false;
            this.listViewAllDuplicates.Location = new System.Drawing.Point(3, 3);
            this.listViewAllDuplicates.Name = "listViewAllDuplicates";
            this.listViewAllDuplicates.Size = new System.Drawing.Size(1151, 333);
            this.listViewAllDuplicates.TabIndex = 9;
            this.listViewAllDuplicates.UseCompatibleStateImageBehavior = false;
            this.listViewAllDuplicates.View = System.Windows.Forms.View.Details;
            // 
            // listViewDublicates
            // 
            this.listViewDublicates.CheckBoxes = true;
            this.listViewDublicates.ContextMenuStrip = this.contextMenuListView;
            this.listViewDublicates.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewDublicates.FullRowSelect = true;
            this.listViewDublicates.GridLines = true;
            this.listViewDublicates.HideSelection = false;
            this.listViewDublicates.Location = new System.Drawing.Point(3, 336);
            this.listViewDublicates.MultiSelect = false;
            this.listViewDublicates.Name = "listViewDublicates";
            this.listViewDublicates.Size = new System.Drawing.Size(1151, 200);
            this.listViewDublicates.TabIndex = 7;
            this.listViewDublicates.UseCompatibleStateImageBehavior = false;
            this.listViewDublicates.View = System.Windows.Forms.View.Details;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(3, 333);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1151, 3);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 665);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tableLayoutDuplicatesPanel);
            this.MinimumSize = new System.Drawing.Size(696, 388);
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "win.edf";
            this.contextMenuListView.ResumeLayout(false);
            this.tableLayoutDuplicatesPanel.ResumeLayout(false);
            this.panelPathFind.ResumeLayout(false);
            this.panelPathFind.PerformLayout();
            this.panelStatistic.ResumeLayout(false);
            this.panelStatistic.PerformLayout();
            this.panelOperations.ResumeLayout(false);
            this.tabFilesPage.ResumeLayout(false);
            this.tableLayoutFilesPanel.ResumeLayout(false);
            this.tableLayoutFilesPanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabDuplicatesPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuListView;
        private System.Windows.Forms.ToolStripMenuItem showFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteOthersToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutDuplicatesPanel;
        private System.Windows.Forms.Panel panelPathFind;
        private System.Windows.Forms.Button btnStartFind;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.TextBox tbFolderPath;
        private System.Windows.Forms.Panel panelStatistic;
        private System.Windows.Forms.Label lblTimeWork;
        private System.Windows.Forms.Label lblCountFindedFiles;
        private System.Windows.Forms.Panel panelOperations;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TabPage tabFilesPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFilesPanel;
        private System.Windows.Forms.CheckBox chkSelectAllFiles;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDuplicatesPage;
        private System.Windows.Forms.ListView listViewAllDuplicates;
        private System.Windows.Forms.ListView listViewDublicates;
        private System.Windows.Forms.Splitter splitter1;
    }
}

