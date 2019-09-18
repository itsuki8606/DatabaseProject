namespace DatabaseProject
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Select = new System.Windows.Forms.TabPage();
            this.selectButton = new System.Windows.Forms.Button();
            this.selectDataGridView = new System.Windows.Forms.DataGridView();
            this.selectConstraint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectAttribute = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.selectTable = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.TabPage();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateDataGridView = new System.Windows.Forms.DataGridView();
            this.updateConstraint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateAttribute = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.TabPage();
            this.addButton = new System.Windows.Forms.Button();
            this.addDataGridView = new System.Windows.Forms.DataGridView();
            this.addContent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addAttribute = new System.Windows.Forms.Label();
            this.addTable = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.TabPage();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteConstraint = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.deleteTable = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.InExist = new System.Windows.Forms.TabPage();
            this.inExistFunctionSelect = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.inExistRange = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.inExistButton = new System.Windows.Forms.Button();
            this.inExistDataGridView = new System.Windows.Forms.DataGridView();
            this.inExistConstraint = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.inExistAttribute = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.inExistTable = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Aggregate = new System.Windows.Forms.TabPage();
            this.havingConstraint = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.aggregateFunctionSelector = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.aggregateButton = new System.Windows.Forms.Button();
            this.aggregateDataGridView = new System.Windows.Forms.DataGridView();
            this.aggregateConstraint = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.aggregateAttribute = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.aggregateTable = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.SQL = new System.Windows.Forms.TabPage();
            this.mySQLDataGridView = new System.Windows.Forms.DataGridView();
            this.mySQLButton = new System.Windows.Forms.Button();
            this.mySQLText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseDatabaseDataSet = new DatabaseProject.CourseDatabaseDataSet();
            this.tabControl1.SuspendLayout();
            this.Select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectDataGridView)).BeginInit();
            this.Update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateDataGridView)).BeginInit();
            this.Insert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDataGridView)).BeginInit();
            this.Delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteDataGridView)).BeginInit();
            this.InExist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inExistDataGridView)).BeginInit();
            this.Aggregate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aggregateDataGridView)).BeginInit();
            this.SQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mySQLDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Select);
            this.tabControl1.Controls.Add(this.Update);
            this.tabControl1.Controls.Add(this.Insert);
            this.tabControl1.Controls.Add(this.Delete);
            this.tabControl1.Controls.Add(this.InExist);
            this.tabControl1.Controls.Add(this.Aggregate);
            this.tabControl1.Controls.Add(this.SQL);
            this.tabControl1.Location = new System.Drawing.Point(4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1195, 946);
            this.tabControl1.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.Controls.Add(this.selectButton);
            this.Select.Controls.Add(this.selectDataGridView);
            this.Select.Controls.Add(this.selectConstraint);
            this.Select.Controls.Add(this.label6);
            this.Select.Controls.Add(this.selectAttribute);
            this.Select.Controls.Add(this.label8);
            this.Select.Controls.Add(this.selectTable);
            this.Select.Controls.Add(this.label9);
            this.Select.Location = new System.Drawing.Point(10, 48);
            this.Select.Name = "Select";
            this.Select.Padding = new System.Windows.Forms.Padding(3);
            this.Select.Size = new System.Drawing.Size(1175, 888);
            this.Select.TabIndex = 0;
            this.Select.Text = "搜尋資料";
            this.Select.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(879, 349);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(219, 49);
            this.selectButton.TabIndex = 19;
            this.selectButton.Text = "搜尋";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // selectDataGridView
            // 
            this.selectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectDataGridView.Location = new System.Drawing.Point(23, 434);
            this.selectDataGridView.Name = "selectDataGridView";
            this.selectDataGridView.RowTemplate.Height = 45;
            this.selectDataGridView.Size = new System.Drawing.Size(1129, 444);
            this.selectDataGridView.TabIndex = 18;
            // 
            // selectConstraint
            // 
            this.selectConstraint.Location = new System.Drawing.Point(218, 245);
            this.selectConstraint.Name = "selectConstraint";
            this.selectConstraint.Size = new System.Drawing.Size(889, 43);
            this.selectConstraint.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "搜尋條件：";
            // 
            // selectAttribute
            // 
            this.selectAttribute.FormattingEnabled = true;
            this.selectAttribute.Location = new System.Drawing.Point(218, 135);
            this.selectAttribute.Name = "selectAttribute";
            this.selectAttribute.Size = new System.Drawing.Size(889, 38);
            this.selectAttribute.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 30);
            this.label8.TabIndex = 12;
            this.label8.Text = "搜尋欄位：";
            // 
            // selectTable
            // 
            this.selectTable.FormattingEnabled = true;
            this.selectTable.Items.AddRange(new object[] {
            "College",
            "Department",
            "Teacher",
            "Student",
            "Course",
            "StudentCourse"});
            this.selectTable.Location = new System.Drawing.Point(218, 28);
            this.selectTable.Name = "selectTable";
            this.selectTable.Size = new System.Drawing.Size(889, 38);
            this.selectTable.TabIndex = 11;
            this.selectTable.SelectedIndexChanged += new System.EventHandler(this.selectTable_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 30);
            this.label9.TabIndex = 10;
            this.label9.Text = "資料表選擇：";
            // 
            // Update
            // 
            this.Update.Controls.Add(this.updateButton);
            this.Update.Controls.Add(this.updateDataGridView);
            this.Update.Controls.Add(this.updateConstraint);
            this.Update.Controls.Add(this.label4);
            this.Update.Controls.Add(this.updateContent);
            this.Update.Controls.Add(this.label3);
            this.Update.Controls.Add(this.updateAttribute);
            this.Update.Controls.Add(this.label2);
            this.Update.Controls.Add(this.updateTable);
            this.Update.Controls.Add(this.label1);
            this.Update.Location = new System.Drawing.Point(10, 48);
            this.Update.Name = "Update";
            this.Update.Padding = new System.Windows.Forms.Padding(3);
            this.Update.Size = new System.Drawing.Size(1175, 888);
            this.Update.TabIndex = 1;
            this.Update.Text = "更新資料";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(879, 353);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(219, 49);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "更新";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateDataGridView
            // 
            this.updateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateDataGridView.Location = new System.Drawing.Point(23, 438);
            this.updateDataGridView.Name = "updateDataGridView";
            this.updateDataGridView.RowTemplate.Height = 45;
            this.updateDataGridView.Size = new System.Drawing.Size(1129, 444);
            this.updateDataGridView.TabIndex = 8;
            // 
            // updateConstraint
            // 
            this.updateConstraint.Location = new System.Drawing.Point(218, 249);
            this.updateConstraint.Name = "updateConstraint";
            this.updateConstraint.Size = new System.Drawing.Size(889, 43);
            this.updateConstraint.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "更新條件：";
            // 
            // updateContent
            // 
            this.updateContent.Location = new System.Drawing.Point(750, 134);
            this.updateContent.Name = "updateContent";
            this.updateContent.Size = new System.Drawing.Size(357, 43);
            this.updateContent.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "更新內容：";
            // 
            // updateAttribute
            // 
            this.updateAttribute.FormattingEnabled = true;
            this.updateAttribute.Location = new System.Drawing.Point(218, 139);
            this.updateAttribute.Name = "updateAttribute";
            this.updateAttribute.Size = new System.Drawing.Size(343, 38);
            this.updateAttribute.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "更新欄位：";
            // 
            // updateTable
            // 
            this.updateTable.FormattingEnabled = true;
            this.updateTable.Items.AddRange(new object[] {
            "College",
            "Department",
            "Teacher",
            "Student",
            "Course",
            "StudentCourse"});
            this.updateTable.Location = new System.Drawing.Point(218, 32);
            this.updateTable.Name = "updateTable";
            this.updateTable.Size = new System.Drawing.Size(889, 38);
            this.updateTable.TabIndex = 1;
            this.updateTable.SelectedIndexChanged += new System.EventHandler(this.updateTable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "資料表選擇：";
            // 
            // Insert
            // 
            this.Insert.Controls.Add(this.addButton);
            this.Insert.Controls.Add(this.addDataGridView);
            this.Insert.Controls.Add(this.addContent);
            this.Insert.Controls.Add(this.label7);
            this.Insert.Controls.Add(this.addAttribute);
            this.Insert.Controls.Add(this.addTable);
            this.Insert.Controls.Add(this.label11);
            this.Insert.Location = new System.Drawing.Point(10, 48);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(1175, 888);
            this.Insert.TabIndex = 2;
            this.Insert.Text = "加入資料";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(877, 344);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(219, 49);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "加入";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addDataGridView
            // 
            this.addDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addDataGridView.Location = new System.Drawing.Point(21, 429);
            this.addDataGridView.Name = "addDataGridView";
            this.addDataGridView.RowTemplate.Height = 45;
            this.addDataGridView.Size = new System.Drawing.Size(1129, 444);
            this.addDataGridView.TabIndex = 26;
            // 
            // addContent
            // 
            this.addContent.Location = new System.Drawing.Point(214, 230);
            this.addContent.Name = "addContent";
            this.addContent.Size = new System.Drawing.Size(889, 43);
            this.addContent.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 30);
            this.label7.TabIndex = 24;
            this.label7.Text = "欄位內容：";
            // 
            // addAttribute
            // 
            this.addAttribute.AutoSize = true;
            this.addAttribute.Location = new System.Drawing.Point(45, 133);
            this.addAttribute.Name = "addAttribute";
            this.addAttribute.Size = new System.Drawing.Size(0, 30);
            this.addAttribute.TabIndex = 22;
            this.addAttribute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addTable
            // 
            this.addTable.FormattingEnabled = true;
            this.addTable.Items.AddRange(new object[] {
            "College",
            "Department",
            "Teacher",
            "Student",
            "Course",
            "StudentCourse"});
            this.addTable.Location = new System.Drawing.Point(216, 23);
            this.addTable.Name = "addTable";
            this.addTable.Size = new System.Drawing.Size(889, 38);
            this.addTable.TabIndex = 21;
            this.addTable.SelectedIndexChanged += new System.EventHandler(this.addTable_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "資料表選擇：";
            // 
            // Delete
            // 
            this.Delete.Controls.Add(this.deleteButton);
            this.Delete.Controls.Add(this.deleteDataGridView);
            this.Delete.Controls.Add(this.deleteConstraint);
            this.Delete.Controls.Add(this.label10);
            this.Delete.Controls.Add(this.deleteTable);
            this.Delete.Controls.Add(this.label13);
            this.Delete.Location = new System.Drawing.Point(10, 48);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(1175, 888);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "刪除資料";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(881, 340);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(219, 49);
            this.deleteButton.TabIndex = 34;
            this.deleteButton.Text = "刪除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteDataGridView
            // 
            this.deleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteDataGridView.Location = new System.Drawing.Point(25, 425);
            this.deleteDataGridView.Name = "deleteDataGridView";
            this.deleteDataGridView.RowTemplate.Height = 45;
            this.deleteDataGridView.Size = new System.Drawing.Size(1129, 444);
            this.deleteDataGridView.TabIndex = 33;
            // 
            // deleteConstraint
            // 
            this.deleteConstraint.Location = new System.Drawing.Point(220, 135);
            this.deleteConstraint.Name = "deleteConstraint";
            this.deleteConstraint.Size = new System.Drawing.Size(889, 43);
            this.deleteConstraint.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 30);
            this.label10.TabIndex = 31;
            this.label10.Text = "刪除條件：";
            // 
            // deleteTable
            // 
            this.deleteTable.FormattingEnabled = true;
            this.deleteTable.Items.AddRange(new object[] {
            "College",
            "Department",
            "Teacher",
            "Student",
            "Course",
            "StudentCourse"});
            this.deleteTable.Location = new System.Drawing.Point(220, 19);
            this.deleteTable.Name = "deleteTable";
            this.deleteTable.Size = new System.Drawing.Size(889, 38);
            this.deleteTable.TabIndex = 29;
            this.deleteTable.SelectedIndexChanged += new System.EventHandler(this.deleteTable_SelectedIndexChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 30);
            this.label13.TabIndex = 28;
            this.label13.Text = "資料表選擇：";
            // 
            // InExist
            // 
            this.InExist.Controls.Add(this.inExistFunctionSelect);
            this.InExist.Controls.Add(this.label17);
            this.InExist.Controls.Add(this.inExistRange);
            this.InExist.Controls.Add(this.label16);
            this.InExist.Controls.Add(this.inExistButton);
            this.InExist.Controls.Add(this.inExistDataGridView);
            this.InExist.Controls.Add(this.inExistConstraint);
            this.InExist.Controls.Add(this.label12);
            this.InExist.Controls.Add(this.inExistAttribute);
            this.InExist.Controls.Add(this.label14);
            this.InExist.Controls.Add(this.inExistTable);
            this.InExist.Controls.Add(this.label15);
            this.InExist.Location = new System.Drawing.Point(10, 48);
            this.InExist.Name = "InExist";
            this.InExist.Size = new System.Drawing.Size(1175, 888);
            this.InExist.TabIndex = 5;
            this.InExist.Text = "巢狀搜尋";
            this.InExist.UseVisualStyleBackColor = true;
            // 
            // inExistFunctionSelect
            // 
            this.inExistFunctionSelect.FormattingEnabled = true;
            this.inExistFunctionSelect.Items.AddRange(new object[] {
            "IN",
            "NOT IN",
            "EXISTS",
            "NOT EXISTS"});
            this.inExistFunctionSelect.Location = new System.Drawing.Point(221, 340);
            this.inExistFunctionSelect.Name = "inExistFunctionSelect";
            this.inExistFunctionSelect.Size = new System.Drawing.Size(213, 38);
            this.inExistFunctionSelect.TabIndex = 35;
            this.inExistFunctionSelect.SelectedIndexChanged += new System.EventHandler(this.inExistFunctionSelect_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(51, 340);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 30);
            this.label17.TabIndex = 34;
            this.label17.Text = "使用函數：";
            // 
            // inExistRange
            // 
            this.inExistRange.FormattingEnabled = true;
            this.inExistRange.Location = new System.Drawing.Point(220, 167);
            this.inExistRange.Name = "inExistRange";
            this.inExistRange.Size = new System.Drawing.Size(889, 38);
            this.inExistRange.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 30);
            this.label16.TabIndex = 28;
            this.label16.Text = "條件欄位：";
            // 
            // inExistButton
            // 
            this.inExistButton.Location = new System.Drawing.Point(890, 334);
            this.inExistButton.Name = "inExistButton";
            this.inExistButton.Size = new System.Drawing.Size(219, 49);
            this.inExistButton.TabIndex = 27;
            this.inExistButton.Text = "巢狀搜尋";
            this.inExistButton.UseVisualStyleBackColor = true;
            this.inExistButton.Click += new System.EventHandler(this.inExistButton_Click);
            // 
            // inExistDataGridView
            // 
            this.inExistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inExistDataGridView.Location = new System.Drawing.Point(25, 425);
            this.inExistDataGridView.Name = "inExistDataGridView";
            this.inExistDataGridView.RowTemplate.Height = 45;
            this.inExistDataGridView.Size = new System.Drawing.Size(1129, 444);
            this.inExistDataGridView.TabIndex = 26;
            // 
            // inExistConstraint
            // 
            this.inExistConstraint.Location = new System.Drawing.Point(220, 248);
            this.inExistConstraint.Name = "inExistConstraint";
            this.inExistConstraint.Size = new System.Drawing.Size(889, 43);
            this.inExistConstraint.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 30);
            this.label12.TabIndex = 24;
            this.label12.Text = "條件限制：";
            // 
            // inExistAttribute
            // 
            this.inExistAttribute.FormattingEnabled = true;
            this.inExistAttribute.Location = new System.Drawing.Point(220, 91);
            this.inExistAttribute.Name = "inExistAttribute";
            this.inExistAttribute.Size = new System.Drawing.Size(889, 38);
            this.inExistAttribute.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 30);
            this.label14.TabIndex = 22;
            this.label14.Text = "搜尋欄位：";
            // 
            // inExistTable
            // 
            this.inExistTable.FormattingEnabled = true;
            this.inExistTable.Items.AddRange(new object[] {
            "College",
            "Department",
            "Teacher",
            "Student",
            "Course",
            "StudentCourse"});
            this.inExistTable.Location = new System.Drawing.Point(220, 19);
            this.inExistTable.Name = "inExistTable";
            this.inExistTable.Size = new System.Drawing.Size(889, 38);
            this.inExistTable.TabIndex = 21;
            this.inExistTable.SelectedIndexChanged += new System.EventHandler(this.inExistTable_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(193, 30);
            this.label15.TabIndex = 20;
            this.label15.Text = "資料表選擇：";
            // 
            // Aggregate
            // 
            this.Aggregate.Controls.Add(this.havingConstraint);
            this.Aggregate.Controls.Add(this.label22);
            this.Aggregate.Controls.Add(this.aggregateFunctionSelector);
            this.Aggregate.Controls.Add(this.label21);
            this.Aggregate.Controls.Add(this.aggregateButton);
            this.Aggregate.Controls.Add(this.aggregateDataGridView);
            this.Aggregate.Controls.Add(this.aggregateConstraint);
            this.Aggregate.Controls.Add(this.label18);
            this.Aggregate.Controls.Add(this.aggregateAttribute);
            this.Aggregate.Controls.Add(this.label19);
            this.Aggregate.Controls.Add(this.aggregateTable);
            this.Aggregate.Controls.Add(this.label20);
            this.Aggregate.Location = new System.Drawing.Point(10, 48);
            this.Aggregate.Name = "Aggregate";
            this.Aggregate.Size = new System.Drawing.Size(1175, 888);
            this.Aggregate.TabIndex = 6;
            this.Aggregate.Text = "整合搜尋";
            this.Aggregate.UseVisualStyleBackColor = true;
            // 
            // havingConstraint
            // 
            this.havingConstraint.Location = new System.Drawing.Point(770, 236);
            this.havingConstraint.Name = "havingConstraint";
            this.havingConstraint.Size = new System.Drawing.Size(339, 43);
            this.havingConstraint.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(558, 239);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(190, 30);
            this.label22.TabIndex = 38;
            this.label22.Text = "HAVING條件:";
            // 
            // aggregateFunctionSelector
            // 
            this.aggregateFunctionSelector.FormattingEnabled = true;
            this.aggregateFunctionSelector.Items.AddRange(new object[] {
            "COUNT",
            "SUM",
            "MAX",
            "MIN",
            "AVG"});
            this.aggregateFunctionSelector.Location = new System.Drawing.Point(221, 349);
            this.aggregateFunctionSelector.Name = "aggregateFunctionSelector";
            this.aggregateFunctionSelector.Size = new System.Drawing.Size(184, 38);
            this.aggregateFunctionSelector.TabIndex = 37;
            this.aggregateFunctionSelector.SelectedIndexChanged += new System.EventHandler(this.aggregateFunctionSelector_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(51, 349);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(163, 30);
            this.label21.TabIndex = 36;
            this.label21.Text = "使用函數：";
            // 
            // aggregateButton
            // 
            this.aggregateButton.Location = new System.Drawing.Point(881, 340);
            this.aggregateButton.Name = "aggregateButton";
            this.aggregateButton.Size = new System.Drawing.Size(219, 49);
            this.aggregateButton.TabIndex = 27;
            this.aggregateButton.Text = "整合搜尋";
            this.aggregateButton.UseVisualStyleBackColor = true;
            this.aggregateButton.Click += new System.EventHandler(this.aggregateButton_Click);
            // 
            // aggregateDataGridView
            // 
            this.aggregateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aggregateDataGridView.Location = new System.Drawing.Point(25, 425);
            this.aggregateDataGridView.Name = "aggregateDataGridView";
            this.aggregateDataGridView.RowTemplate.Height = 45;
            this.aggregateDataGridView.Size = new System.Drawing.Size(1129, 444);
            this.aggregateDataGridView.TabIndex = 26;
            // 
            // aggregateConstraint
            // 
            this.aggregateConstraint.Location = new System.Drawing.Point(220, 236);
            this.aggregateConstraint.Name = "aggregateConstraint";
            this.aggregateConstraint.Size = new System.Drawing.Size(305, 43);
            this.aggregateConstraint.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(51, 239);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(163, 30);
            this.label18.TabIndex = 24;
            this.label18.Text = "搜尋條件：";
            // 
            // aggregateAttribute
            // 
            this.aggregateAttribute.FormattingEnabled = true;
            this.aggregateAttribute.Location = new System.Drawing.Point(220, 126);
            this.aggregateAttribute.Name = "aggregateAttribute";
            this.aggregateAttribute.Size = new System.Drawing.Size(889, 38);
            this.aggregateAttribute.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(51, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(163, 30);
            this.label19.TabIndex = 22;
            this.label19.Text = "搜尋欄位：";
            // 
            // aggregateTable
            // 
            this.aggregateTable.FormattingEnabled = true;
            this.aggregateTable.Items.AddRange(new object[] {
            "Department",
            "Teacher",
            "Student"});
            this.aggregateTable.Location = new System.Drawing.Point(220, 19);
            this.aggregateTable.Name = "aggregateTable";
            this.aggregateTable.Size = new System.Drawing.Size(889, 38);
            this.aggregateTable.TabIndex = 21;
            this.aggregateTable.SelectedIndexChanged += new System.EventHandler(this.aggregateTable_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(193, 30);
            this.label20.TabIndex = 20;
            this.label20.Text = "資料表選擇：";
            // 
            // SQL
            // 
            this.SQL.Controls.Add(this.mySQLDataGridView);
            this.SQL.Controls.Add(this.mySQLButton);
            this.SQL.Controls.Add(this.mySQLText);
            this.SQL.Controls.Add(this.label5);
            this.SQL.Location = new System.Drawing.Point(10, 48);
            this.SQL.Name = "SQL";
            this.SQL.Size = new System.Drawing.Size(1175, 888);
            this.SQL.TabIndex = 4;
            this.SQL.Text = "MySQL自訂輸入";
            this.SQL.UseVisualStyleBackColor = true;
            // 
            // mySQLDataGridView
            // 
            this.mySQLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mySQLDataGridView.Location = new System.Drawing.Point(39, 416);
            this.mySQLDataGridView.Name = "mySQLDataGridView";
            this.mySQLDataGridView.RowTemplate.Height = 45;
            this.mySQLDataGridView.Size = new System.Drawing.Size(1091, 427);
            this.mySQLDataGridView.TabIndex = 4;
            // 
            // mySQLButton
            // 
            this.mySQLButton.Location = new System.Drawing.Point(911, 32);
            this.mySQLButton.Name = "mySQLButton";
            this.mySQLButton.Size = new System.Drawing.Size(219, 49);
            this.mySQLButton.TabIndex = 3;
            this.mySQLButton.Text = "執行語法";
            this.mySQLButton.UseVisualStyleBackColor = true;
            this.mySQLButton.Click += new System.EventHandler(this.mySQLButton_Click);
            // 
            // mySQLText
            // 
            this.mySQLText.Location = new System.Drawing.Point(39, 119);
            this.mySQLText.Multiline = true;
            this.mySQLText.Name = "mySQLText";
            this.mySQLText.Size = new System.Drawing.Size(1091, 250);
            this.mySQLText.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "輸入MySQL語法：";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.courseDatabaseDataSet;
            this.bindingSource1.Position = 0;
            // 
            // courseDatabaseDataSet
            // 
            this.courseDatabaseDataSet.DataSetName = "CourseDatabaseDataSet";
            this.courseDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 948);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CourseInspector";
            this.tabControl1.ResumeLayout(false);
            this.Select.ResumeLayout(false);
            this.Select.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectDataGridView)).EndInit();
            this.Update.ResumeLayout(false);
            this.Update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateDataGridView)).EndInit();
            this.Insert.ResumeLayout(false);
            this.Insert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDataGridView)).EndInit();
            this.Delete.ResumeLayout(false);
            this.Delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteDataGridView)).EndInit();
            this.InExist.ResumeLayout(false);
            this.InExist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inExistDataGridView)).EndInit();
            this.Aggregate.ResumeLayout(false);
            this.Aggregate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aggregateDataGridView)).EndInit();
            this.SQL.ResumeLayout(false);
            this.SQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mySQLDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Select;
        private System.Windows.Forms.TabPage Update;
        private System.Windows.Forms.TabPage Insert;
        private System.Windows.Forms.TabPage Delete;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView updateDataGridView;
        private System.Windows.Forms.TextBox updateConstraint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox updateContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox updateAttribute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox updateTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage SQL;
        private System.Windows.Forms.DataGridView mySQLDataGridView;
        private System.Windows.Forms.Button mySQLButton;
        private System.Windows.Forms.TextBox mySQLText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.DataGridView selectDataGridView;
        private System.Windows.Forms.TextBox selectConstraint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectAttribute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox selectTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView addDataGridView;
        private System.Windows.Forms.TextBox addContent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label addAttribute;
        private System.Windows.Forms.ComboBox addTable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView deleteDataGridView;
        private System.Windows.Forms.TextBox deleteConstraint;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox deleteTable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage InExist;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button inExistButton;
        private System.Windows.Forms.DataGridView inExistDataGridView;
        private System.Windows.Forms.TextBox inExistConstraint;
        private System.Windows.Forms.ComboBox inExistAttribute;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox inExistTable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox inExistRange;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox inExistFunctionSelect;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage Aggregate;
        private System.Windows.Forms.ComboBox aggregateFunctionSelector;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button aggregateButton;
        private System.Windows.Forms.DataGridView aggregateDataGridView;
        private System.Windows.Forms.TextBox aggregateConstraint;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox aggregateAttribute;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox aggregateTable;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox havingConstraint;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CourseDatabaseDataSet courseDatabaseDataSet;
    }
}

