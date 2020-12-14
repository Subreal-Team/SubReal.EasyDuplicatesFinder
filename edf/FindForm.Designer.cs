namespace SubReal.EasyDuplicatesFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindForm));
            this.contextMenuListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileListView = new System.Windows.Forms.ToolStripMenuItem();
            this.showFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutDuplicatesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelPathFind = new System.Windows.Forms.Panel();
            this.labelCopyRight = new System.Windows.Forms.Label();
            this.linkLabelToSubRealCom = new System.Windows.Forms.LinkLabel();
            this.buttonStartFind = new System.Windows.Forms.Button();
            this.buttonSelectDirectory = new System.Windows.Forms.Button();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.panelStatistic = new System.Windows.Forms.Panel();
            this.buttonGoToFile = new System.Windows.Forms.Button();
            this.labelDuplicatesCount = new System.Windows.Forms.Label();
            this.lblTimeWork = new System.Windows.Forms.Label();
            this.buttonShowDuplicates = new System.Windows.Forms.Button();
            this.lblCountFindedFiles = new System.Windows.Forms.Label();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.buttonShowAboutBox = new System.Windows.Forms.Button();
            this.contextMenuAllDuplicates = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileAllDuplicates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAllDuplicates_ShowFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteAllOthers = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDuplicates = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenFileDuplicates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDuplicates_ShowFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteOthers = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteChekedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveOptions = new System.Windows.Forms.Button();
            this.checkBoxGoToDuplicatesIfFind = new System.Windows.Forms.CheckBox();
            this.checkBoxSortOnDefault = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableFullDelete = new System.Windows.Forms.CheckBox();
            this.checkBoxDisableMessages = new System.Windows.Forms.CheckBox();
            this.tabDuplicatesPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelDuplicatesFiles = new System.Windows.Forms.Panel();
            this.listViewDuplicates = new System.Windows.Forms.ListView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabFilesPage = new System.Windows.Forms.TabPage();
            this.tableLayoutFilesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.listView = new System.Windows.Forms.ListView();
            this.chkSelectAllFiles = new System.Windows.Forms.CheckBox();
            this.splitterDuplicatesTab = new System.Windows.Forms.Splitter();
            this.listViewAllDuplicates = new System.Windows.Forms.ListView();
            this.panelButtonsDuplicates = new System.Windows.Forms.Panel();
            this.buttonDeleteDuplicates = new System.Windows.Forms.Button();
            this.buttonDeleteChekedFiles = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenuListView.SuspendLayout();
            this.tableLayoutDuplicatesPanel.SuspendLayout();
            this.panelPathFind.SuspendLayout();
            this.panelStatistic.SuspendLayout();
            this.panelOperations.SuspendLayout();
            this.contextMenuAllDuplicates.SuspendLayout();
            this.contextMenuDuplicates.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabDuplicatesPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelDuplicatesFiles.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabFilesPage.SuspendLayout();
            this.tableLayoutFilesPanel.SuspendLayout();
            this.panelButtonsDuplicates.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuListView
            // 
            this.contextMenuListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileListView,
            this.showFileToolStripMenuItem});
            this.contextMenuListView.Name = "contextMenuListView";
            this.contextMenuListView.Size = new System.Drawing.Size(169, 48);
            // 
            // openFileListView
            // 
            this.openFileListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.openFileListView.Name = "openFileListView";
            this.openFileListView.Size = new System.Drawing.Size(168, 22);
            this.openFileListView.Text = "Открыть файл";
            this.openFileListView.Click += new System.EventHandler(this.openFileListView_Click);
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
            this.tableLayoutDuplicatesPanel.Size = new System.Drawing.Size(784, 100);
            this.tableLayoutDuplicatesPanel.TabIndex = 12;
            // 
            // panelPathFind
            // 
            this.panelPathFind.Controls.Add(this.labelCopyRight);
            this.panelPathFind.Controls.Add(this.linkLabelToSubRealCom);
            this.panelPathFind.Controls.Add(this.buttonStartFind);
            this.panelPathFind.Controls.Add(this.buttonSelectDirectory);
            this.panelPathFind.Controls.Add(this.textBoxFolderPath);
            this.panelPathFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPathFind.Location = new System.Drawing.Point(3, 3);
            this.panelPathFind.Name = "panelPathFind";
            this.panelPathFind.Size = new System.Drawing.Size(322, 94);
            this.panelPathFind.TabIndex = 0;
            // 
            // labelCopyRight
            // 
            this.labelCopyRight.AutoSize = true;
            this.labelCopyRight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCopyRight.Location = new System.Drawing.Point(9, 55);
            this.labelCopyRight.Name = "labelCopyRight";
            this.labelCopyRight.Size = new System.Drawing.Size(147, 13);
            this.labelCopyRight.TabIndex = 6;
            this.labelCopyRight.Text = "© 2019-2020 SubReal, Team";
            // 
            // linkLabelToSubRealCom
            // 
            this.linkLabelToSubRealCom.AutoSize = true;
            this.linkLabelToSubRealCom.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelToSubRealCom.Location = new System.Drawing.Point(9, 69);
            this.linkLabelToSubRealCom.Name = "linkLabelToSubRealCom";
            this.linkLabelToSubRealCom.Size = new System.Drawing.Size(126, 13);
            this.linkLabelToSubRealCom.TabIndex = 5;
            this.linkLabelToSubRealCom.TabStop = true;
            this.linkLabelToSubRealCom.Text = "https://subreal-team.com";
            this.linkLabelToSubRealCom.UseMnemonic = false;
            this.linkLabelToSubRealCom.Click += new System.EventHandler(this.linkLabelToSubRealCom_Click);
            // 
            // buttonStartFind
            // 
            this.buttonStartFind.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonStartFind.Location = new System.Drawing.Point(234, 64);
            this.buttonStartFind.Name = "buttonStartFind";
            this.buttonStartFind.Size = new System.Drawing.Size(75, 23);
            this.buttonStartFind.TabIndex = 4;
            this.buttonStartFind.Text = "&Поиск";
            this.buttonStartFind.UseVisualStyleBackColor = true;
            this.buttonStartFind.Click += new System.EventHandler(this.BtnStartFind_Click);
            // 
            // buttonSelectDirectory
            // 
            this.buttonSelectDirectory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSelectDirectory.Image = global::SubReal.EasyDuplicateFinder.Properties.Resources.icon_folder_open;
            this.buttonSelectDirectory.Location = new System.Drawing.Point(234, 35);
            this.buttonSelectDirectory.Name = "buttonSelectDirectory";
            this.buttonSelectDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectDirectory.TabIndex = 3;
            this.buttonSelectDirectory.Text = "&Папка";
            this.buttonSelectDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSelectDirectory.UseCompatibleTextRendering = true;
            this.buttonSelectDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectDirectory.Click += new System.EventHandler(this.BtnSelectDirectory_Click);
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFolderPath.Location = new System.Drawing.Point(9, 9);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(300, 20);
            this.textBoxFolderPath.TabIndex = 2;
            this.textBoxFolderPath.Text = "c:\\iac";
            // 
            // panelStatistic
            // 
            this.panelStatistic.Controls.Add(this.buttonGoToFile);
            this.panelStatistic.Controls.Add(this.labelDuplicatesCount);
            this.panelStatistic.Controls.Add(this.lblTimeWork);
            this.panelStatistic.Controls.Add(this.buttonShowDuplicates);
            this.panelStatistic.Controls.Add(this.lblCountFindedFiles);
            this.panelStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStatistic.Location = new System.Drawing.Point(331, 3);
            this.panelStatistic.Name = "panelStatistic";
            this.panelStatistic.Size = new System.Drawing.Size(264, 94);
            this.panelStatistic.TabIndex = 1;
            // 
            // buttonGoToFile
            // 
            this.buttonGoToFile.Location = new System.Drawing.Point(14, 64);
            this.buttonGoToFile.Name = "buttonGoToFile";
            this.buttonGoToFile.Size = new System.Drawing.Size(161, 23);
            this.buttonGoToFile.TabIndex = 16;
            this.buttonGoToFile.Text = "Перейти к файлу";
            this.buttonGoToFile.UseVisualStyleBackColor = true;
            this.buttonGoToFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // labelDuplicatesCount
            // 
            this.labelDuplicatesCount.AutoSize = true;
            this.labelDuplicatesCount.Location = new System.Drawing.Point(11, 45);
            this.labelDuplicatesCount.Name = "labelDuplicatesCount";
            this.labelDuplicatesCount.Size = new System.Drawing.Size(89, 13);
            this.labelDuplicatesCount.TabIndex = 15;
            this.labelDuplicatesCount.Text = "Найдено дублей";
            // 
            // lblTimeWork
            // 
            this.lblTimeWork.AutoSize = true;
            this.lblTimeWork.Location = new System.Drawing.Point(11, 6);
            this.lblTimeWork.Name = "lblTimeWork";
            this.lblTimeWork.Size = new System.Drawing.Size(80, 13);
            this.lblTimeWork.TabIndex = 14;
            this.lblTimeWork.Text = "Время работы";
            // 
            // buttonShowDuplicates
            // 
            this.buttonShowDuplicates.Location = new System.Drawing.Point(194, 64);
            this.buttonShowDuplicates.Name = "buttonShowDuplicates";
            this.buttonShowDuplicates.Size = new System.Drawing.Size(67, 23);
            this.buttonShowDuplicates.TabIndex = 14;
            this.buttonShowDuplicates.Text = "Дубли";
            this.buttonShowDuplicates.UseVisualStyleBackColor = true;
            this.buttonShowDuplicates.Visible = false;
            this.buttonShowDuplicates.Click += new System.EventHandler(this.btnShowDuplicates_Click);
            // 
            // lblCountFindedFiles
            // 
            this.lblCountFindedFiles.AutoSize = true;
            this.lblCountFindedFiles.Location = new System.Drawing.Point(11, 25);
            this.lblCountFindedFiles.Name = "lblCountFindedFiles";
            this.lblCountFindedFiles.Size = new System.Drawing.Size(51, 13);
            this.lblCountFindedFiles.TabIndex = 13;
            this.lblCountFindedFiles.Text = "Найдено";
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.buttonShowAboutBox);
            this.panelOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOperations.Location = new System.Drawing.Point(601, 3);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(180, 94);
            this.panelOperations.TabIndex = 2;
            // 
            // buttonShowAboutBox
            // 
            this.buttonShowAboutBox.Location = new System.Drawing.Point(11, 6);
            this.buttonShowAboutBox.Name = "buttonShowAboutBox";
            this.buttonShowAboutBox.Size = new System.Drawing.Size(163, 23);
            this.buttonShowAboutBox.TabIndex = 17;
            this.buttonShowAboutBox.Text = "О программе";
            this.buttonShowAboutBox.UseVisualStyleBackColor = true;
            this.buttonShowAboutBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuAllDuplicates
            // 
            this.contextMenuAllDuplicates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileAllDuplicates,
            this.toolStripMenuItemAllDuplicates_ShowFile,
            this.toolStripMenuItem2,
            this.toolStripMenuItemDeleteAllOthers});
            this.contextMenuAllDuplicates.Name = "contextMenuListView";
            this.contextMenuAllDuplicates.Size = new System.Drawing.Size(274, 92);
            // 
            // openFileAllDuplicates
            // 
            this.openFileAllDuplicates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.openFileAllDuplicates.Name = "openFileAllDuplicates";
            this.openFileAllDuplicates.Size = new System.Drawing.Size(273, 22);
            this.openFileAllDuplicates.Text = "Открыть файл";
            this.openFileAllDuplicates.Click += new System.EventHandler(this.openFileAllDuplicates_Click);
            // 
            // toolStripMenuItemAllDuplicates_ShowFile
            // 
            this.toolStripMenuItemAllDuplicates_ShowFile.Name = "toolStripMenuItemAllDuplicates_ShowFile";
            this.toolStripMenuItemAllDuplicates_ShowFile.Size = new System.Drawing.Size(273, 22);
            this.toolStripMenuItemAllDuplicates_ShowFile.Text = "Перейти к файлу";
            this.toolStripMenuItemAllDuplicates_ShowFile.Click += new System.EventHandler(this.toolStripMenuItemAllDuplicates_ShowFile_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(273, 22);
            this.toolStripMenuItem2.Text = "Показать дубли";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.btnShowDuplicates_Click);
            // 
            // toolStripMenuItemDeleteAllOthers
            // 
            this.toolStripMenuItemDeleteAllOthers.Name = "toolStripMenuItemDeleteAllOthers";
            this.toolStripMenuItemDeleteAllOthers.Size = new System.Drawing.Size(273, 22);
            this.toolStripMenuItemDeleteAllOthers.Text = "Удалить остальные дубли (Корзина)";
            this.toolStripMenuItemDeleteAllOthers.Click += new System.EventHandler(this.toolStripMenuItemDeleteAllOthers_Click);
            // 
            // contextMenuDuplicates
            // 
            this.contextMenuDuplicates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileDuplicates,
            this.toolStripMenuItemDuplicates_ShowFile,
            this.toolStripMenuItemDeleteOthers,
            this.deleteChekedToolStripMenuItem});
            this.contextMenuDuplicates.Name = "contextMenuListView";
            this.contextMenuDuplicates.Size = new System.Drawing.Size(248, 92);
            // 
            // OpenFileDuplicates
            // 
            this.OpenFileDuplicates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.OpenFileDuplicates.Name = "OpenFileDuplicates";
            this.OpenFileDuplicates.Size = new System.Drawing.Size(247, 22);
            this.OpenFileDuplicates.Text = "Открыть файл";
            this.OpenFileDuplicates.Click += new System.EventHandler(this.OpenFileDuplicates_Click);
            // 
            // toolStripMenuItemDuplicates_ShowFile
            // 
            this.toolStripMenuItemDuplicates_ShowFile.Name = "toolStripMenuItemDuplicates_ShowFile";
            this.toolStripMenuItemDuplicates_ShowFile.Size = new System.Drawing.Size(247, 22);
            this.toolStripMenuItemDuplicates_ShowFile.Text = "Перейти к файлу";
            this.toolStripMenuItemDuplicates_ShowFile.Click += new System.EventHandler(this.toolStripMenuItemDuplicates_ShowFile_Click);
            // 
            // toolStripMenuItemDeleteOthers
            // 
            this.toolStripMenuItemDeleteOthers.Name = "toolStripMenuItemDeleteOthers";
            this.toolStripMenuItemDeleteOthers.Size = new System.Drawing.Size(247, 22);
            this.toolStripMenuItemDeleteOthers.Text = "Удалить остальные (Корзина)";
            this.toolStripMenuItemDeleteOthers.Click += new System.EventHandler(this.toolStripMenuItemDeleteOthers_Click);
            // 
            // deleteChekedToolStripMenuItem
            // 
            this.deleteChekedToolStripMenuItem.Name = "deleteChekedToolStripMenuItem";
            this.deleteChekedToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.deleteChekedToolStripMenuItem.Text = "Удалить отмеченные (Корзина)";
            this.deleteChekedToolStripMenuItem.Click += new System.EventHandler(this.deleteChekedToolStripMenuItem_Click);
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.panel1);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Size = new System.Drawing.Size(776, 358);
            this.tabOptions.TabIndex = 3;
            this.tabOptions.Text = "Настройки";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.buttonSaveOptions);
            this.panel1.Controls.Add(this.checkBoxGoToDuplicatesIfFind);
            this.panel1.Controls.Add(this.checkBoxSortOnDefault);
            this.panel1.Controls.Add(this.checkBoxEnableFullDelete);
            this.panel1.Controls.Add(this.checkBoxDisableMessages);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 358);
            this.panel1.TabIndex = 16;
            // 
            // buttonSaveOptions
            // 
            this.buttonSaveOptions.Enabled = false;
            this.buttonSaveOptions.Location = new System.Drawing.Point(372, 12);
            this.buttonSaveOptions.Name = "buttonSaveOptions";
            this.buttonSaveOptions.Size = new System.Drawing.Size(219, 23);
            this.buttonSaveOptions.TabIndex = 18;
            this.buttonSaveOptions.Text = "Сохранить настройки";
            this.buttonSaveOptions.UseVisualStyleBackColor = true;
            this.buttonSaveOptions.Click += new System.EventHandler(this.buttonSaveOptions_Click);
            // 
            // checkBoxGoToDuplicatesIfFind
            // 
            this.checkBoxGoToDuplicatesIfFind.AutoSize = true;
            this.checkBoxGoToDuplicatesIfFind.Location = new System.Drawing.Point(11, 85);
            this.checkBoxGoToDuplicatesIfFind.Name = "checkBoxGoToDuplicatesIfFind";
            this.checkBoxGoToDuplicatesIfFind.Size = new System.Drawing.Size(292, 17);
            this.checkBoxGoToDuplicatesIfFind.TabIndex = 17;
            this.checkBoxGoToDuplicatesIfFind.Text = "Показывать вкладку \'Дубликаты\' если они найдены";
            this.checkBoxGoToDuplicatesIfFind.UseVisualStyleBackColor = true;
            this.checkBoxGoToDuplicatesIfFind.CheckedChanged += new System.EventHandler(this.checkBoxGoToDuplicatesIfFind_CheckedChanged);
            // 
            // checkBoxSortOnDefault
            // 
            this.checkBoxSortOnDefault.AutoSize = true;
            this.checkBoxSortOnDefault.Enabled = false;
            this.checkBoxSortOnDefault.Location = new System.Drawing.Point(11, 62);
            this.checkBoxSortOnDefault.Name = "checkBoxSortOnDefault";
            this.checkBoxSortOnDefault.Size = new System.Drawing.Size(242, 17);
            this.checkBoxSortOnDefault.TabIndex = 16;
            this.checkBoxSortOnDefault.Text = "Сортировка по умолчанию /В разработке/";
            this.checkBoxSortOnDefault.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableFullDelete
            // 
            this.checkBoxEnableFullDelete.AutoSize = true;
            this.checkBoxEnableFullDelete.Location = new System.Drawing.Point(11, 39);
            this.checkBoxEnableFullDelete.Name = "checkBoxEnableFullDelete";
            this.checkBoxEnableFullDelete.Size = new System.Drawing.Size(227, 17);
            this.checkBoxEnableFullDelete.TabIndex = 14;
            this.checkBoxEnableFullDelete.Tag = "0";
            this.checkBoxEnableFullDelete.Text = "Удалять минуя корзину (безвозвратно)";
            this.checkBoxEnableFullDelete.UseVisualStyleBackColor = true;
            this.checkBoxEnableFullDelete.CheckedChanged += new System.EventHandler(this.checkBoxEnableFullDelete_CheckedChanged);
            // 
            // checkBoxDisableMessages
            // 
            this.checkBoxDisableMessages.AutoSize = true;
            this.checkBoxDisableMessages.Location = new System.Drawing.Point(11, 16);
            this.checkBoxDisableMessages.Name = "checkBoxDisableMessages";
            this.checkBoxDisableMessages.Size = new System.Drawing.Size(169, 17);
            this.checkBoxDisableMessages.TabIndex = 15;
            this.checkBoxDisableMessages.Text = "Отключить предупреждения";
            this.checkBoxDisableMessages.UseVisualStyleBackColor = true;
            this.checkBoxDisableMessages.CheckedChanged += new System.EventHandler(this.checkBoxDisableMessages_CheckedChanged);
            // 
            // tabDuplicatesPage
            // 
            this.tabDuplicatesPage.Controls.Add(this.tableLayoutPanel1);
            this.tabDuplicatesPage.Location = new System.Drawing.Point(4, 22);
            this.tabDuplicatesPage.Name = "tabDuplicatesPage";
            this.tabDuplicatesPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabDuplicatesPage.Size = new System.Drawing.Size(776, 358);
            this.tabDuplicatesPage.TabIndex = 4;
            this.tabDuplicatesPage.Text = "Дубликаты";
            this.tabDuplicatesPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelButtonsDuplicates, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelDuplicatesFiles, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 352);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelDuplicatesFiles
            // 
            this.panelDuplicatesFiles.Controls.Add(this.splitterDuplicatesTab);
            this.panelDuplicatesFiles.Controls.Add(this.listViewAllDuplicates);
            this.panelDuplicatesFiles.Controls.Add(this.listViewDuplicates);
            this.panelDuplicatesFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDuplicatesFiles.Location = new System.Drawing.Point(3, 23);
            this.panelDuplicatesFiles.Name = "panelDuplicatesFiles";
            this.panelDuplicatesFiles.Size = new System.Drawing.Size(764, 286);
            this.panelDuplicatesFiles.TabIndex = 1;
            // 
            // listViewDuplicates
            // 
            this.listViewDuplicates.CheckBoxes = true;
            this.listViewDuplicates.ContextMenuStrip = this.contextMenuDuplicates;
            this.listViewDuplicates.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewDuplicates.FullRowSelect = true;
            this.listViewDuplicates.GridLines = true;
            this.listViewDuplicates.HideSelection = false;
            this.listViewDuplicates.Location = new System.Drawing.Point(0, 167);
            this.listViewDuplicates.MultiSelect = false;
            this.listViewDuplicates.Name = "listViewDuplicates";
            this.listViewDuplicates.Size = new System.Drawing.Size(764, 119);
            this.listViewDuplicates.TabIndex = 11;
            this.listViewDuplicates.UseCompatibleStateImageBehavior = false;
            this.listViewDuplicates.View = System.Windows.Forms.View.Details;
            this.listViewDuplicates.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabFilesPage);
            this.tabControl.Controls.Add(this.tabDuplicatesPage);
            this.tabControl.Controls.Add(this.tabOptions);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 100);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 384);
            this.tabControl.TabIndex = 13;
            // 
            // tabFilesPage
            // 
            this.tabFilesPage.Controls.Add(this.tableLayoutFilesPanel);
            this.tabFilesPage.Location = new System.Drawing.Point(4, 22);
            this.tabFilesPage.Name = "tabFilesPage";
            this.tabFilesPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilesPage.Size = new System.Drawing.Size(776, 358);
            this.tabFilesPage.TabIndex = 5;
            this.tabFilesPage.Text = "Файлы";
            this.tabFilesPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutFilesPanel
            // 
            this.tableLayoutFilesPanel.AutoScroll = true;
            this.tableLayoutFilesPanel.ColumnCount = 1;
            this.tableLayoutFilesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutFilesPanel.Controls.Add(this.listView, 0, 1);
            this.tableLayoutFilesPanel.Controls.Add(this.chkSelectAllFiles, 0, 0);
            this.tableLayoutFilesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFilesPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutFilesPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.tableLayoutFilesPanel.Name = "tableLayoutFilesPanel";
            this.tableLayoutFilesPanel.RowCount = 2;
            this.tableLayoutFilesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutFilesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutFilesPanel.Size = new System.Drawing.Size(770, 352);
            this.tableLayoutFilesPanel.TabIndex = 10;
            // 
            // listView
            // 
            this.listView.CheckBoxes = true;
            this.listView.ContextMenuStrip = this.contextMenuListView;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(3, 23);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(764, 326);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // chkSelectAllFiles
            // 
            this.chkSelectAllFiles.AutoSize = true;
            this.chkSelectAllFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSelectAllFiles.Enabled = false;
            this.chkSelectAllFiles.Location = new System.Drawing.Point(4, 0);
            this.chkSelectAllFiles.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.chkSelectAllFiles.Name = "chkSelectAllFiles";
            this.chkSelectAllFiles.Size = new System.Drawing.Size(764, 20);
            this.chkSelectAllFiles.TabIndex = 5;
            this.chkSelectAllFiles.Text = "Выбрать все";
            this.chkSelectAllFiles.UseVisualStyleBackColor = true;
            this.chkSelectAllFiles.Visible = false;
            // 
            // splitterDuplicatesTab
            // 
            this.splitterDuplicatesTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitterDuplicatesTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterDuplicatesTab.Location = new System.Drawing.Point(0, 164);
            this.splitterDuplicatesTab.Name = "splitterDuplicatesTab";
            this.splitterDuplicatesTab.Size = new System.Drawing.Size(764, 3);
            this.splitterDuplicatesTab.TabIndex = 15;
            this.splitterDuplicatesTab.TabStop = false;
            // 
            // listViewAllDuplicates
            // 
            this.listViewAllDuplicates.ContextMenuStrip = this.contextMenuAllDuplicates;
            this.listViewAllDuplicates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAllDuplicates.FullRowSelect = true;
            this.listViewAllDuplicates.GridLines = true;
            this.listViewAllDuplicates.HideSelection = false;
            this.listViewAllDuplicates.Location = new System.Drawing.Point(0, 0);
            this.listViewAllDuplicates.MultiSelect = false;
            this.listViewAllDuplicates.Name = "listViewAllDuplicates";
            this.listViewAllDuplicates.Size = new System.Drawing.Size(764, 167);
            this.listViewAllDuplicates.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewAllDuplicates.TabIndex = 14;
            this.listViewAllDuplicates.UseCompatibleStateImageBehavior = false;
            this.listViewAllDuplicates.View = System.Windows.Forms.View.Details;
            this.listViewAllDuplicates.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.listViewAllDuplicates.Click += new System.EventHandler(this.btnShowDuplicates_Click);
            // 
            // panelButtonsDuplicates
            // 
            this.panelButtonsDuplicates.Controls.Add(this.buttonDeleteDuplicates);
            this.panelButtonsDuplicates.Controls.Add(this.buttonDeleteChekedFiles);
            this.panelButtonsDuplicates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtonsDuplicates.Location = new System.Drawing.Point(3, 315);
            this.panelButtonsDuplicates.Name = "panelButtonsDuplicates";
            this.panelButtonsDuplicates.Size = new System.Drawing.Size(764, 34);
            this.panelButtonsDuplicates.TabIndex = 2;
            // 
            // buttonDeleteDuplicates
            // 
            this.buttonDeleteDuplicates.AllowDrop = true;
            this.buttonDeleteDuplicates.Enabled = false;
            this.buttonDeleteDuplicates.Location = new System.Drawing.Point(5, 5);
            this.buttonDeleteDuplicates.Name = "buttonDeleteDuplicates";
            this.buttonDeleteDuplicates.Size = new System.Drawing.Size(163, 23);
            this.buttonDeleteDuplicates.TabIndex = 16;
            this.buttonDeleteDuplicates.Text = "Удалить остальные";
            this.buttonDeleteDuplicates.UseVisualStyleBackColor = true;
            this.buttonDeleteDuplicates.Click += new System.EventHandler(this.toolStripMenuItemDeleteOthers_Click);
            // 
            // buttonDeleteChekedFiles
            // 
            this.buttonDeleteChekedFiles.AllowDrop = true;
            this.buttonDeleteChekedFiles.Enabled = false;
            this.buttonDeleteChekedFiles.Location = new System.Drawing.Point(174, 5);
            this.buttonDeleteChekedFiles.Name = "buttonDeleteChekedFiles";
            this.buttonDeleteChekedFiles.Size = new System.Drawing.Size(163, 23);
            this.buttonDeleteChekedFiles.TabIndex = 16;
            this.buttonDeleteChekedFiles.Text = "Удалить отмеченные";
            this.buttonDeleteChekedFiles.UseVisualStyleBackColor = true;
            this.buttonDeleteChekedFiles.Click += new System.EventHandler(this.deleteChekedToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(4, 0);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(764, 20);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Выбрать все";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 484);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tableLayoutDuplicatesPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "win.edf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindForm_FormClosing);
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.contextMenuListView.ResumeLayout(false);
            this.tableLayoutDuplicatesPanel.ResumeLayout(false);
            this.panelPathFind.ResumeLayout(false);
            this.panelPathFind.PerformLayout();
            this.panelStatistic.ResumeLayout(false);
            this.panelStatistic.PerformLayout();
            this.panelOperations.ResumeLayout(false);
            this.contextMenuAllDuplicates.ResumeLayout(false);
            this.contextMenuDuplicates.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabDuplicatesPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelDuplicatesFiles.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabFilesPage.ResumeLayout(false);
            this.tableLayoutFilesPanel.ResumeLayout(false);
            this.tableLayoutFilesPanel.PerformLayout();
            this.panelButtonsDuplicates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuListView;
        private System.Windows.Forms.ToolStripMenuItem showFileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutDuplicatesPanel;
        private System.Windows.Forms.Panel panelPathFind;
        private System.Windows.Forms.Button buttonStartFind;
        private System.Windows.Forms.Button buttonSelectDirectory;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Panel panelStatistic;
        private System.Windows.Forms.Label lblTimeWork;
        private System.Windows.Forms.Label lblCountFindedFiles;
        private System.Windows.Forms.Button buttonShowDuplicates;
        private System.Windows.Forms.ContextMenuStrip contextMenuAllDuplicates;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAllDuplicates_ShowFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuDuplicates;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDuplicates_ShowFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteOthers;
        private System.Windows.Forms.Label labelDuplicatesCount;
        private System.Windows.Forms.LinkLabel linkLabelToSubRealCom;
        private System.Windows.Forms.Label labelCopyRight;
        private System.Windows.Forms.ToolStripMenuItem deleteChekedToolStripMenuItem;
        private System.Windows.Forms.Button buttonGoToFile;
        private System.Windows.Forms.ToolStripMenuItem OpenFileDuplicates;
        private System.Windows.Forms.ToolStripMenuItem openFileListView;
        private System.Windows.Forms.ToolStripMenuItem openFileAllDuplicates;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteAllOthers;
        private System.Windows.Forms.Panel panelOperations;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonShowAboutBox;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSaveOptions;
        private System.Windows.Forms.CheckBox checkBoxGoToDuplicatesIfFind;
        private System.Windows.Forms.CheckBox checkBoxSortOnDefault;
        private System.Windows.Forms.CheckBox checkBoxEnableFullDelete;
        private System.Windows.Forms.CheckBox checkBoxDisableMessages;
        private System.Windows.Forms.TabPage tabDuplicatesPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelDuplicatesFiles;
        private System.Windows.Forms.ListView listViewDuplicates;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabFilesPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFilesPanel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.CheckBox chkSelectAllFiles;
        private System.Windows.Forms.Panel panelButtonsDuplicates;
        private System.Windows.Forms.Button buttonDeleteDuplicates;
        private System.Windows.Forms.Button buttonDeleteChekedFiles;
        private System.Windows.Forms.Splitter splitterDuplicatesTab;
        private System.Windows.Forms.ListView listViewAllDuplicates;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

