namespace CodeFirstRelationships
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbCar = new ComboBox();
            cmbEngineer = new ComboBox();
            txtNumberOfDays = new TextBox();
            groupBox1 = new GroupBox();
            btnResetCarEngineer = new Button();
            btnUpdateCarEngineer = new Button();
            btnDeleteCarEngineer = new Button();
            btnAddCarEngineer = new Button();
            lblSelectedCarEngineer = new Label();
            dgvCarEngineer = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarEngineer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(77, 28);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Car:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(46, 68);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Engineer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(9, 106);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 0;
            label3.Text = "NumberOfDays:";
            // 
            // cmbCar
            // 
            cmbCar.FormattingEnabled = true;
            cmbCar.Location = new Point(123, 25);
            cmbCar.Name = "cmbCar";
            cmbCar.Size = new Size(154, 23);
            cmbCar.TabIndex = 1;
            // 
            // cmbEngineer
            // 
            cmbEngineer.FormattingEnabled = true;
            cmbEngineer.Location = new Point(123, 68);
            cmbEngineer.Name = "cmbEngineer";
            cmbEngineer.Size = new Size(154, 23);
            cmbEngineer.TabIndex = 1;
            // 
            // txtNumberOfDays
            // 
            txtNumberOfDays.BorderStyle = BorderStyle.FixedSingle;
            txtNumberOfDays.Location = new Point(123, 106);
            txtNumberOfDays.Name = "txtNumberOfDays";
            txtNumberOfDays.Size = new Size(154, 23);
            txtNumberOfDays.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnResetCarEngineer);
            groupBox1.Controls.Add(btnUpdateCarEngineer);
            groupBox1.Controls.Add(btnDeleteCarEngineer);
            groupBox1.Controls.Add(btnAddCarEngineer);
            groupBox1.Controls.Add(lblSelectedCarEngineer);
            groupBox1.Controls.Add(dgvCarEngineer);
            groupBox1.Controls.Add(cmbCar);
            groupBox1.Controls.Add(txtNumberOfDays);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbEngineer);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(31, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 436);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "CarEngineers";
            // 
            // btnResetCarEngineer
            // 
            btnResetCarEngineer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnResetCarEngineer.Location = new Point(297, 91);
            btnResetCarEngineer.Name = "btnResetCarEngineer";
            btnResetCarEngineer.Size = new Size(58, 45);
            btnResetCarEngineer.TabIndex = 9;
            btnResetCarEngineer.Text = "Reset ";
            btnResetCarEngineer.UseVisualStyleBackColor = true;
            btnResetCarEngineer.Click += btnResetCarEngineer_Click;
            // 
            // btnUpdateCarEngineer
            // 
            btnUpdateCarEngineer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateCarEngineer.Location = new Point(222, 144);
            btnUpdateCarEngineer.Name = "btnUpdateCarEngineer";
            btnUpdateCarEngineer.Size = new Size(69, 28);
            btnUpdateCarEngineer.TabIndex = 8;
            btnUpdateCarEngineer.Text = "Update";
            btnUpdateCarEngineer.UseVisualStyleBackColor = true;
            btnUpdateCarEngineer.Click += btnUpdateCarEngineer_Click;
            // 
            // btnDeleteCarEngineer
            // 
            btnDeleteCarEngineer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteCarEngineer.Location = new Point(147, 144);
            btnDeleteCarEngineer.Name = "btnDeleteCarEngineer";
            btnDeleteCarEngineer.Size = new Size(69, 28);
            btnDeleteCarEngineer.TabIndex = 8;
            btnDeleteCarEngineer.Text = "Delete";
            btnDeleteCarEngineer.UseVisualStyleBackColor = true;
            btnDeleteCarEngineer.Click += btnDeleteCarEngineer_Click;
            // 
            // btnAddCarEngineer
            // 
            btnAddCarEngineer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddCarEngineer.Location = new Point(72, 144);
            btnAddCarEngineer.Name = "btnAddCarEngineer";
            btnAddCarEngineer.Size = new Size(69, 28);
            btnAddCarEngineer.TabIndex = 8;
            btnAddCarEngineer.Text = "Add";
            btnAddCarEngineer.UseVisualStyleBackColor = true;
            btnAddCarEngineer.Click += btnAddCarEngineer_Click;
            // 
            // lblSelectedCarEngineer
            // 
            lblSelectedCarEngineer.BorderStyle = BorderStyle.FixedSingle;
            lblSelectedCarEngineer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSelectedCarEngineer.Location = new Point(9, 395);
            lblSelectedCarEngineer.Name = "lblSelectedCarEngineer";
            lblSelectedCarEngineer.Size = new Size(346, 23);
            lblSelectedCarEngineer.TabIndex = 7;
            lblSelectedCarEngineer.Text = "Selected CarEngineer: ";
            // 
            // dgvCarEngineer
            // 
            dgvCarEngineer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarEngineer.Location = new Point(9, 178);
            dgvCarEngineer.Name = "dgvCarEngineer";
            dgvCarEngineer.Size = new Size(346, 203);
            dgvCarEngineer.TabIndex = 3;
            dgvCarEngineer.CellClick += dgvCarEngineer_CellClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 471);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarEngineer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbCar;
        private ComboBox cmbEngineer;
        private TextBox txtNumberOfDays;
        private GroupBox groupBox1;
        private DataGridView dgvCarEngineer;
        private Label lblSelectedCarEngineer;
        private Button btnAddCarEngineer;
        private Button btnResetCarEngineer;
        private Button btnUpdateCarEngineer;
        private Button btnDeleteCarEngineer;
    }
}