namespace AdminInterface
{
    partial class frmManageAssociates
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.editAssociate = new System.Windows.Forms.TabPage();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.dgvAssociates = new System.Windows.Forms.DataGridView();
            this.SalesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbCommission = new System.Windows.Forms.TextBox();
            this.lblComm = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.tbState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.addAssociate = new System.Windows.Forms.TabPage();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCreateSalesAssociate = new System.Windows.Forms.Button();
            this.tbNewCommission = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNewUserID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNewZip = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNewState = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbNewCity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbNewStreet = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbNewLast = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbNewFirst = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbNewID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.deleteAssociate = new System.Windows.Forms.TabPage();
            this.lblDelete = new System.Windows.Forms.Label();
            this.dgvDelete = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.editAssociate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociates)).BeginInit();
            this.addAssociate.SuspendLayout();
            this.deleteAssociate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.editAssociate);
            this.tabControl.Controls.Add(this.addAssociate);
            this.tabControl.Controls.Add(this.deleteAssociate);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1532, 878);
            this.tabControl.TabIndex = 0;
            // 
            // editAssociate
            // 
            this.editAssociate.Controls.Add(this.lblUpdate);
            this.editAssociate.Controls.Add(this.dgvAssociates);
            this.editAssociate.Controls.Add(this.btnUpdate);
            this.editAssociate.Controls.Add(this.tbCommission);
            this.editAssociate.Controls.Add(this.lblComm);
            this.editAssociate.Controls.Add(this.tbUserID);
            this.editAssociate.Controls.Add(this.lblUserID);
            this.editAssociate.Controls.Add(this.tbZip);
            this.editAssociate.Controls.Add(this.lblZip);
            this.editAssociate.Controls.Add(this.tbState);
            this.editAssociate.Controls.Add(this.lblState);
            this.editAssociate.Controls.Add(this.tbCity);
            this.editAssociate.Controls.Add(this.lblCity);
            this.editAssociate.Controls.Add(this.tbStreet);
            this.editAssociate.Controls.Add(this.lblStreet);
            this.editAssociate.Controls.Add(this.tbLast);
            this.editAssociate.Controls.Add(this.lblLast);
            this.editAssociate.Controls.Add(this.tbFirst);
            this.editAssociate.Controls.Add(this.lblFirst);
            this.editAssociate.Controls.Add(this.tbID);
            this.editAssociate.Controls.Add(this.lblID);
            this.editAssociate.Location = new System.Drawing.Point(4, 29);
            this.editAssociate.Name = "editAssociate";
            this.editAssociate.Padding = new System.Windows.Forms.Padding(3);
            this.editAssociate.Size = new System.Drawing.Size(1524, 845);
            this.editAssociate.TabIndex = 0;
            this.editAssociate.Text = "Edit Sales Associate";
            this.editAssociate.UseVisualStyleBackColor = true;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(361, 92);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(707, 52);
            this.lblUpdate.TabIndex = 20;
            this.lblUpdate.Text = "Select A Sales Associate to Update";
            // 
            // dgvAssociates
            // 
            this.dgvAssociates.AllowUserToAddRows = false;
            this.dgvAssociates.AllowUserToDeleteRows = false;
            this.dgvAssociates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssociates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAssociates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesID,
            this.firstName,
            this.clientContact,
            this.clientEmail,
            this.TotalCost,
            this.status,
            this.Zip,
            this.totalCommission});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssociates.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssociates.Location = new System.Drawing.Point(0, 221);
            this.dgvAssociates.MultiSelect = false;
            this.dgvAssociates.Name = "dgvAssociates";
            this.dgvAssociates.ReadOnly = true;
            this.dgvAssociates.RowTemplate.Height = 28;
            this.dgvAssociates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssociates.Size = new System.Drawing.Size(1518, 223);
            this.dgvAssociates.TabIndex = 19;
            this.dgvAssociates.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssociates_CellContentDoubleClick);
            // 
            // SalesID
            // 
            this.SalesID.FillWeight = 80F;
            this.SalesID.HeaderText = "Sales Associate ID";
            this.SalesID.Name = "SalesID";
            this.SalesID.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.FillWeight = 120F;
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // clientContact
            // 
            this.clientContact.FillWeight = 120F;
            this.clientContact.HeaderText = "Last Name";
            this.clientContact.Name = "clientContact";
            this.clientContact.ReadOnly = true;
            // 
            // clientEmail
            // 
            this.clientEmail.FillWeight = 150F;
            this.clientEmail.HeaderText = "Street Address";
            this.clientEmail.Name = "clientEmail";
            this.clientEmail.ReadOnly = true;
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "City";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            // 
            // status
            // 
            this.status.FillWeight = 60F;
            this.status.HeaderText = "State";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // Zip
            // 
            this.Zip.HeaderText = "Zip";
            this.Zip.Name = "Zip";
            this.Zip.ReadOnly = true;
            // 
            // totalCommission
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.totalCommission.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalCommission.HeaderText = "Total Commission";
            this.totalCommission.Name = "totalCommission";
            this.totalCommission.ReadOnly = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(603, 662);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(210, 96);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update Information";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbCommission
            // 
            this.tbCommission.Enabled = false;
            this.tbCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCommission.Location = new System.Drawing.Point(623, 591);
            this.tbCommission.Name = "tbCommission";
            this.tbCommission.Size = new System.Drawing.Size(313, 35);
            this.tbCommission.TabIndex = 17;
            this.tbCommission.Visible = false;
            // 
            // lblComm
            // 
            this.lblComm.AutoSize = true;
            this.lblComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComm.Location = new System.Drawing.Point(364, 588);
            this.lblComm.Name = "lblComm";
            this.lblComm.Size = new System.Drawing.Size(242, 32);
            this.lblComm.TabIndex = 16;
            this.lblComm.Text = "Total Commission";
            this.lblComm.Visible = false;
            // 
            // tbUserID
            // 
            this.tbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserID.Location = new System.Drawing.Point(622, 526);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(313, 35);
            this.tbUserID.TabIndex = 15;
            this.tbUserID.Visible = false;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(498, 523);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(108, 32);
            this.lblUserID.TabIndex = 14;
            this.lblUserID.Text = "User ID";
            this.lblUserID.Visible = false;
            // 
            // tbZip
            // 
            this.tbZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZip.Location = new System.Drawing.Point(622, 459);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(313, 35);
            this.tbZip.TabIndex = 13;
            this.tbZip.Visible = false;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(547, 456);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(58, 32);
            this.lblZip.TabIndex = 12;
            this.lblZip.Text = "ZIP";
            this.lblZip.Visible = false;
            // 
            // tbState
            // 
            this.tbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbState.Location = new System.Drawing.Point(622, 389);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(313, 35);
            this.tbState.TabIndex = 11;
            this.tbState.Visible = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(523, 386);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(82, 32);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State";
            this.lblState.Visible = false;
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(622, 322);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(313, 35);
            this.tbCity.TabIndex = 9;
            this.tbCity.Visible = false;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(541, 322);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 32);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City";
            this.lblCity.Visible = false;
            // 
            // tbStreet
            // 
            this.tbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStreet.Location = new System.Drawing.Point(622, 250);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(313, 35);
            this.tbStreet.TabIndex = 7;
            this.tbStreet.Visible = false;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(404, 250);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(202, 32);
            this.lblStreet.TabIndex = 6;
            this.lblStreet.Text = "Street Address";
            this.lblStreet.Visible = false;
            // 
            // tbLast
            // 
            this.tbLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLast.Location = new System.Drawing.Point(622, 183);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(313, 35);
            this.tbLast.TabIndex = 5;
            this.tbLast.Visible = false;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(454, 186);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(151, 32);
            this.lblLast.TabIndex = 4;
            this.lblLast.Text = "Last Name";
            this.lblLast.Visible = false;
            // 
            // tbFirst
            // 
            this.tbFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirst.Location = new System.Drawing.Point(622, 121);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(313, 35);
            this.tbFirst.TabIndex = 3;
            this.tbFirst.Visible = false;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(454, 121);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(152, 32);
            this.lblFirst.TabIndex = 2;
            this.lblFirst.Text = "First Name";
            this.lblFirst.Visible = false;
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(622, 54);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(313, 35);
            this.tbID.TabIndex = 1;
            this.tbID.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(354, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(252, 32);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Sales Associate ID";
            this.lblID.Visible = false;
            // 
            // addAssociate
            // 
            this.addAssociate.Controls.Add(this.tbPass);
            this.addAssociate.Controls.Add(this.label1);
            this.addAssociate.Controls.Add(this.btnGenerate);
            this.addAssociate.Controls.Add(this.btnCreateSalesAssociate);
            this.addAssociate.Controls.Add(this.tbNewCommission);
            this.addAssociate.Controls.Add(this.label10);
            this.addAssociate.Controls.Add(this.tbNewUserID);
            this.addAssociate.Controls.Add(this.label11);
            this.addAssociate.Controls.Add(this.tbNewZip);
            this.addAssociate.Controls.Add(this.label12);
            this.addAssociate.Controls.Add(this.tbNewState);
            this.addAssociate.Controls.Add(this.label13);
            this.addAssociate.Controls.Add(this.tbNewCity);
            this.addAssociate.Controls.Add(this.label14);
            this.addAssociate.Controls.Add(this.tbNewStreet);
            this.addAssociate.Controls.Add(this.label15);
            this.addAssociate.Controls.Add(this.tbNewLast);
            this.addAssociate.Controls.Add(this.label16);
            this.addAssociate.Controls.Add(this.tbNewFirst);
            this.addAssociate.Controls.Add(this.label17);
            this.addAssociate.Controls.Add(this.tbNewID);
            this.addAssociate.Controls.Add(this.label18);
            this.addAssociate.Location = new System.Drawing.Point(4, 29);
            this.addAssociate.Name = "addAssociate";
            this.addAssociate.Padding = new System.Windows.Forms.Padding(3);
            this.addAssociate.Size = new System.Drawing.Size(1524, 845);
            this.addAssociate.TabIndex = 1;
            this.addAssociate.Text = "Add Sales Associate";
            this.addAssociate.UseVisualStyleBackColor = true;
            // 
            // tbPass
            // 
            this.tbPass.Enabled = false;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(681, 605);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(313, 35);
            this.tbPass.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "Password";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(1000, 605);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(127, 42);
            this.btnGenerate.TabIndex = 38;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCreateSalesAssociate
            // 
            this.btnCreateSalesAssociate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSalesAssociate.Location = new System.Drawing.Point(633, 728);
            this.btnCreateSalesAssociate.Name = "btnCreateSalesAssociate";
            this.btnCreateSalesAssociate.Size = new System.Drawing.Size(210, 96);
            this.btnCreateSalesAssociate.TabIndex = 37;
            this.btnCreateSalesAssociate.Text = "Add Sales Associate";
            this.btnCreateSalesAssociate.UseVisualStyleBackColor = true;
            this.btnCreateSalesAssociate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbNewCommission
            // 
            this.tbNewCommission.Enabled = false;
            this.tbNewCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewCommission.Location = new System.Drawing.Point(681, 667);
            this.tbNewCommission.Name = "tbNewCommission";
            this.tbNewCommission.Size = new System.Drawing.Size(313, 35);
            this.tbNewCommission.TabIndex = 36;
            this.tbNewCommission.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(432, 667);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 32);
            this.label10.TabIndex = 35;
            this.label10.Text = "Total Commission";
            // 
            // tbNewUserID
            // 
            this.tbNewUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewUserID.Location = new System.Drawing.Point(680, 542);
            this.tbNewUserID.Name = "tbNewUserID";
            this.tbNewUserID.Size = new System.Drawing.Size(313, 35);
            this.tbNewUserID.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(566, 542);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 32);
            this.label11.TabIndex = 33;
            this.label11.Text = "User ID";
            // 
            // tbNewZip
            // 
            this.tbNewZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewZip.Location = new System.Drawing.Point(680, 475);
            this.tbNewZip.Name = "tbNewZip";
            this.tbNewZip.Size = new System.Drawing.Size(313, 35);
            this.tbNewZip.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(615, 475);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 32);
            this.label12.TabIndex = 31;
            this.label12.Text = "ZIP";
            // 
            // tbNewState
            // 
            this.tbNewState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewState.Location = new System.Drawing.Point(680, 405);
            this.tbNewState.Name = "tbNewState";
            this.tbNewState.Size = new System.Drawing.Size(313, 35);
            this.tbNewState.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(591, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 32);
            this.label13.TabIndex = 29;
            this.label13.Text = "State";
            // 
            // tbNewCity
            // 
            this.tbNewCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewCity.Location = new System.Drawing.Point(680, 338);
            this.tbNewCity.Name = "tbNewCity";
            this.tbNewCity.Size = new System.Drawing.Size(313, 35);
            this.tbNewCity.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(609, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 32);
            this.label14.TabIndex = 27;
            this.label14.Text = "City";
            // 
            // tbNewStreet
            // 
            this.tbNewStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewStreet.Location = new System.Drawing.Point(680, 266);
            this.tbNewStreet.Name = "tbNewStreet";
            this.tbNewStreet.Size = new System.Drawing.Size(313, 35);
            this.tbNewStreet.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(472, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(202, 32);
            this.label15.TabIndex = 25;
            this.label15.Text = "Street Address";
            // 
            // tbNewLast
            // 
            this.tbNewLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewLast.Location = new System.Drawing.Point(680, 199);
            this.tbNewLast.Name = "tbNewLast";
            this.tbNewLast.Size = new System.Drawing.Size(313, 35);
            this.tbNewLast.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(522, 202);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 32);
            this.label16.TabIndex = 23;
            this.label16.Text = "Last Name";
            // 
            // tbNewFirst
            // 
            this.tbNewFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewFirst.Location = new System.Drawing.Point(680, 137);
            this.tbNewFirst.Name = "tbNewFirst";
            this.tbNewFirst.Size = new System.Drawing.Size(313, 35);
            this.tbNewFirst.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(522, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 32);
            this.label17.TabIndex = 21;
            this.label17.Text = "First Name";
            // 
            // tbNewID
            // 
            this.tbNewID.Enabled = false;
            this.tbNewID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewID.Location = new System.Drawing.Point(680, 70);
            this.tbNewID.Name = "tbNewID";
            this.tbNewID.Size = new System.Drawing.Size(313, 35);
            this.tbNewID.TabIndex = 20;
            this.tbNewID.Text = "Auto Generated";
            this.tbNewID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(422, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(252, 32);
            this.label18.TabIndex = 19;
            this.label18.Text = "Sales Associate ID";
            // 
            // deleteAssociate
            // 
            this.deleteAssociate.Controls.Add(this.lblDelete);
            this.deleteAssociate.Controls.Add(this.dgvDelete);
            this.deleteAssociate.Location = new System.Drawing.Point(4, 29);
            this.deleteAssociate.Name = "deleteAssociate";
            this.deleteAssociate.Size = new System.Drawing.Size(1524, 845);
            this.deleteAssociate.TabIndex = 2;
            this.deleteAssociate.Text = "Delete Sales Associate";
            this.deleteAssociate.UseVisualStyleBackColor = true;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(363, 92);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(693, 52);
            this.lblDelete.TabIndex = 21;
            this.lblDelete.Text = "Select A Sales Associate to Delete";
            // 
            // dgvDelete
            // 
            this.dgvDelete.AllowUserToAddRows = false;
            this.dgvDelete.AllowUserToDeleteRows = false;
            this.dgvDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDelete.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDelete.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDelete.Location = new System.Drawing.Point(0, 221);
            this.dgvDelete.MultiSelect = false;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.ReadOnly = true;
            this.dgvDelete.RowTemplate.Height = 28;
            this.dgvDelete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDelete.Size = new System.Drawing.Size(1518, 223);
            this.dgvDelete.TabIndex = 20;
            this.dgvDelete.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDelete_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 80F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Sales Associate ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 120F;
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 120F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 150F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Street Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "City";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 60F;
            this.dataGridViewTextBoxColumn6.HeaderText = "State";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Zip";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn8.HeaderText = "Total Commission";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // frmManageAssociates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1536, 891);
            this.Controls.Add(this.tabControl);
            this.Name = "frmManageAssociates";
            this.Text = "Manage Sales Associates";
            this.tabControl.ResumeLayout(false);
            this.editAssociate.ResumeLayout(false);
            this.editAssociate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociates)).EndInit();
            this.addAssociate.ResumeLayout(false);
            this.addAssociate.PerformLayout();
            this.deleteAssociate.ResumeLayout(false);
            this.deleteAssociate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage editAssociate;
        private System.Windows.Forms.TabPage addAssociate;
        private System.Windows.Forms.TabPage deleteAssociate;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbCommission;
        private System.Windows.Forms.Label lblComm;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreateSalesAssociate;
        private System.Windows.Forms.TextBox tbNewCommission;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNewUserID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNewZip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbNewState;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbNewCity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbNewStreet;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbNewLast;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbNewFirst;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbNewID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvAssociates;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.DataGridView dgvDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCommission;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label1;
    }
}