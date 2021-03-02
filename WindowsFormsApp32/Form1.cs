using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GetCarData(Car car)
        {
            int mileage;
            decimal price;
            int doors;

            car.Make = makeTextBox.Text;

            car.Model = modelTextBox.Text;

            if (int.TryParse(mileageTextBox.Text, out mileage))
            {
                car.Mileage = mileage;
                {
                    if (decimal.TryParse(mileageTextBox.Text, out price))
                    {
                        car.Price = price;
                        if(int.TryParse(doorsTextBox.Text, out doors))
                        {
                            car.Doors = doors;
                        }
                        else
                        {
                            MessageBox.Show("Nieporpawna liczba drzwi.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nieporpawna cenna.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nieporpawny przebieg.");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            Car myCar = new Car();

            GetCarData(myCar);

            makeLabel.Text = myCar.Make;
            modelLabel.Text = myCar.Model;
            mileageLabel.Text = myCar.Mileage.ToString();
            priceLabel.Text = myCar.Price.ToString("c");
            doorsLabel.Text = myCar.Doors.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
