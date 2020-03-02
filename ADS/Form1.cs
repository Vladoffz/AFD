using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADS
{
    public partial class Form1 : Form
    {
        private Order order;
        private Good good;
        private Transport transport;
        private Destination destination;
        public List<Transport> transports = new List<Transport>();
        public Form1()
        {
            InitializeComponent();
            transports.Add(new Transport(10, 30, 40, 10, TransportType.Foot, true));
            transports.Add(new Transport(100, 100, 120, 300, TransportType.Car, false));
            transports.Add(new Transport(80, 130, 150, 400, TransportType.Bike, false));
            transports.Add(new Transport(800, 1300, 1500, 7000, TransportType.Ship, false));
            transports.Add(new Transport(700, 1100, 1200, 2000, TransportType.Plane, false));
            textBox4.Enabled = false;
            comboBox2.Enabled = false;
            dateTimePicker1.Enabled = false;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Items.Clear();
                good = new Good(comboBox1.SelectedItem.ToString(), Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                foreach (Transport t in transports)
                {
                    if (t.requiredHeight >= good.Height && t.requiredWeight >= good.Weight &&
                        t.requiredWidth >= good.Width)
                    {
                        comboBox2.Items.Add(t.type);
                    }
                }
                textBox4.Enabled = true;
                comboBox2.Enabled = true;
                dateTimePicker1.Enabled = true;
                button2.Enabled = true;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Write correct data");
            }
            catch (FormatException)
            {
                MessageBox.Show("Write correct data");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Write all data");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Transport t in transports)
            {
                if (t.type.ToString() == comboBox2.SelectedItem.ToString())
                {
                    transport = t;
                }
            }
            Random rnd = new Random();
            destination = new Destination(textBox4.Text, rnd.Next(2, 50));
            order = new Order(good, transport, destination, dateTimePicker1.Value);
            MessageBox.Show(Convert.ToString(order.MakeOrder()));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Location = this.Location;
            f.StartPosition = this.StartPosition;

            f.Show();
            this.Hide();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
