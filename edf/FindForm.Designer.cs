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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutDuplicatesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelPathFind = new System.Windows.Forms.Panel();
            this.linkLabelToSubRealCom = new System.Windows.Forms.LinkLabel();
            this.btnStartFind = new System.Windows.Forms.Button();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.panelStatistic = new System.Windows.Forms.Panel();
            this.labelDuplicatesCount = new System.Windows.Forms.Label();
            this.lblTimeWork = new System.Windows.Forms.Label();
            this.lblCountFindedFiles = new System.Windows.Forms.Label();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.buttonDeleteDuplicates = new System.Windows.Forms.Button();
            this.checkBoxDisableMessages = new System.Windows.Forms.CheckBox();
            this.btnShowDuplicates = new System.Windows.Forms.Button();
            this.tabFilesPage = new System.Windows.Forms.TabPage();
            this.tableLayoutFilesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chkSelectAllFiles = new System.Windows.Forms.CheckBox();
            this.listView = new System.Windows.Forms.ListView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDuplicatesPage = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listViewAllDuplicates = new System.Windows.Forms.ListView();
            this.contextMenuAllDuplicates = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAllDuplicates_ShowFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewDuplicates = new System.Windows.Forms.ListView();
            this.contextMenuDuplicates = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDuplicates_ShowFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteOthers = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCopyRight = new System.Windows.Forms.Label();
            this.contextMenuListView.SuspendLayout();
            this.tableLayoutDuplicatesPanel.SuspendLayout();
            this.panelPathFind.SuspendLayout();
            this.panelStatistic.SuspendLayout();
            this.panelOperations.SuspendLayout();
            this.tabFilesPage.SuspendLayout();
            this.tableLayoutFilesPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDuplicatesPage.SuspendLayout();
            this.contextMenuAllDuplicates.SuspendLayout();
            this.contextMenuDuplicates.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuListView
            // 
            this.contextMenuListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showFileToolStripMenuItem});
            this.contextMenuListView.Name = "contextMenuListView";
            this.contextMenuListView.Size = new System.Drawing.Size(169, 26);
            // 
            // showFileToolStripMenuItem
            // 
            this.showFileToolStripMenuItem.Name = "showFileToolStripMenuItem";
            this.showFileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.showFileToolStripMenuItem.Text = "Перейти к файлу";
            this.showFileToolStripMenuItem.Click += new System.EventHandler(this.ShowFileToolStripMenuItem_Click);
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
            this.tableLayoutDuplicatesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutDuplicatesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutDuplicatesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutDuplicatesPanel.Controls.Add(this.panelPathFind, 0, 0);
            this.tableLayoutDuplicatesPanel.Controls.Add(this.panelStatistic, 1, 0);
            this.tableLayoutDuplicatesPanel.Controls.Add(this.panelOperations, 2, 0);
            this.tableLayoutDuplicatesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutDuplicatesPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutDuplicatesPanel.Name = "tableLayoutDuplicatesPanel";
            this.tableLayoutDuplicatesPanel.RowCount = 1;
            this.tableLayoutDuplicatesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutDuplicatesPanel.Size = new System.Drawing.Size(851, 100);
            this.tableLayoutDuplicatesPanel.TabIndex = 12;
            // 
            // panelPathFind
            // 
            this.panelPathFind.Controls.Add(this.labelCopyRight);
            this.panelPathFind.Controls.Add(this.linkLabelToSubRealCom);
            this.panelPathFind.Controls.Add(this.btnStartFind);
            this.panelPathFind.Controls.Add(this.btnSelectDirectory);
            this.panelPathFind.Controls.Add(this.textBoxFolderPath);
            this.panelPathFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPathFind.Location = new System.Drawing.Point(3, 3);
            this.panelPathFind.Name = "panelPathFind";
            this.panelPathFind.Size = new System.Drawing.Size(365, 94);
            this.panelPathFind.TabIndex = 0;
            // 
            // linkLabelToSubRealCom
            // 
            this.linkLabelToSubRealCom.AutoSize = true;
            this.linkLabelToSubRealCom.Location = new System.Drawing.Point(9, 69);
            this.linkLabelToSubRealCom.Name = "linkLabelToSubRealCom";
            this.linkLabelToSubRealCom.Size = new System.Drawing.Size(126, 13);
            this.linkLabelToSubRealCom.TabIndex = 5;
            this.linkLabelToSubRealCom.TabStop = true;
            this.linkLabelToSubRealCom.Text = "https://subreal-team.com";
            this.linkLabelToSubRealCom.UseMnemonic = false;
            this.linkLabelToSubRealCom.Click += new System.EventHandler(this.linkLabelToSubRealCom_Click);
            // 
            // btnStartFind
            // 
            this.btnStartFind.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStartFind.Location = new System.Drawing.Point(277, 45);
            this.btnStartFind.Name = "btnStartFind";
            this.btnStartFind.Size = new System.Drawing.Size(75, 23);
            this.btnStartFind.TabIndex = 4;
            this.btnStartFind.Text = "&Поиск";
            this.btnStartFind.UseVisualStyleBackColor = true;
            this.btnStartFind.Click += new System.EventHandler(this.BtnStartFind_Click);
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSelectDirectory.Image = global::SubReal.EasyDuplicateFinder.Properties.Resources.icon_folder_open;
            this.btnSelectDirectory.Location = new System.Drawing.Point(277, 7);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDirectory.TabIndex = 3;
            this.btnSelectDirectory.Text = "&Папка";
            this.btnSelectDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectDirectory.UseCompatibleTextRendering = true;
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.BtnSelectDirectory_Click);
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFolderPath.Location = new System.Drawing.Point(9, 9);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(255, 20);
            this.textBoxFolderPath.TabIndex = 2;
            this.textBoxFolderPath.Text = "c:\\iac";
            // 
            // panelStatistic
            // 
            this.panelStatistic.Controls.Add(this.labelDuplicatesCount);
            this.panelStatistic.Controls.Add(this.lblTimeWork);
            this.panelStatistic.Controls.Add(this.lblCountFindedFiles);
            this.panelStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStatistic.Location = new System.Drawing.Point(374, 3);
            this.panelStatistic.Name = "panelStatistic";
            this.panelStatistic.Size = new System.Drawing.Size(264, 94);
            this.panelStatistic.TabIndex = 1;
            // 
            // labelDuplicatesCount
            // 
            this.labelDuplicatesCount.AutoSize = true;
            this.labelDuplicatesCount.Location = new System.Drawing.Point(11, 55);
            this.labelDuplicatesCount.Name = "labelDuplicatesCount";
            this.labelDuplicatesCount.Size = new System.Drawing.Size(89, 13);
            this.labelDuplicatesCount.TabIndex = 15;
            this.labelDuplicatesCount.Text = "Найдено дублей";
            // 
            // lblTimeWork
            // 
            this.lblTimeWork.AutoSize = true;
            this.lblTimeWork.Location = new System.Drawing.Point(11, 9);
            this.lblTimeWork.Name = "lblTimeWork";
            this.lblTimeWork.Size = new System.Drawing.Size(80, 13);
            this.lblTimeWork.TabIndex = 14;
            this.lblTimeWork.Text = "Время работы";
            // 
            // lblCountFindedFiles
            // 
            this.lblCountFindedFiles.AutoSize = true;
            this.lblCountFindedFiles.Location = new System.Drawing.Point(11, 33);
            this.lblCountFindedFiles.Name = "lblCountFindedFiles";
            this.lblCountFindedFiles.Size = new System.Drawing.Size(51, 13);
            this.lblCountFindedFiles.TabIndex = 13;
            this.lblCountFindedFiles.Text = "Найдено";
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.buttonDeleteDuplicates);
            this.panelOperations.Controls.Add(this.checkBoxDisableMessages);
            this.panelOperations.Controls.Add(this.btnShowDuplicates);
            this.panelOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOperations.Location = new System.Drawing.Point(644, 3);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(204, 94);
            this.panelOperations.TabIndex = 2;
            // 
            // buttonDeleteDuplicates
            // 
            this.buttonDeleteDuplicates.Location = new System.Drawing.Point(12, 59);
            this.buttonDeleteDuplicates.Name = "buttonDeleteDuplicates";
            this.buttonDeleteDuplicates.Size = new System.Drawing.Size(135, 23);
            this.buttonDeleteDuplicates.TabIndex = 16;
            this.buttonDeleteDuplicates.Text = "Удалить дубли";
            this.buttonDeleteDuplicates.UseVisualStyleBackColor = true;
            this.buttonDeleteDuplicates.Click += new System.EventHandler(this.toolStripMenuItemDeleteOthers_Click);
            // 
            // checkBoxDisableMessages
            // 
            this.checkBoxDisableMessages.AutoSize = true;
            this.checkBoxDisableMessages.Location = new System.Drawing.Point(12, 36);
            this.checkBoxDisableMessages.Name = "checkBoxDisableMessages";
            this.checkBoxDisableMessages.Size = new System.Drawing.Size(169, 17);
            this.checkBoxDisableMessages.TabIndex = 15;
            this.checkBoxDisableMessages.Text = "Отключить предупреждения";
            this.checkBoxDisableMessages.UseVisualStyleBackColor = true;
            // 
            // btnShowDuplicates
            // 
            this.btnShowDuplicates.Location = new System.Drawing.Point(12, 7);
            this.btnShowDuplicates.Name = "btnShowDuplicates";
            this.btnShowDuplicates.Size = new System.Drawing.Size(135, 23);
            this.btnShowDuplicates.TabIndex = 14;
            this.btnShowDuplicates.Text = "Показать дубли";
            this.btnShowDuplicates.UseVisualStyleBackColor = true;
            this.btnShowDuplicates.Click += new System.EventHandler(this.btnShowDuplicates_Click);
            // 
            // tabFilesPage
            // 
            this.tabFilesPage.Controls.Add(this.tableLayoutFilesPanel);
            this.tabFilesPage.Location = new System.Drawing.Point(4, 22);
            this.tabFilesPage.Name = "tabFilesPage";
            this.tabFilesPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilesPage.Size = new System.Drawing.Size(843, 396);
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
            this.tableLayoutFilesPanel.Size = new System.Drawing.Size(837, 390);
            this.tableLayoutFilesPanel.TabIndex = 10;
            // 
            // chkSelectAllFiles
            // 
            this.chkSelectAllFiles.AutoSize = true;
            this.chkSelectAllFiles.Enabled = false;
            this.chkSelectAllFiles.Location = new System.Drawing.Point(2, 8);
            this.chkSelectAllFiles.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.chkSelectAllFiles.Name = "chkSelectAllFiles";
            this.chkSelectAllFiles.Size = new System.Drawing.Size(91, 17);
            this.chkSelectAllFiles.TabIndex = 5;
            this.chkSelectAllFiles.Text = "Выбрать все";
            this.chkSelectAllFiles.UseVisualStyleBackColor = true;
            this.chkSelectAllFiles.Visible = false;
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
            this.listView.Size = new System.Drawing.Size(831, 356);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabFilesPage);
            this.tabControl.Controls.Add(this.tabDuplicatesPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 100);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(851, 422);
            this.tabControl.TabIndex = 13;
            // 
            // tabDuplicatesPage
            // 
            this.tabDuplicatesPage.Controls.Add(this.splitter1);
            this.tabDuplicatesPage.Controls.Add(this.listViewAllDuplicates);
            this.tabDuplicatesPage.Controls.Add(this.listViewDuplicates);
            this.tabDuplicatesPage.Location = new System.Drawing.Point(4, 22);
            this.tabDuplicatesPage.Name = "tabDuplicatesPage";
            this.tabDuplicatesPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabDuplicatesPage.Size = new System.Drawing.Size(843, 396);
            this.tabDuplicatesPage.TabIndex = 1;
            this.tabDuplicatesPage.Text = "Дубликаты";
            this.tabDuplicatesPage.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(3, 190);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(837, 3);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // listViewAllDuplicates
            // 
            this.listViewAllDuplicates.ContextMenuStrip = this.contextMenuAllDuplicates;
            this.listViewAllDuplicates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAllDuplicates.FullRowSelect = true;
            this.listViewAllDuplicates.GridLines = true;
            this.listViewAllDuplicates.HideSelection = false;
            this.listViewAllDuplicates.Location = new System.Drawing.Point(3, 3);
            this.listViewAllDuplicates.MultiSelect = false;
            this.listViewAllDuplicates.Name = "listViewAllDuplicates";
            this.listViewAllDuplicates.Size = new System.Drawing.Size(837, 190);
            this.listViewAllDuplicates.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewAllDuplicates.TabIndex = 9;
            this.listViewAllDuplicates.UseCompatibleStateImageBehavior = false;
            this.listViewAllDuplicates.View = System.Windows.Forms.View.Details;
            this.listViewAllDuplicates.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.listViewAllDuplicates.Click += new System.EventHandler(this.btnShowDuplicates_Click);
            this.listViewAllDuplicates.DoubleClick += new System.EventHandler(this.btnShowDuplicates_Click);
            // 
            // contextMenuAllDuplicates
            // 
            this.contextMenuAllDuplicates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAllDuplicates_ShowFile,
            this.toolStripMenuItem2});
            this.contextMenuAllDuplicates.Name = "contextMenuListView";
            this.contextMenuAllDuplicates.Size = new System.Drawing.Size(169, 48);
            // 
            // toolStripMenuItemAllDuplicates_ShowFile
            // 
            this.toolStripMenuItemAllDuplicates_ShowFile.Name = "toolStripMenuItemAllDuplicates_ShowFile";
            this.toolStripMenuItemAllDuplicates_ShowFile.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemAllDuplicates_ShowFile.Text = "Перейти к файлу";
            this.toolStripMenuItemAllDuplicates_ShowFile.Click += new System.EventHandler(this.toolStripMenuItemAllDuplicates_ShowFile_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem2.Text = "Показать дубли";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.btnShowDuplicates_Click);
            // 
            // listViewDuplicates
            // 
            this.listViewDuplicates.CheckBoxes = true;
            this.listViewDuplicates.ContextMenuStrip = this.contextMenuDuplicates;
            this.listViewDuplicates.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewDuplicates.FullRowSelect = true;
            this.listViewDuplicates.GridLines = true;
            this.listViewDuplicates.HideSelection = false;
            this.listViewDuplicates.Location = new System.Drawing.Point(3, 193);
            this.listViewDuplicates.MultiSelect = false;
            this.listViewDuplicates.Name = "listViewDuplicates";
            this.listViewDuplicates.Size = new System.Drawing.Size(837, 200);
            this.listViewDuplicates.TabIndex = 7;
            this.listViewDuplicates.UseCompatibleStateImageBehavior = false;
            this.listViewDuplicates.View = System.Windows.Forms.View.Details;
            this.listViewDuplicates.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // contextMenuDuplicates
            // 
            this.contextMenuDuplicates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDuplicates_ShowFile,
            this.toolStripMenuItemDeleteOthers});
            this.contextMenuDuplicates.Name = "contextMenuListView";
            this.contextMenuDuplicates.Size = new System.Drawing.Size(238, 48);
            // 
            // toolStripMenuItemDuplicates_ShowFile
            // 
            this.toolStripMenuItemDuplicates_ShowFile.Name = "toolStripMenuItemDuplicates_ShowFile";
            this.toolStripMenuItemDuplicates_ShowFile.Size = new System.Drawing.Size(237, 22);
            this.toolStripMenuItemDuplicates_ShowFile.Text = "Перейти к файлу";
            this.toolStripMenuItemDuplicates_ShowFile.Click += new System.EventHandler(this.toolStripMenuItemDuplicates_ShowFile_Click);
            // 
            // toolStripMenuItemDeleteOthers
            // 
            this.toolStripMenuItemDeleteOthers.Name = "toolStripMenuItemDeleteOthers";
            this.toolStripMenuItemDeleteOthers.Size = new System.Drawing.Size(237, 22);
            this.toolStripMenuItemDeleteOthers.Text = "Удалить остальные (Корзина)";
            this.toolStripMenuItemDeleteOthers.Click += new System.EventHandler(this.toolStripMenuItemDeleteOthers_Click);
            // 
            // labelCopyRight
            // 
            this.labelCopyRight.AutoSize = true;
            this.labelCopyRight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCopyRight.Location = new System.Drawing.Point(9, 55);
            this.labelCopyRight.Name = "labelCopyRight";
            this.labelCopyRight.Size = new System.Drawing.Size(119, 13);
            this.labelCopyRight.TabIndex = 6;
            this.labelCopyRight.Text = "© 2019 SubReal, Team";
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 522);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tableLayoutDuplicatesPanel);
            this.MinimumSize = new System.Drawing.Size(800, 400);
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
            this.panelOperations.PerformLayout();
            this.tabFilesPage.ResumeLayout(false);
            this.tableLayoutFilesPanel.ResumeLayout(false);
            this.tableLayoutFilesPanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabDuplicatesPage.ResumeLayout(false);
            this.contextMenuAllDuplicates.ResumeLayout(false);
            this.contextMenuDuplicates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuListView;
        private System.Windows.Forms.ToolStripMenuItem showFileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutDuplicatesPanel;
        private System.Windows.Forms.Panel panelPathFind;
        private System.Windows.Forms.Button btnStartFind;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Panel panelStatistic;
        private System.Windows.Forms.Label lblTimeWork;
        private System.Windows.Forms.Label lblCountFindedFiles;
        private System.Windows.Forms.Panel panelOperations;
        private System.Windows.Forms.Button btnShowDuplicates;
        private System.Windows.Forms.TabPage tabFilesPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFilesPanel;
        private System.Windows.Forms.CheckBox chkSelectAllFiles;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDuplicatesPage;
        private System.Windows.Forms.ListView listViewAllDuplicates;
        private System.Windows.Forms.ListView listViewDuplicates;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuAllDuplicates;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAllDuplicates_ShowFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuDuplicates;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDuplicates_ShowFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteOthers;
        private System.Windows.Forms.CheckBox checkBoxDisableMessages;
        private System.Windows.Forms.Label labelDuplicatesCount;
        private System.Windows.Forms.Button buttonDeleteDuplicates;
        private System.Windows.Forms.LinkLabel linkLabelToSubRealCom;
        private System.Windows.Forms.Label labelCopyRight;
    }
}

