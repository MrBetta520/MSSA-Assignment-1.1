using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace Car_Management
{
    public partial class _718 : Form
    {
        Car porsche718;
        FileStream fs;
        SoapFormatter soapFormatter;
        DataContractJsonSerializer ser;
        BinaryFormatter bf;

        string xmlPath = @"C:\Users\Yang Yu\Desktop\MSSA\Files\xml.xml";
        string jsonPath = @"C:\Users\Yang Yu\Desktop\MSSA\Files\json.txt";
        string binaryPath = @"C:\Users\Yang Yu\Desktop\MSSA\Files\binary.txt";
        public _718()
        {
            InitializeComponent();
        }

        private void _718_Load(object sender, EventArgs e)
        {
            porsche718 = new Car("Porsche", "718", 60500);

            lblMake.Text = $"Make:      {porsche718.Make}";
            lblModel.Text = $"Model:     {porsche718.Model}";
            lblPrice.Text = $"Price:      {porsche718.Price:C}";
        }

        private void serializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(xmlPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, porsche718);
                MessageBox.Show("Your Porsche 718's data already serialized and send to your file.");
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void deserializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs1 = new FileStream(xmlPath, FileMode.Open, FileAccess.Read);
                Car car718 = (Car)soapFormatter.Deserialize(fs1);
                MessageBox.Show($"Your Porsche's Model is {car718.Model}, Price is {car718.Price:C}.");
                fs1.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void serializationJSON_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(jsonPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                ser = new DataContractJsonSerializer(porsche718.GetType());
                ser.WriteObject(fs, porsche718);
                fs.Close();
                MessageBox.Show("Your Porsche 718's data already serialized and send to your file.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Jsondeserialization_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs1 = new FileStream(jsonPath, FileMode.Open, FileAccess.Read);
                Car car718 = ser.ReadObject(fs1) as Car;
                fs1.Close();
                MessageBox.Show($"Your Porsche's Model is {car718.Model}, Price is ${car718.Price:C}.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void serializationBinary_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(binaryPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                bf = new BinaryFormatter();
                bf.Serialize(fs, porsche718);

                fs.Close();

                MessageBox.Show("Your Porsche 718's data already serialized and send to your file.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void deserializationBinary_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs2 = new FileStream(binaryPath, FileMode.Open, FileAccess.Read);
                Car car718 = (Car)bf.Deserialize(fs2);
                fs2.Close();
                MessageBox.Show($"Your Porsche's Model is {car718.Model}, Price is ${car718.Price:C}.");
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            } 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
