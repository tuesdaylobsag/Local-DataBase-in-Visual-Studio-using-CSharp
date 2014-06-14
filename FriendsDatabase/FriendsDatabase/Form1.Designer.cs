namespace FriendsDatabase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label companyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.friends_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.friends_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.friends_DatabaseDataSet1 = new FriendsDatabase.Friends_DatabaseDataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.friends_TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.friends_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numberOfRowsLabel = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.friends_TableTableAdapter = new FriendsDatabase.Friends_DatabaseDataSet1TableAdapters.Friends_TableTableAdapter();
            this.tableAdapterManager = new FriendsDatabase.Friends_DatabaseDataSet1TableAdapters.TableAdapterManager();
            this.firstNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.firstNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchNameQueryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchNameQueryToolStrip = new System.Windows.Forms.ToolStrip();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.friends_TableBindingNavigator)).BeginInit();
            this.friends_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friends_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friends_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friends_TableDataGridView)).BeginInit();
            this.searchNameQueryToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(26, 70);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(26, 96);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(26, 122);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Phone:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(26, 148);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Address:";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(26, 174);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(54, 13);
            companyLabel.TabIndex = 11;
            companyLabel.Text = "Company:";
            // 
            // friends_TableBindingNavigator
            // 
            this.friends_TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.friends_TableBindingNavigator.BindingSource = this.friends_TableBindingSource;
            this.friends_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.friends_TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.friends_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.friends_TableBindingNavigatorSaveItem});
            this.friends_TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.friends_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.friends_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.friends_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.friends_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.friends_TableBindingNavigator.Name = "friends_TableBindingNavigator";
            this.friends_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.friends_TableBindingNavigator.Size = new System.Drawing.Size(902, 25);
            this.friends_TableBindingNavigator.TabIndex = 0;
            this.friends_TableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // friends_TableBindingSource
            // 
            this.friends_TableBindingSource.DataMember = "Friends_Table";
            this.friends_TableBindingSource.DataSource = this.friends_DatabaseDataSet1;
            // 
            // friends_DatabaseDataSet1
            // 
            this.friends_DatabaseDataSet1.DataSetName = "Friends_DatabaseDataSet1";
            this.friends_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // friends_TableBindingNavigatorSaveItem
            // 
            this.friends_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.friends_TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("friends_TableBindingNavigatorSaveItem.Image")));
            this.friends_TableBindingNavigatorSaveItem.Name = "friends_TableBindingNavigatorSaveItem";
            this.friends_TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.friends_TableBindingNavigatorSaveItem.Text = "Save Data";
            this.friends_TableBindingNavigatorSaveItem.Click += new System.EventHandler(this.friends_TableBindingNavigatorSaveItem_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friends_TableBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(112, 67);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friends_TableBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(112, 93);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friends_TableBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(112, 119);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(164, 20);
            this.phoneTextBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friends_TableBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(112, 145);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(164, 20);
            this.addressTextBox.TabIndex = 10;
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friends_TableBindingSource, "Company", true));
            this.companyTextBox.Location = new System.Drawing.Point(112, 171);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(164, 20);
            this.companyTextBox.TabIndex = 12;
            // 
            // friends_TableDataGridView
            // 
            this.friends_TableDataGridView.AutoGenerateColumns = false;
            this.friends_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.friends_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.friends_TableDataGridView.DataSource = this.friends_TableBindingSource;
            this.friends_TableDataGridView.Location = new System.Drawing.Point(326, 67);
            this.friends_TableDataGridView.Name = "friends_TableDataGridView";
            this.friends_TableDataGridView.Size = new System.Drawing.Size(544, 242);
            this.friends_TableDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn6.HeaderText = "Company";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(51, 229);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add New";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(126, 229);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 15;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(201, 229);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 16;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numberOfRowsLabel
            // 
            this.numberOfRowsLabel.AutoSize = true;
            this.numberOfRowsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfRowsLabel.Location = new System.Drawing.Point(323, 324);
            this.numberOfRowsLabel.Name = "numberOfRowsLabel";
            this.numberOfRowsLabel.Size = new System.Drawing.Size(81, 13);
            this.numberOfRowsLabel.TabIndex = 17;
            this.numberOfRowsLabel.Text = "Number of rows";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(126, 258);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 18;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(201, 258);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 19;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // friends_TableTableAdapter
            // 
            this.friends_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Friends_TableTableAdapter = this.friends_TableTableAdapter;
            this.tableAdapterManager.UpdateOrder = FriendsDatabase.Friends_DatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // firstNameToolStripLabel
            // 
            this.firstNameToolStripLabel.Name = "firstNameToolStripLabel";
            this.firstNameToolStripLabel.Size = new System.Drawing.Size(64, 22);
            this.firstNameToolStripLabel.Text = "FirstName:";
            // 
            // firstNameToolStripTextBox
            // 
            this.firstNameToolStripTextBox.Name = "firstNameToolStripTextBox";
            this.firstNameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchNameQueryToolStripButton
            // 
            this.searchNameQueryToolStripButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchNameQueryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchNameQueryToolStripButton.Name = "searchNameQueryToolStripButton";
            this.searchNameQueryToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.searchNameQueryToolStripButton.Text = "Search";
            this.searchNameQueryToolStripButton.Click += new System.EventHandler(this.searchNameQueryToolStripButton_Click);
            // 
            // searchNameQueryToolStrip
            // 
            this.searchNameQueryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstNameToolStripLabel,
            this.firstNameToolStripTextBox,
            this.searchNameQueryToolStripButton});
            this.searchNameQueryToolStrip.Location = new System.Drawing.Point(0, 25);
            this.searchNameQueryToolStrip.Name = "searchNameQueryToolStrip";
            this.searchNameQueryToolStrip.Size = new System.Drawing.Size(902, 25);
            this.searchNameQueryToolStrip.TabIndex = 20;
            this.searchNameQueryToolStrip.Text = "searchNameQueryToolStrip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 446);
            this.Controls.Add(this.searchNameQueryToolStrip);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.numberOfRowsLabel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.friends_TableBindingNavigator);
            this.Controls.Add(this.friends_TableDataGridView);
            this.Name = "Form1";
            this.Text = "Contact Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.friends_TableBindingNavigator)).EndInit();
            this.friends_TableBindingNavigator.ResumeLayout(false);
            this.friends_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friends_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friends_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friends_TableDataGridView)).EndInit();
            this.searchNameQueryToolStrip.ResumeLayout(false);
            this.searchNameQueryToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Friends_DatabaseDataSet1 friends_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource friends_TableBindingSource;
        private Friends_DatabaseDataSet1TableAdapters.Friends_TableTableAdapter friends_TableTableAdapter;
        private Friends_DatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator friends_TableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton friends_TableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.DataGridView friends_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label numberOfRowsLabel;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ToolStripLabel firstNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox firstNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchNameQueryToolStripButton;
        private System.Windows.Forms.ToolStrip searchNameQueryToolStrip;
    }
}

