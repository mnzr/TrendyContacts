namespace ContactDirectory
{
    partial class TrendyContactDirectory
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
            System.Windows.Forms.Label contactIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label clientLabel;
            System.Windows.Forms.Label lastCallLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrendyContactDirectory));
            this.contactDataSet = new ContactDirectory.ContactDBDataSet();
            this.contactsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactsTableAdapter1 = new ContactDirectory.ContactDBDataSetTableAdapters.ContactsTableAdapter();
            this.tableAdapterManager1 = new ContactDirectory.ContactDBDataSetTableAdapters.TableAdapterManager();
            this.contactsBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.contactsBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contactIdTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.companyTextBox1 = new System.Windows.Forms.TextBox();
            this.telephoneTextBox1 = new System.Windows.Forms.TextBox();
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.clientCheckBox1 = new System.Windows.Forms.CheckBox();
            this.lastCallDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            contactIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            clientLabel = new System.Windows.Forms.Label();
            lastCallLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource1BindingNavigator)).BeginInit();
            this.contactsBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contactIdLabel
            // 
            contactIdLabel.AutoSize = true;
            contactIdLabel.Location = new System.Drawing.Point(23, 44);
            contactIdLabel.Name = "contactIdLabel";
            contactIdLabel.Size = new System.Drawing.Size(59, 13);
            contactIdLabel.TabIndex = 1;
            contactIdLabel.Text = "Contact Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(23, 70);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(23, 96);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(54, 13);
            companyLabel.TabIndex = 5;
            companyLabel.Text = "Company:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(23, 122);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 7;
            telephoneLabel.Text = "Telephone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(23, 148);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Location = new System.Drawing.Point(23, 176);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new System.Drawing.Size(36, 13);
            clientLabel.TabIndex = 11;
            clientLabel.Text = "Client:";
            // 
            // lastCallLabel
            // 
            lastCallLabel.AutoSize = true;
            lastCallLabel.Location = new System.Drawing.Point(23, 205);
            lastCallLabel.Name = "lastCallLabel";
            lastCallLabel.Size = new System.Drawing.Size(50, 13);
            lastCallLabel.TabIndex = 13;
            lastCallLabel.Text = "Last Call:";
            // 
            // contactDataSet
            // 
            this.contactDataSet.DataSetName = "ContactDBDataSet";
            this.contactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactsBindingSource1
            // 
            this.contactsBindingSource1.DataMember = "Contacts";
            this.contactsBindingSource1.DataSource = this.contactDataSet;
            // 
            // contactsTableAdapter1
            // 
            this.contactsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ContactsTableAdapter = this.contactsTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = ContactDirectory.ContactDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contactsBindingSource1BindingNavigator
            // 
            this.contactsBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.contactsBindingSource1BindingNavigator.BindingSource = this.contactsBindingSource1;
            this.contactsBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.contactsBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.contactsBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.contactsBindingSource1BindingNavigatorSaveItem});
            this.contactsBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contactsBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.contactsBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.contactsBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.contactsBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.contactsBindingSource1BindingNavigator.Name = "contactsBindingSource1BindingNavigator";
            this.contactsBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.contactsBindingSource1BindingNavigator.Size = new System.Drawing.Size(469, 25);
            this.contactsBindingSource1BindingNavigator.TabIndex = 0;
            this.contactsBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // contactsBindingSource1BindingNavigatorSaveItem
            // 
            this.contactsBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactsBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contactsBindingSource1BindingNavigatorSaveItem.Image")));
            this.contactsBindingSource1BindingNavigatorSaveItem.Name = "contactsBindingSource1BindingNavigatorSaveItem";
            this.contactsBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contactsBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.contactsBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.contactsBindingSourceBindingNavigatorSaveItem_Click);
            // 
            // contactIdTextBox1
            // 
            this.contactIdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource1, "ContactId", true));
            this.contactIdTextBox1.Location = new System.Drawing.Point(90, 41);
            this.contactIdTextBox1.Name = "contactIdTextBox1";
            this.contactIdTextBox1.Size = new System.Drawing.Size(200, 20);
            this.contactIdTextBox1.TabIndex = 2;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource1, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(90, 67);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox1.TabIndex = 4;
            // 
            // companyTextBox1
            // 
            this.companyTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource1, "Company", true));
            this.companyTextBox1.Location = new System.Drawing.Point(90, 93);
            this.companyTextBox1.Name = "companyTextBox1";
            this.companyTextBox1.Size = new System.Drawing.Size(200, 20);
            this.companyTextBox1.TabIndex = 6;
            // 
            // telephoneTextBox1
            // 
            this.telephoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource1, "Telephone", true));
            this.telephoneTextBox1.Location = new System.Drawing.Point(90, 119);
            this.telephoneTextBox1.Name = "telephoneTextBox1";
            this.telephoneTextBox1.Size = new System.Drawing.Size(200, 20);
            this.telephoneTextBox1.TabIndex = 8;
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource1, "Email", true));
            this.emailTextBox1.Location = new System.Drawing.Point(90, 145);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox1.TabIndex = 10;
            // 
            // clientCheckBox1
            // 
            this.clientCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contactsBindingSource1, "Client", true));
            this.clientCheckBox1.Location = new System.Drawing.Point(90, 171);
            this.clientCheckBox1.Name = "clientCheckBox1";
            this.clientCheckBox1.Size = new System.Drawing.Size(200, 24);
            this.clientCheckBox1.TabIndex = 12;
            this.clientCheckBox1.UseVisualStyleBackColor = true;
            // 
            // lastCallDateTimePicker1
            // 
            this.lastCallDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contactsBindingSource1, "LastCall", true));
            this.lastCallDateTimePicker1.Location = new System.Drawing.Point(90, 201);
            this.lastCallDateTimePicker1.Name = "lastCallDateTimePicker1";
            this.lastCallDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.lastCallDateTimePicker1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContactDirectory.Properties.Resources.TBLogo;
            this.pictureBox1.Location = new System.Drawing.Point(314, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.logoBox_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(314, 202);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(131, 23);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.OnClose);
            // 
            // TrendyContactDirectory
            // 
            this.ClientSize = new System.Drawing.Size(469, 298);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(contactIdLabel);
            this.Controls.Add(this.contactIdTextBox1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox1);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox1);
            this.Controls.Add(clientLabel);
            this.Controls.Add(this.clientCheckBox1);
            this.Controls.Add(lastCallLabel);
            this.Controls.Add(this.lastCallDateTimePicker1);
            this.Controls.Add(this.contactsBindingSource1BindingNavigator);
            this.Name = "TrendyContactDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trendy Contact Directory";
            this.Load += new System.EventHandler(this.TrendyContactDirectory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource1BindingNavigator)).EndInit();
            this.contactsBindingSource1BindingNavigator.ResumeLayout(false);
            this.contactsBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private ContactDBDataSet contactDBDataSet;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private ContactDBDataSetTableAdapters.ContactsTableAdapter contactsTableAdapter;
        private ContactDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contactsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contactsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contactIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox clientCheckBox;
        private System.Windows.Forms.DateTimePicker lastCallDateTimePicker;
        private ContactDBDataSet contactDataSet;
        private System.Windows.Forms.BindingSource contactsBindingSource1;
        private ContactDBDataSetTableAdapters.ContactsTableAdapter contactsTableAdapter1;
        private ContactDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator contactsBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton contactsBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contactIdTextBox1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox companyTextBox1;
        private System.Windows.Forms.TextBox telephoneTextBox1;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.CheckBox clientCheckBox1;
        private System.Windows.Forms.DateTimePicker lastCallDateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeButton;
    }
}

