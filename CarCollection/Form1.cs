using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Car> Cars;
        int count = -1;

        private void Form1_Load(object sender, EventArgs e)
        {
            Cars = new List<Car>
            {
                new Car{ Model="M5(F90)",Vendor="BMW", Year=2017, Engine="4.4 L S63 twin-turbo V8" },
                new Car{ Model="Maybach(S580)", Vendor="Mercedes", Year=2021, Engine="twin-turbocharged 4.0-liter V-8 engine"},
                new Car{ Model="Escalade", Vendor="Cadillac", Year=2019, Engine="6.2-liter V8 engine "},
                new Car{ Model="G-Class", Vendor="Mercedes", Year=2020, Engine="twin-turbo AMG 4.0L V8"}
            };
            lbl_model.Text = Cars[0].Model;
            lbl_engine.Text = Cars[0].Engine;
            lbl_vendor.Text = Cars[0].Vendor;
            lbl_year.Text = Cars[0].Year.ToString();

            label1.ImageIndex = 0;
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ++count;
            int index = Cars.Count;

            if (count < index)
            {
                lbl_model.Text = Cars[count].Model;
                lbl_engine.Text = Cars[count].Engine;
                lbl_vendor.Text = Cars[count].Vendor;
                lbl_year.Text = Cars[count].Year.ToString();

                label1.ImageIndex = count;

            }
            else if (count == index)
            {
                count = -1;
                ++count;
                lbl_model.Text = Cars[count].Model;
                lbl_engine.Text = Cars[count].Engine;
                lbl_vendor.Text = Cars[count].Vendor;
                lbl_year.Text = Cars[count].Year.ToString();
                label1.ImageIndex = count;
            }
        }
    }
}
