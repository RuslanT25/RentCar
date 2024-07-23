using Data.Entities;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Views.User_Controls
{
    public partial class Uc_CarGetDetail : UserControl
    {
        readonly ICarRepository _carRepo;
        public Uc_CarGetDetail(ICarRepository carRepository, Car car)
        {
            _carRepo = carRepository;
            InitializeComponent();
            DisplayCarDetails(car);
        }

        public string Image
        {
            get { return pictureBox1.ImageLocation; }
            set { pictureBox1.ImageLocation = value; }
        }

        public string Name
        {
            get { return lblCarName.Text; }
            set { lblCarName.Text = value; }
        }

        public string Passanger
        {
            get { return lblPassanger.Text; }
            set { lblPassanger.Text = value; }
        }

        public string Transmission
        {
            get { return lblTransmission.Text; }
            set { lblTransmission.Text = value; }
        }

        public string Air
        {
            get { return lblAir.Text; }
            set { lblAir.Text = value; }
        }

        public string Insurance
        {
            get { return lblInsurance.Text; }
            set { lblInsurance.Text = value; }
        }

        public string Mileage
        {
            get { return lblMileage.Text; }
            set { lblMileage.Text = value; }
        }

        public string Price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public string CarStatus
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }

        public void DisplayCarDetails(Car car)
        {
            Name = car.Name;
            Image = car.Image;
            Transmission = car.Transmission.Type;
            Passanger = car.Passanger.ToString();
            Air = (car.AirConditioning) ? "Kondisoner var" : "Kondisoner yoxdur";
            Insurance = (car.Insurance) ? "Sığorta var" : "Sığorta yoxdur";
            Mileage = car.Mileage.ToString() + " km/l sərfiyyatı var";
            Price = car.Price.ToString();
            CarStatus = (car.CarStatus == true) ? "Kiraye edilib" : "Kiraye edilmeyib";
        }
    }
}
