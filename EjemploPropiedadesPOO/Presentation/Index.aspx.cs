using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car objCar1= new Car();//Creo un objeto de Car
            objCar1.Color = "verde";
            objCar1.Model = 2023;
            objCar1.Gallons = 5.8;
            objCar1.Brand = "BMW";


            Car objcar2= new Car();
            objcar2.Color = "Negro";
            objcar2.Model = 2024;
            objcar2.Gallons = 2.9;
            objcar2.Brand = "Aston Martin";


            Car objCar3 = new Car();
            objCar3.Color = "Rojo";
            objCar3.Model = 2020;
            objCar3.Gallons = 6.9;
            objCar3.Brand = "Ferrari";



            string msj = objCar1.star();//Invocamos el metodo star
            LblMsj1.Text = msj;//Asignamos la variable msj

            string msj10 = objcar2.star();//Invocamos el metodo star
            Lblmsj10.Text = msj10;

            string msj9 = objCar3.star();//Invocamos el metodo star
            Lblmsj9.Text = msj9;


            Phone objPhone = new Phone();
            string msj1 = objPhone.Star();
            Lblmsj2.Text = msj1;

            Soccer_game objSpccer = new Soccer_game();
            string msj2 = objSpccer.Star();
            Lblmsj3.Text = msj2;

            Laptop objLatop = new Laptop();
            string msj3 = objLatop.Star();
            Lblmsj4.Text = msj3;

            Card objcard = new Card();
            string msj4 = objcard.Star();
            Lblmsj5.Text = msj4;

            Book objbook = new Book();
            string msj5 = objbook.initbook();
            Lblsmj6.Text = msj5;

            person objperson = new person();
            string msj6 = objperson.infoper();
            Lblmsj7.Text = msj6;

            house objhouse = new house();
            string msj7 = objhouse.infohouse();
            Lblmsj8.Text = msj7;


        }
    }
}