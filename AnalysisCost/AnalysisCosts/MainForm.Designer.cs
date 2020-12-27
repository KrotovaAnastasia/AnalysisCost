
namespace AnalysisCosts
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.costItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedСosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualСosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedCostStructure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualСostsStructure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviationsСostsStructure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeGroupBox = new System.Windows.Forms.GroupBox();
            this.changeRadioButton = new System.Windows.Forms.RadioButton();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeTableButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.countTextBox2 = new System.Windows.Forms.TextBox();
            this.clearInfBoxButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.countTextBox1 = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.countUnitlabel = new System.Windows.Forms.Label();
            this.massLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.wayToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.countToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.modeGroupBox.SuspendLayout();
            this.propertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costItem,
            this.plannedСosts,
            this.actualСosts,
            this.deviations,
            this.plannedCostStructure,
            this.actualСostsStructure,
            this.deviationsСostsStructure});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(965, 554);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // costItem
            // 
            this.costItem.DataPropertyName = "CostItem";
            this.costItem.HeaderText = "Статьи затрат";
            this.costItem.MinimumWidth = 60;
            this.costItem.Name = "costItem";
            this.costItem.ReadOnly = true;
            this.costItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // plannedСosts
            // 
            this.plannedСosts.DataPropertyName = "PlannedСosts";
            this.plannedСosts.HeaderText = "Базисный период, руб.";
            this.plannedСosts.MinimumWidth = 60;
            this.plannedСosts.Name = "plannedСosts";
            this.plannedСosts.ReadOnly = true;
            this.plannedСosts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // actualСosts
            // 
            this.actualСosts.DataPropertyName = "ActualСosts";
            this.actualСosts.HeaderText = "Отчетный период, руб.";
            this.actualСosts.MinimumWidth = 40;
            this.actualСosts.Name = "actualСosts";
            this.actualСosts.ReadOnly = true;
            this.actualСosts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // deviations
            // 
            this.deviations.DataPropertyName = "Deviations";
            this.deviations.HeaderText = "Отклонения, руб.";
            this.deviations.MinimumWidth = 60;
            this.deviations.Name = "deviations";
            this.deviations.ReadOnly = true;
            this.deviations.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // plannedCostStructure
            // 
            this.plannedCostStructure.DataPropertyName = "PlannedCostStructure";
            this.plannedCostStructure.HeaderText = "Удельный вес в базисный период, %";
            this.plannedCostStructure.MinimumWidth = 60;
            this.plannedCostStructure.Name = "plannedCostStructure";
            this.plannedCostStructure.ReadOnly = true;
            this.plannedCostStructure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // actualСostsStructure
            // 
            this.actualСostsStructure.DataPropertyName = "ActualСostsStructure";
            this.actualСostsStructure.HeaderText = "Удельный вес в отчетный период, %";
            this.actualСostsStructure.MinimumWidth = 30;
            this.actualСostsStructure.Name = "actualСostsStructure";
            this.actualСostsStructure.ReadOnly = true;
            this.actualСostsStructure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // deviationsСostsStructure
            // 
            this.deviationsСostsStructure.DataPropertyName = "DeviationsСostsStructure";
            this.deviationsСostsStructure.HeaderText = "Отклонения, %";
            this.deviationsСostsStructure.MinimumWidth = 6;
            this.deviationsСostsStructure.Name = "deviationsСostsStructure";
            this.deviationsСostsStructure.ReadOnly = true;
            // 
            // modeGroupBox
            // 
            this.modeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modeGroupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modeGroupBox.Controls.Add(this.changeRadioButton);
            this.modeGroupBox.Controls.Add(this.addRadioButton);
            this.modeGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modeGroupBox.Location = new System.Drawing.Point(973, 46);
            this.modeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.modeGroupBox.Name = "modeGroupBox";
            this.modeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.modeGroupBox.Size = new System.Drawing.Size(329, 76);
            this.modeGroupBox.TabIndex = 3;
            this.modeGroupBox.TabStop = false;
            this.modeGroupBox.Text = "Режим";
            // 
            // changeRadioButton
            // 
            this.changeRadioButton.AutoSize = true;
            this.changeRadioButton.Checked = true;
            this.changeRadioButton.Location = new System.Drawing.Point(123, 23);
            this.changeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeRadioButton.Name = "changeRadioButton";
            this.changeRadioButton.Size = new System.Drawing.Size(93, 21);
            this.changeRadioButton.TabIndex = 1;
            this.changeRadioButton.TabStop = true;
            this.changeRadioButton.Text = "Изменить";
            this.changeRadioButton.UseVisualStyleBackColor = true;
            this.changeRadioButton.CheckedChanged += new System.EventHandler(this.changeRadioButton_CheckedChanged);
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.Location = new System.Drawing.Point(15, 23);
            this.addRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(93, 21);
            this.addRadioButton.TabIndex = 1;
            this.addRadioButton.Text = "Добавить";
            this.addRadioButton.UseVisualStyleBackColor = true;
            this.addRadioButton.CheckedChanged += new System.EventHandler(this.addRadioButton_CheckedChanged);
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesGroupBox.Controls.Add(this.deleteButton);
            this.propertiesGroupBox.Controls.Add(this.changeTableButton);
            this.propertiesGroupBox.Controls.Add(this.label1);
            this.propertiesGroupBox.Controls.Add(this.countTextBox2);
            this.propertiesGroupBox.Controls.Add(this.clearInfBoxButton);
            this.propertiesGroupBox.Controls.Add(this.nameTextBox);
            this.propertiesGroupBox.Controls.Add(this.nameLabel);
            this.propertiesGroupBox.Controls.Add(this.countTextBox1);
            this.propertiesGroupBox.Controls.Add(this.categoryLabel);
            this.propertiesGroupBox.Controls.Add(this.countUnitlabel);
            this.propertiesGroupBox.Controls.Add(this.massLabel);
            this.propertiesGroupBox.Location = new System.Drawing.Point(973, 130);
            this.propertiesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.propertiesGroupBox.Size = new System.Drawing.Size(329, 233);
            this.propertiesGroupBox.TabIndex = 7;
            this.propertiesGroupBox.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(181, 182);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(135, 28);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeTableButton
            // 
            this.changeTableButton.Location = new System.Drawing.Point(8, 182);
            this.changeTableButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeTableButton.Name = "changeTableButton";
            this.changeTableButton.Size = new System.Drawing.Size(135, 28);
            this.changeTableButton.TabIndex = 9;
            this.changeTableButton.Text = "Изменить";
            this.changeTableButton.UseVisualStyleBackColor = true;
            this.changeTableButton.Click += new System.EventHandler(this.changeTableButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "руб.";
            // 
            // countTextBox2
            // 
            this.countTextBox2.Location = new System.Drawing.Point(173, 117);
            this.countTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.countTextBox2.MaxLength = 6;
            this.countTextBox2.Name = "countTextBox2";
            this.countTextBox2.Size = new System.Drawing.Size(100, 22);
            this.countTextBox2.TabIndex = 14;
            // 
            // clearInfBoxButton
            // 
            this.clearInfBoxButton.BackColor = System.Drawing.SystemColors.Window;
            this.clearInfBoxButton.BackgroundImage = global::AnalysisCosts.Properties.Resources.крестик;
            this.clearInfBoxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearInfBoxButton.Location = new System.Drawing.Point(0, 6);
            this.clearInfBoxButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearInfBoxButton.Name = "clearInfBoxButton";
            this.clearInfBoxButton.Size = new System.Drawing.Size(24, 22);
            this.clearInfBoxButton.TabIndex = 2;
            this.clearInfBoxButton.UseVisualStyleBackColor = false;
            this.clearInfBoxButton.Click += new System.EventHandler(this.clearInfBoxButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(123, 54);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.MaxLength = 60;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(182, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 53);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(103, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Статья затрат";
            // 
            // countTextBox1
            // 
            this.countTextBox1.Location = new System.Drawing.Point(173, 84);
            this.countTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.countTextBox1.MaxLength = 6;
            this.countTextBox1.Name = "countTextBox1";
            this.countTextBox1.Size = new System.Drawing.Size(100, 22);
            this.countTextBox1.TabIndex = 7;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(12, 89);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(134, 17);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Плановые затраты";
            // 
            // countUnitlabel
            // 
            this.countUnitlabel.AutoSize = true;
            this.countUnitlabel.Location = new System.Drawing.Point(281, 87);
            this.countUnitlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countUnitlabel.Name = "countUnitlabel";
            this.countUnitlabel.Size = new System.Drawing.Size(35, 17);
            this.countUnitlabel.TabIndex = 13;
            this.countUnitlabel.Text = "руб.";
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.Location = new System.Drawing.Point(12, 120);
            this.massLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(156, 17);
            this.massLabel.TabIndex = 5;
            this.massLabel.Text = "Фактические затраты\r\n";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.White;
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1474, 28);
            this.mainMenuStrip.TabIndex = 8;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.toolStripSeparator2,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.печатьToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShowShortcutKeys = false;
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Сохранить как";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(973, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Рассчитать себестоимость";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(1152, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "Построить динамику затрат";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wayToolStripStatusLabel,
            this.countToolStripStatusLabel,
            this.toolStripProgressBar1});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 636);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(1474, 26);
            this.mainStatusStrip.TabIndex = 11;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // wayToolStripStatusLabel
            // 
            this.wayToolStripStatusLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.wayToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.wayToolStripStatusLabel.Name = "wayToolStripStatusLabel";
            this.wayToolStripStatusLabel.Size = new System.Drawing.Size(151, 20);
            this.wayToolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // countToolStripStatusLabel
            // 
            this.countToolStripStatusLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.countToolStripStatusLabel.Name = "countToolStripStatusLabel";
            this.countToolStripStatusLabel.Size = new System.Drawing.Size(151, 20);
            this.countToolStripStatusLabel.Text = "toolStripStatusLabel2";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 40;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(267, 18);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Документ XML|*.xml";
            this.openFileDialog1.Title = "Открыть";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.xml";
            this.saveFileDialog1.Filter = "Документ XML|*.xml";
            this.saveFileDialog1.Title = "Сохранить как";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1474, 662);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.modeGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.propertiesGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Анализ себестоимости продукции";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.modeGroupBox.ResumeLayout(false);
            this.modeGroupBox.PerformLayout();
            this.propertiesGroupBox.ResumeLayout(false);
            this.propertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox modeGroupBox;
        private System.Windows.Forms.RadioButton changeRadioButton;
        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.GroupBox propertiesGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeTableButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countTextBox2;
        private System.Windows.Forms.Button clearInfBoxButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox countTextBox1;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label countUnitlabel;
        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel wayToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel countToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedСosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualСosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviations;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedCostStructure;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualСostsStructure;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviationsСostsStructure;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

