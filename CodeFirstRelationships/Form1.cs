using CodeFirstRelationships.Context;
using CodeFirstRelationships.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelationships
{
    public partial class Form1 : Form
    {
        CarDbContext context = new CarDbContext();
        LicensePlate selectedPlate;
        Person selectedPerson;
        Car selectedCar;
        Engineer selectedEngineer;
        
        Form2 form2;

        public Form1()
        {
            InitializeComponent();

            ListPlates();
            ListPersons();
            ListCars();
            ListEngineers();

            form2 = new Form2(context);

            dgvPlates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEngineers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            cmbOwner.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLicensePlate.DropDownStyle = ComboBoxStyle.DropDownList;

            #region Otomatik olarak oluşturulmuş Many to Many tablosu için ekleme silme işlemleri
            // DepartmentPart veritabanı tablosu otomatik olarak oluştuğu için kod kısmında entity'miz bulunmamakta veriye ulaşmak için bunları yapmamız lazım
            // Direksiyonu montaj bölümüne ekleyelim.
            //var direksiyon = context.Parts.Find(1); // direksiyon Id'si
            //var montajDepartment = context.Departments.Find(1); // montaj Id'si

            //direksiyon.Departments.Add(montajDepartment); 
            //context.SaveChanges();


            // Onarım bölümüne park sensörünü ekleyelim.
            //var onarim = context.Departments.Find(2);
            //var parkSensoru = context.Parts.Find(2);

            //onarim.Parts.Add(parkSensoru);
            //context.SaveChanges();


            // Direksiyonu montaj'dan kaldıralım
            //var direksiyon = context.Parts.Include(x => x.Departments).FirstOrDefault(x => x.Id == 1); // Burada Find ile List tipinde olan Navigation Prop'larını yükleyemiyoruz bunun icin Include kullanmamız lazım => Eager Loading (Hemen Yükleme).
            //direksiyon.Departments.Remove(montajDepartment);
            //context.SaveChanges();

            #endregion
        }

        private void btnAddPlate_Click(object sender, EventArgs e)
        {
            try
            {
                string plateNumber = txtPlateNumber.Text;
                if (plateNumber.Trim().Length == 0 || plateNumber != plateNumber.Trim())
                {
                    MessageBox.Show("Please do not leave the field empty.");
                    return;
                }

                LicensePlate newPlate = new LicensePlate();
                newPlate.Number = txtPlateNumber.Text;

                context.LicensePlates.Add(newPlate);
                context.SaveChanges();

                MessageBox.Show("License Plate has succesfully been Added!.");
                
                ListPlates();
                
                txtPlateNumber.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void btnUpdatePlate_Click(object sender, EventArgs e)
        {
            if (selectedPlate != null) // gridden seçildiyse güncelle
            {
                string plateNumber = txtPlateNumber.Text;
                if (plateNumber.Trim().Length == 0 || plateNumber != plateNumber.Trim())
                {
                    MessageBox.Show("Please do not leave the field empty.");
                    return;
                }

                selectedPlate.Number = txtPlateNumber.Text;
                context.SaveChanges();

                MessageBox.Show("License Plate has succesfully been Updated!.");
                
                ListPlates(); // Güncelleme yaptıktan sonra DataGridView içindeki verileri tekrar listeleyip güncelle.
                ResetSelectedPlate(); // lblSelectedPlate.Text'ini sıfırla
                
                txtPlateNumber.Text = string.Empty;
            }
            else
                MessageBox.Show("Please select a plate to update");
        }
        private void btnDeletePlate_Click(object sender, EventArgs e)
        {
            if (selectedPlate != null)
            {
                context.LicensePlates.Remove(selectedPlate);
                context.SaveChanges();
                ListPlates();
                ResetSelectedPlate();
                MessageBox.Show("The Plate has successfully been Deleted!");
                txtPlateNumber.Text = string.Empty;
            }
            else
                MessageBox.Show("Please select a plate to delete");
        }

        private void dgvPlates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPlate = (LicensePlate)dgvPlates.SelectedRows[0].DataBoundItem;
            lblSelectedPlate.Text = "Selected Plate: " + selectedPlate.Id + " " + selectedPlate.Number;
            txtPlateNumber.Text = selectedPlate.Number.ToString();
        }
       


        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                if (firstName.Trim().Length == 0 || firstName != firstName.Trim() || lastName.Trim().Length == 0 || lastName != lastName.Trim())
                {
                    MessageBox.Show("Please do not leave the field empty.");
                    return;
                }

                Person newPerson = new Person();
                newPerson.FirstName = txtFirstName.Text;
                newPerson.LastName = txtLastName.Text;

                context.Persons.Add(newPerson);
                context.SaveChanges();

                ListPersons();
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                MessageBox.Show("Person has succesfully been Registered!.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            if (selectedPerson != null)
            {
                context.Persons.Remove(selectedPerson);
                context.SaveChanges();
                ListPersons();
                ResetSelectedPerson();
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                MessageBox.Show("The Person has successfully been Deleted!");
            }
            else
                MessageBox.Show("Please select a Person to delete");
        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            if (selectedPerson != null)
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                if (firstName.Trim().Length == 0 || firstName != firstName.Trim() || lastName.Trim().Length == 0 || lastName != lastName.Trim())
                {
                    MessageBox.Show("Please do not leave the field empty.");
                    return;
                }
                
                selectedPerson.FirstName = txtFirstName.Text;
                selectedPerson.LastName = txtLastName.Text;
                context.SaveChanges();

                ListPersons();
                ResetSelectedPerson();

                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                MessageBox.Show("Person has succesfully been Updated!.");
            }
            else
                MessageBox.Show("Please select a Person to update");
        }

        private void dgvPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPerson = (Person)dgvPersons.SelectedRows[0].DataBoundItem;
            txtFirstName.Text = selectedPerson.FirstName;
            txtLastName.Text = selectedPerson.LastName;

            lblSelectedPerson.Text = "Selected Person: " + selectedPerson.Id + " " + selectedPerson.FirstName + " " + selectedPerson.LastName;
        }



        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedPlateId = 0;
                if (cmbLicensePlate.SelectedIndex != 0)
                {
                    selectedPlateId = ((LicensePlate)cmbLicensePlate.SelectedItem).Id;

                    if (context.Cars.Any(c => c.LicensePlateId == selectedPlateId)) // PlateId kullanılıyor mu diye kontrol et.
                    {
                        MessageBox.Show("This Plate Number has already been using. Please select another plate");
                        return; // aşağıya bakmadan metodu kırar.
                    }
                }


                Car newCar = new();
                newCar.Brand = txtBrand.Text;
                newCar.Color = txtColor.Text;

                if (selectedPlateId != 0) // combobox'ta "Plaka Seçiniz" işaretli değilse
                    newCar.LicensePlateId = selectedPlateId; // Foreign key

                if (cmbOwner.SelectedIndex != 0) // combobox'ta "Sahip Seçiniz" işaretli değilse
                    newCar.PersonId = ((Person)cmbOwner.SelectedItem).Id; // Foreign key


                context.Cars.Add(newCar);
                context.SaveChanges();

                ListCars();

                txtBrand.Text = string.Empty;
                txtColor.Text = string.Empty;
                cmbLicensePlate.SelectedIndex = 0;
                cmbOwner.SelectedIndex = 0;

                MessageBox.Show("Car has succesfully been Added!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }

        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            if (selectedCar != null)
            {
                int selectedPlateId = 0;
                if (cmbLicensePlate.SelectedIndex != 0)
                {
                    selectedPlateId = ((LicensePlate)cmbLicensePlate.SelectedItem).Id;

                    if (context.Cars.Any(c => c.LicensePlateId == selectedPlateId && c.Id != selectedCar.Id)) // PlateId kullanılıyor mu ve Güncellerken kendisi hariç o plakayı kullanan başkaları varsa hata vermeli. Eklerken buna gerek yok ancak güncellerken kendisinin hariç tutulması lazım.
                    {
                        MessageBox.Show("This Plate Number has already been using. Please select another plate to update");
                        return; // aşağıya bakmadan metodu kırar.
                    }
                }

                selectedCar.Brand = txtBrand.Text;
                selectedCar.Color = txtColor.Text;

                if (selectedPlateId != 0) // combobox'ta "Plaka Seçiniz" işaretli değilse
                    selectedCar.LicensePlateId = selectedPlateId; // Foreign key
                else
                    selectedCar.LicensePlateId = null; // LicensePlateId'sini kaldırmak istersek.

                if (cmbOwner.SelectedIndex != 0) // combobox'ta "Sahip Seçiniz" işaretli değilse
                    selectedCar.PersonId = ((Person)cmbOwner.SelectedItem).Id; // Foreign key
                else
                    selectedCar.PersonId = null; // Person'unu kaldırmak istersek

                context.SaveChanges();

                ResetSelectedCar();
                ListCars();

                txtBrand.Text = string.Empty;
                txtColor.Text = string.Empty;
                cmbLicensePlate.SelectedIndex = 0;
                cmbOwner.SelectedIndex = 0;

                MessageBox.Show("Car has succesfully been Updated!");
            }
            else
                MessageBox.Show("Please select a Car to update!");
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (selectedCar != null)
            {
                context.Cars.Remove(selectedCar);
                context.SaveChanges();

                ResetSelectedCar();
                ListCars();

                txtBrand.Text = string.Empty;
                txtColor.Text = string.Empty;
                cmbLicensePlate.SelectedIndex = 0;
                cmbOwner.SelectedIndex = 0;

                MessageBox.Show("The Car has successfully been Deleted!");
            }
            else
                MessageBox.Show("Please select a Car to delete");

        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCar = (Car)dgvCars.SelectedRows[0].DataBoundItem;

            // lblSelectedCar'ın text'ine seçilen arabanın bilgilerini yazdırma
            if (selectedCar.LicensePlate != null)
                lblSelectedCar.Text = "Selected Car: " + selectedCar.Id + " " + selectedCar.LicensePlate.Number;
            else
                lblSelectedCar.Text = "Selected Car: " + selectedCar.Id + " Plaka YOK";

            // Textbox ve Combobox'lara seçilen arabanın bilgilerini yazdırma
            txtColor.Text = selectedCar.Color;
            txtBrand.Text = selectedCar.Brand;

            if (selectedCar.LicensePlateId != null)
                cmbLicensePlate.SelectedItem = selectedCar.LicensePlate;
            else
                cmbLicensePlate.SelectedIndex = 0;

            if (selectedCar.PersonId != null)
                cmbOwner.SelectedItem = selectedCar.Person;
            else
                cmbOwner.SelectedIndex = 0;
        }



        private void btnAddEngineer_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtEngineerFirstName.Text;
                string lastName = txtEngineerLastName.Text;
                if (firstName.Trim().Length == 0 || firstName != firstName.Trim() || lastName.Trim().Length == 0 || lastName != lastName.Trim())
                {
                    MessageBox.Show("Please do not leave the field empty.");
                    return;
                }

                Engineer newEngineer = new Engineer();
                newEngineer.FirstName = txtEngineerFirstName.Text;
                newEngineer.LastName = txtEngineerLastName.Text;

                context.Engineers.Add(newEngineer);
                context.SaveChanges();

                ListEngineers();
                txtEngineerFirstName.Text = string.Empty;
                txtEngineerLastName.Text = string.Empty;
                MessageBox.Show("Engineer has succesfully been Registered!.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void btnUpdateEngineer_Click(object sender, EventArgs e)
        {
            if (selectedEngineer != null)
            {
                string firstName = txtEngineerFirstName.Text;
                string lastName = txtEngineerLastName.Text;
                if (firstName.Trim().Length == 0 || firstName != firstName.Trim() || lastName.Trim().Length == 0 || lastName != lastName.Trim())
                {
                    MessageBox.Show("Please do not leave the field empty.");
                    return;
                }

                selectedEngineer.FirstName = txtEngineerFirstName.Text;
                selectedEngineer.LastName = txtEngineerLastName.Text;
                context.SaveChanges();

                ListEngineers();
                ResetSelectedEngineer();

                txtEngineerFirstName.Text = string.Empty;
                txtEngineerLastName.Text = string.Empty;

                MessageBox.Show("Engineer has succesfully been Updated!.");
            }
            else
                MessageBox.Show("Please select a Engineer to update");
        }

        private void btnDeleteEngineer_Click(object sender, EventArgs e)
        {
            if (selectedEngineer != null)
            {
                context.Engineers.Remove(selectedEngineer);
                context.SaveChanges();

                ListEngineers();
                ResetSelectedEngineer();

                txtEngineerFirstName.Text = string.Empty;
                txtEngineerLastName.Text = string.Empty;

                MessageBox.Show("The Engineer has successfully been Deleted!");
            }
            else
                MessageBox.Show("Please select a Engineer to delete");
        }

        private void dgvEngineers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedEngineer = (Engineer)dgvEngineers.SelectedRows[0].DataBoundItem;
            txtEngineerFirstName.Text = selectedEngineer.FirstName;
            txtEngineerLastName.Text = selectedEngineer.LastName;

            lblSelectedEngineer.Text = "Selected Engineer: " + selectedEngineer.Id + " " + selectedEngineer.FirstName + " " + selectedEngineer.LastName;
        }


        private void ListPlates()
        {
            var plates = context.LicensePlates.ToList();
            dgvPlates.DataSource = plates;

            cmbLicensePlate.Items.Clear();
            cmbLicensePlate.Items.Add("Plaka Seçiniz.");
            cmbLicensePlate.Items.AddRange(plates.ToArray());
            cmbLicensePlate.SelectedIndex = 0; // "Plaka Seçiniz"
        }
        public void ListPersons()
        {
            var persons = context.Persons.ToList();
            dgvPersons.DataSource = persons;

            cmbOwner.Items.Clear(); // tekrar tekrar eklenmesin diye önce temizledik
            cmbOwner.Items.Add("Sahip Seçiniz.");
            cmbOwner.Items.AddRange(persons.ToArray());
            cmbOwner.SelectedIndex = 0; // "Sahip Seçiniz"
        }
        private void ListCars()
        {
            dgvCars.DataSource = context.Cars.ToList();
            dgvCars.Columns[3].Visible = dgvCars.Columns[5].Visible = false; // LicensePlateId ve PersonId kolonlarının gizlenmesi
        }
        private void ListEngineers()
        {
            var engineers = context.Engineers.ToList();
            dgvEngineers.DataSource = engineers;
        }
        public void ResetSelectedCar()
        {
            selectedCar = null;
            lblSelectedCar.Text = "Selected Car: ";
        }
        public void ResetSelectedPerson()
        {
            selectedPerson = null;
            lblSelectedPerson.Text = "Selected Person: ";
        }
        private void ResetSelectedPlate()
        {
            selectedPlate = null;
            lblSelectedPlate.Text = "Selected Plate: ";
        }
        private void ResetSelectedEngineer()
        {
            selectedEngineer = null;
            lblSelectedEngineer.Text = "Selected Engineer: ";
        }

        private void btnCarEngineerForm_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }
    }
}
