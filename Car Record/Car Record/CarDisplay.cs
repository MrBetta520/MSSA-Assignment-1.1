using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Record
{
    public partial class CarDisplay : Form
    {
        CarRepository repository;
        public CarDisplay()
        {
            InitializeComponent();
        }

        private void CarDisplay_Load(object sender, EventArgs e)
        {
            repository = new CarRepository();
            carGrid.Visible = false;
            groupBoxAdd.Visible = false;
            groupBoxUpdate.Visible = false;
            btnSelect.Visible = false;
            btnDelete.Visible = false;
        }

        private void displayRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carGrid.Visible = true;
            groupBoxAdd.Visible = false;
            groupBoxUpdate.Visible = false;
            carGrid.DataSource = repository.ReadCars();
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = true;
            carGrid.Visible = false;
            Clear();
        }
        private void Clear()
        {
            txtVin.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtVin.Text) &&
               !string.IsNullOrWhiteSpace(txtMake.Text) &&
               !string.IsNullOrWhiteSpace(txtModel.Text) &&
               !string.IsNullOrWhiteSpace(txtYear.Text))
            {
                var newCar = new Car();
                newCar.VIN = txtVin.Text;
                newCar.Make = txtMake.Text;
                newCar.Model = txtModel.Text;
                newCar.Year = Convert.ToInt32(txtYear.Text);
                newCar.Price = Convert.ToDecimal(txtPrice.Text);
                repository.AddRecord(newCar);
            }
            MessageBox.Show("Add new record successfully!");
            groupBoxAdd.Visible = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            groupBoxUpdate.Visible = true;
            btnSelect.Visible = false;
            carGrid.Visible = false;

            var vin = carGrid.CurrentRow.Cells[0].Value;
            var carToUpdate = repository.FindCar((string)vin);
            txtVin1.Text = carToUpdate.VIN;
            txtVin1.ReadOnly = true;
            txtMake1.Text = carToUpdate.Make;
            txtModel1.Text = carToUpdate.Model;
            txtYear1.Text = carToUpdate.Year.ToString();
            txtPrice1.Text = carToUpdate.Price.ToString();
        }

        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carGrid.DataSource = repository.ReadCars();
            carGrid.Visible = true;
            btnSelect.Visible = true;
            groupBoxAdd.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var vin = txtVin1.Text;
            var carToUpdate = repository.FindCar(vin);
            carToUpdate.Make = txtMake1.Text;
            carToUpdate.Model = txtModel1.Text;
            carToUpdate.Year = Convert.ToInt32(txtYear1.Text);
            carToUpdate.Price = Convert.ToDecimal(txtPrice1.Text);

            repository.UpdateRecord(vin, carToUpdate);
            groupBoxUpdate.Visible = false;

            MessageBox.Show("Record update successfully!");
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carGrid.Visible = true;
            btnDelete.Visible = true;
            carGrid.DataSource = repository.ReadCars();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            var vin = carGrid.CurrentRow.Cells[0].Value;
            var carToDel = repository.FindCar((string)vin);
            repository.DeleteRecord(carToDel);
            MessageBox.Show("Record is deleted!");
            btnDelete.Visible=false;
            carGrid.Visible=false;
            
        }
    }
}
