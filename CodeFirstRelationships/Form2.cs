using CodeFirstRelationships.Context;
using CodeFirstRelationships.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstRelationships
{
    public partial class Form2 : Form
    {
        private CarDbContext context;

        CarEngineer selectedCarEngineer;
        public Form2(CarDbContext db)
        {
            InitializeComponent();
            context = db; // Form1'de bulunan context'i aldık.

            ListCarEngineers();
            ListCars();
            ListEngineers();

            dgvCarEngineer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            cmbEngineer.DropDownStyle = ComboBoxStyle.DropDownList; // combobox'a değer yazılamaz hale gelir.
            cmbCar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAddCarEngineer_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControlFields())
                {
                    CarEngineer newCarEngineer = new();
                    newCarEngineer.EngineerId = ((Engineer)cmbEngineer.SelectedItem).Id;
                    newCarEngineer.CarId = ((Car)cmbCar.SelectedItem).Id;
                    newCarEngineer.NumberOfDays = Convert.ToInt32(txtNumberOfDays.Text);

                    context.CarEngineers.Add(newCarEngineer);
                    context.SaveChanges();

                    ListCarEngineers();

                    ResetCarEngineers();

                    MessageBox.Show("CarEngineer data has succesfully been Added!.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void btnUpdateCarEngineer_Click(object sender, EventArgs e)
        {
            if (selectedCarEngineer != null)
            {
                if (ControlFields())
                {
                    selectedCarEngineer.EngineerId = ((Engineer)cmbEngineer.SelectedItem).Id;
                    selectedCarEngineer.CarId = ((Car)cmbCar.SelectedItem).Id;
                    selectedCarEngineer.NumberOfDays = Convert.ToInt32(txtNumberOfDays.Text);

                    context.SaveChanges();

                    MessageBox.Show("CarEngineer has succesfully been updated!");
                    
                    ListCarEngineers();
                    ResetCarEngineers();
                }
            }
            else
                MessageBox.Show("Please select a CarEngineer to update");

        }
        private void btnDeleteCarEngineer_Click(object sender, EventArgs e)
        {
            if(selectedCarEngineer != null)
            {
                context.CarEngineers.Remove(selectedCarEngineer);
                context.SaveChanges();

                MessageBox.Show("CarEngineer has succesfully been Deleted!");

                ListCarEngineers();
                ResetCarEngineers();
            }
            else
                MessageBox.Show("Please select a CarEngineer to Delete!");
        }
        private bool ControlFields()
        {
            if (cmbCar.SelectedIndex == 0 || cmbEngineer.SelectedIndex == 0 || txtNumberOfDays.Text == string.Empty)
            {
                MessageBox.Show("Please do not leave the field empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumberOfDays.Text))
            {
                MessageBox.Show("Please write number of working days!");
                return false;
            }

            if (!int.TryParse(txtNumberOfDays.Text, out int days)) // yazılan değeri int'e çeviremiyorsa
            {
                MessageBox.Show("Please write number for working days!");
                return false;
            }

            if (days <= 0) // NumberOfDays <= 0 ise
            {
                MessageBox.Show("Please write positive numbers for working days!");
                return false;
            }
            return true;
        }

        private void ResetCarEngineers()
        {
            btnResetCarEngineer_Click(null, EventArgs.Empty);
        }
        

        private void btnResetCarEngineer_Click(object sender, EventArgs e)
        {
            cmbCar.SelectedIndex = 0;
            cmbEngineer.SelectedIndex = 0;
            txtNumberOfDays.Text = string.Empty;
            lblSelectedCarEngineer.Text = "Selected Engineer: ";
            selectedCarEngineer = null;
        }

        private void dgvCarEngineer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCarEngineer = (CarEngineer)dgvCarEngineer.SelectedRows[0].DataBoundItem;

            cmbCar.SelectedItem = selectedCarEngineer.Cars;
            cmbEngineer.SelectedItem = selectedCarEngineer.Engineers;
            txtNumberOfDays.Text = selectedCarEngineer.NumberOfDays.ToString();

            lblSelectedCarEngineer.Text = "Selected Engineer: " + selectedCarEngineer.Id + ": " + selectedCarEngineer.Cars + " -- " + selectedCarEngineer.Engineers;
        }

        private void ListCarEngineers()
        {
            dgvCarEngineer.DataSource = context.CarEngineers.ToList();
        }

        private void ListCars()
        {
            // Değerlerin düzgün gelebilmesi için önce Car entity'sinde ToString metodunu Override etmemiz lazım
            cmbCar.Items.Clear(); 
            cmbCar.Items.Add("Select Car");
            cmbCar.Items.AddRange(context.Cars.ToArray());
            cmbCar.SelectedIndex = 0;
        }

        private void ListEngineers()
        {
            // Değerlerin düzgün gelebilmesi için önce Engineer entity'sinde ToString metodunu Override etmemiz lazım
            cmbEngineer.Items.Clear();
            cmbEngineer.Items.Add("Select Engineer");
            cmbEngineer.Items.AddRange(context.Engineers.ToArray());
            cmbEngineer.SelectedIndex = 0;
        }
    }
}
