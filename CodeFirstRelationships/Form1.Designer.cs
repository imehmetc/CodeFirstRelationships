namespace CodeFirstRelationships
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpLincesePlates = new GroupBox();
            lblSelectedPlate = new Label();
            dgvPlates = new DataGridView();
            btnUpdatePlate = new Button();
            btnDeletePlate = new Button();
            btnAddPlate = new Button();
            txtPlateNumber = new TextBox();
            label1 = new Label();
            groPersons = new GroupBox();
            txtLastName = new TextBox();
            label2 = new Label();
            lblSelectedPerson = new Label();
            dgvPersons = new DataGridView();
            btnUpdatePerson = new Button();
            btnDeletePerson = new Button();
            btnAddPerson = new Button();
            txtFirstName = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            cmbLicensePlate = new ComboBox();
            cmbOwner = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtBrand = new TextBox();
            label4 = new Label();
            lblSelectedCar = new Label();
            dgvCars = new DataGridView();
            btnUpdateCar = new Button();
            btnDeleteCar = new Button();
            btnAddCar = new Button();
            txtColor = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            txtEngineerLastName = new TextBox();
            label5 = new Label();
            lblSelectedEngineer = new Label();
            dgvEngineers = new DataGridView();
            btnUpdateEngineer = new Button();
            btnDeleteEngineer = new Button();
            btnAddEngineer = new Button();
            txtEngineerFirstName = new TextBox();
            label10 = new Label();
            btnCarEngineerForm = new Button();
            grpLincesePlates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlates).BeginInit();
            groPersons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEngineers).BeginInit();
            SuspendLayout();
            // 
            // grpLincesePlates
            // 
            grpLincesePlates.Controls.Add(lblSelectedPlate);
            grpLincesePlates.Controls.Add(dgvPlates);
            grpLincesePlates.Controls.Add(btnUpdatePlate);
            grpLincesePlates.Controls.Add(btnDeletePlate);
            grpLincesePlates.Controls.Add(btnAddPlate);
            grpLincesePlates.Controls.Add(txtPlateNumber);
            grpLincesePlates.Controls.Add(label1);
            grpLincesePlates.Location = new Point(34, 24);
            grpLincesePlates.Name = "grpLincesePlates";
            grpLincesePlates.Size = new Size(266, 451);
            grpLincesePlates.TabIndex = 0;
            grpLincesePlates.TabStop = false;
            grpLincesePlates.Text = "License Plates";
            // 
            // lblSelectedPlate
            // 
            lblSelectedPlate.BorderStyle = BorderStyle.FixedSingle;
            lblSelectedPlate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSelectedPlate.Location = new Point(11, 415);
            lblSelectedPlate.Name = "lblSelectedPlate";
            lblSelectedPlate.Size = new Size(240, 23);
            lblSelectedPlate.TabIndex = 6;
            lblSelectedPlate.Text = "Selected Plate: ";
            // 
            // dgvPlates
            // 
            dgvPlates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlates.Location = new Point(11, 129);
            dgvPlates.Name = "dgvPlates";
            dgvPlates.Size = new Size(240, 278);
            dgvPlates.TabIndex = 5;
            dgvPlates.CellClick += dgvPlates_CellClick;
            // 
            // btnUpdatePlate
            // 
            btnUpdatePlate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdatePlate.Location = new Point(176, 81);
            btnUpdatePlate.Name = "btnUpdatePlate";
            btnUpdatePlate.Size = new Size(69, 28);
            btnUpdatePlate.TabIndex = 4;
            btnUpdatePlate.Text = "Update";
            btnUpdatePlate.UseVisualStyleBackColor = true;
            btnUpdatePlate.Click += btnUpdatePlate_Click;
            // 
            // btnDeletePlate
            // 
            btnDeletePlate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeletePlate.Location = new Point(99, 81);
            btnDeletePlate.Name = "btnDeletePlate";
            btnDeletePlate.Size = new Size(69, 28);
            btnDeletePlate.TabIndex = 3;
            btnDeletePlate.Text = "Delete";
            btnDeletePlate.UseVisualStyleBackColor = true;
            btnDeletePlate.Click += btnDeletePlate_Click;
            // 
            // btnAddPlate
            // 
            btnAddPlate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddPlate.Location = new Point(22, 81);
            btnAddPlate.Name = "btnAddPlate";
            btnAddPlate.Size = new Size(69, 28);
            btnAddPlate.TabIndex = 2;
            btnAddPlate.Text = "Add";
            btnAddPlate.UseVisualStyleBackColor = true;
            btnAddPlate.Click += btnAddPlate_Click;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPlateNumber.Location = new Point(43, 34);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(153, 23);
            txtPlateNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(11, 40);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 0;
            label1.Text = "No:";
            // 
            // groPersons
            // 
            groPersons.Controls.Add(txtLastName);
            groPersons.Controls.Add(label2);
            groPersons.Controls.Add(lblSelectedPerson);
            groPersons.Controls.Add(dgvPersons);
            groPersons.Controls.Add(btnUpdatePerson);
            groPersons.Controls.Add(btnDeletePerson);
            groPersons.Controls.Add(btnAddPerson);
            groPersons.Controls.Add(txtFirstName);
            groPersons.Controls.Add(label3);
            groPersons.Location = new Point(331, 24);
            groPersons.Name = "groPersons";
            groPersons.Size = new Size(266, 451);
            groPersons.TabIndex = 1;
            groPersons.TabStop = false;
            groPersons.Text = "Persons";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(82, 66);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(153, 23);
            txtLastName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(11, 71);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 7;
            label2.Text = "LastName:";
            // 
            // lblSelectedPerson
            // 
            lblSelectedPerson.BorderStyle = BorderStyle.FixedSingle;
            lblSelectedPerson.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSelectedPerson.Location = new Point(11, 415);
            lblSelectedPerson.Name = "lblSelectedPerson";
            lblSelectedPerson.Size = new Size(240, 23);
            lblSelectedPerson.TabIndex = 6;
            lblSelectedPerson.Text = "Selected Person: ";
            // 
            // dgvPersons
            // 
            dgvPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.Location = new Point(11, 163);
            dgvPersons.Name = "dgvPersons";
            dgvPersons.Size = new Size(240, 244);
            dgvPersons.TabIndex = 5;
            dgvPersons.CellClick += dgvPersons_CellClick;
            // 
            // btnUpdatePerson
            // 
            btnUpdatePerson.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdatePerson.Location = new Point(174, 115);
            btnUpdatePerson.Name = "btnUpdatePerson";
            btnUpdatePerson.Size = new Size(69, 28);
            btnUpdatePerson.TabIndex = 4;
            btnUpdatePerson.Text = "Update";
            btnUpdatePerson.UseVisualStyleBackColor = true;
            btnUpdatePerson.Click += btnUpdatePerson_Click;
            // 
            // btnDeletePerson
            // 
            btnDeletePerson.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeletePerson.Location = new Point(97, 115);
            btnDeletePerson.Name = "btnDeletePerson";
            btnDeletePerson.Size = new Size(69, 28);
            btnDeletePerson.TabIndex = 3;
            btnDeletePerson.Text = "Delete";
            btnDeletePerson.UseVisualStyleBackColor = true;
            btnDeletePerson.Click += btnDeletePerson_Click;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddPerson.Location = new Point(20, 115);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(69, 28);
            btnAddPerson.TabIndex = 2;
            btnAddPerson.Text = "Add";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(82, 34);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(153, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(11, 40);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 0;
            label3.Text = "FirstName:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbLicensePlate);
            groupBox1.Controls.Add(cmbOwner);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtBrand);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblSelectedCar);
            groupBox1.Controls.Add(dgvCars);
            groupBox1.Controls.Add(btnUpdateCar);
            groupBox1.Controls.Add(btnDeleteCar);
            groupBox1.Controls.Add(btnAddCar);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(633, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 451);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cars";
            // 
            // cmbLicensePlate
            // 
            cmbLicensePlate.FormattingEnabled = true;
            cmbLicensePlate.Location = new Point(107, 122);
            cmbLicensePlate.Name = "cmbLicensePlate";
            cmbLicensePlate.Size = new Size(153, 23);
            cmbLicensePlate.TabIndex = 9;
            // 
            // cmbOwner
            // 
            cmbOwner.FormattingEnabled = true;
            cmbOwner.Location = new Point(107, 93);
            cmbOwner.Name = "cmbOwner";
            cmbOwner.Size = new Size(153, 23);
            cmbOwner.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(11, 129);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 7;
            label8.Text = "License Plate:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(11, 100);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 7;
            label7.Text = "Owner:";
            // 
            // txtBrand
            // 
            txtBrand.BorderStyle = BorderStyle.FixedSingle;
            txtBrand.Location = new Point(107, 64);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(153, 23);
            txtBrand.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(11, 71);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "Brand:";
            // 
            // lblSelectedCar
            // 
            lblSelectedCar.BorderStyle = BorderStyle.FixedSingle;
            lblSelectedCar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSelectedCar.Location = new Point(11, 415);
            lblSelectedCar.Name = "lblSelectedCar";
            lblSelectedCar.Size = new Size(240, 23);
            lblSelectedCar.TabIndex = 6;
            lblSelectedCar.Text = "Selected Car: ";
            // 
            // dgvCars
            // 
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(11, 216);
            dgvCars.Name = "dgvCars";
            dgvCars.Size = new Size(240, 191);
            dgvCars.TabIndex = 5;
            dgvCars.CellClick += dgvCars_CellClick;
            // 
            // btnUpdateCar
            // 
            btnUpdateCar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateCar.Location = new Point(174, 170);
            btnUpdateCar.Name = "btnUpdateCar";
            btnUpdateCar.Size = new Size(69, 28);
            btnUpdateCar.TabIndex = 4;
            btnUpdateCar.Text = "Update";
            btnUpdateCar.UseVisualStyleBackColor = true;
            btnUpdateCar.Click += btnUpdateCar_Click;
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteCar.Location = new Point(97, 170);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(69, 28);
            btnDeleteCar.TabIndex = 3;
            btnDeleteCar.Text = "Delete";
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // btnAddCar
            // 
            btnAddCar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddCar.Location = new Point(20, 170);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(69, 28);
            btnAddCar.TabIndex = 2;
            btnAddCar.Text = "Add";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // txtColor
            // 
            txtColor.BorderStyle = BorderStyle.FixedSingle;
            txtColor.Location = new Point(107, 32);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(153, 23);
            txtColor.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(11, 40);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 0;
            label6.Text = "Color:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEngineerLastName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lblSelectedEngineer);
            groupBox2.Controls.Add(dgvEngineers);
            groupBox2.Controls.Add(btnUpdateEngineer);
            groupBox2.Controls.Add(btnDeleteEngineer);
            groupBox2.Controls.Add(btnAddEngineer);
            groupBox2.Controls.Add(txtEngineerFirstName);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(918, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 451);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Engineers";
            // 
            // txtEngineerLastName
            // 
            txtEngineerLastName.BorderStyle = BorderStyle.FixedSingle;
            txtEngineerLastName.Location = new Point(82, 66);
            txtEngineerLastName.Name = "txtEngineerLastName";
            txtEngineerLastName.Size = new Size(153, 23);
            txtEngineerLastName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(11, 71);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 7;
            label5.Text = "LastName:";
            // 
            // lblSelectedEngineer
            // 
            lblSelectedEngineer.BorderStyle = BorderStyle.FixedSingle;
            lblSelectedEngineer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSelectedEngineer.Location = new Point(11, 415);
            lblSelectedEngineer.Name = "lblSelectedEngineer";
            lblSelectedEngineer.Size = new Size(240, 23);
            lblSelectedEngineer.TabIndex = 6;
            lblSelectedEngineer.Text = "Selected Person: ";
            // 
            // dgvEngineers
            // 
            dgvEngineers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEngineers.Location = new Point(11, 163);
            dgvEngineers.Name = "dgvEngineers";
            dgvEngineers.Size = new Size(240, 244);
            dgvEngineers.TabIndex = 5;
            dgvEngineers.CellClick += dgvEngineers_CellClick;
            // 
            // btnUpdateEngineer
            // 
            btnUpdateEngineer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateEngineer.Location = new Point(174, 115);
            btnUpdateEngineer.Name = "btnUpdateEngineer";
            btnUpdateEngineer.Size = new Size(69, 28);
            btnUpdateEngineer.TabIndex = 4;
            btnUpdateEngineer.Text = "Update";
            btnUpdateEngineer.UseVisualStyleBackColor = true;
            btnUpdateEngineer.Click += btnUpdateEngineer_Click;
            // 
            // btnDeleteEngineer
            // 
            btnDeleteEngineer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteEngineer.Location = new Point(97, 115);
            btnDeleteEngineer.Name = "btnDeleteEngineer";
            btnDeleteEngineer.Size = new Size(69, 28);
            btnDeleteEngineer.TabIndex = 3;
            btnDeleteEngineer.Text = "Delete";
            btnDeleteEngineer.UseVisualStyleBackColor = true;
            btnDeleteEngineer.Click += btnDeleteEngineer_Click;
            // 
            // btnAddEngineer
            // 
            btnAddEngineer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddEngineer.Location = new Point(20, 115);
            btnAddEngineer.Name = "btnAddEngineer";
            btnAddEngineer.Size = new Size(69, 28);
            btnAddEngineer.TabIndex = 2;
            btnAddEngineer.Text = "Add";
            btnAddEngineer.UseVisualStyleBackColor = true;
            btnAddEngineer.Click += btnAddEngineer_Click;
            // 
            // txtEngineerFirstName
            // 
            txtEngineerFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtEngineerFirstName.Location = new Point(82, 34);
            txtEngineerFirstName.Name = "txtEngineerFirstName";
            txtEngineerFirstName.Size = new Size(153, 23);
            txtEngineerFirstName.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(11, 40);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 0;
            label10.Text = "FirstName:";
            // 
            // btnCarEngineerForm
            // 
            btnCarEngineerForm.BackColor = SystemColors.ActiveCaption;
            btnCarEngineerForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCarEngineerForm.Location = new Point(34, 483);
            btnCarEngineerForm.Name = "btnCarEngineerForm";
            btnCarEngineerForm.Size = new Size(1150, 33);
            btnCarEngineerForm.TabIndex = 4;
            btnCarEngineerForm.Text = "Car Engineer Form";
            btnCarEngineerForm.UseVisualStyleBackColor = false;
            btnCarEngineerForm.Click += btnCarEngineerForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 528);
            Controls.Add(btnCarEngineerForm);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groPersons);
            Controls.Add(grpLincesePlates);
            Name = "Form1";
            Text = "Form1";
            grpLincesePlates.ResumeLayout(false);
            grpLincesePlates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlates).EndInit();
            groPersons.ResumeLayout(false);
            groPersons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEngineers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLincesePlates;
        private Label label1;
        private DataGridView dgvPlates;
        private Button btnUpdatePlate;
        private Button btnDeletePlate;
        private Button btnAddPlate;
        private TextBox txtPlateNumber;
        private Label lblSelectedPlate;
        private GroupBox groPersons;
        private Label lblSelectedPerson;
        private DataGridView dgvPersons;
        private Button btnUpdatePerson;
        private Button btnDeletePerson;
        private Button btnAddPerson;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtBrand;
        private Label label4;
        private Label lblSelectedCar;
        private DataGridView dgvCars;
        private Button btnUpdateCar;
        private Button btnDeleteCar;
        private Button btnAddCar;
        private TextBox txtColor;
        private Label label6;
        private Label label8;
        private Label label7;
        private ComboBox cmbLicensePlate;
        private ComboBox cmbOwner;
        private GroupBox groupBox2;
        private TextBox txtEngineerLastName;
        private Label label5;
        private Label lblSelectedEngineer;
        private DataGridView dgvEngineers;
        private Button btnUpdateEngineer;
        private Button btnDeleteEngineer;
        private Button btnAddEngineer;
        private TextBox txtEngineerFirstName;
        private Label label10;
        private Button btnCarEngineerForm;
    }
}
