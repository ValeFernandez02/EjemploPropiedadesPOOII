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
            objPhone.Model1 = "14 pro max";
            objPhone.Color = "Blanco";
            objPhone.Brand = "Iphone";

            Phone objPhone1 = new Phone();
            objPhone1.Model1 = "xs max";
            objPhone1.Color = "Dorado";
            objPhone1.Brand = "Iphone";

            Phone objPhone2 = new Phone();
            objPhone2.Model1 = "Mi note 10";
            objPhone2.Color = "Azul";
            objPhone2.Brand = "Xiaomi";

            string msj2 = objPhone.Star();
            Lblmsj2.Text = msj2;

            string msj11 = objPhone2.Star();
            Lblmsj11.Text = msj11;

            string msj12 = objPhone2.Star();
            Lblmsj12.Text = msj12;

            Soccer_game objSpccer = new Soccer_game();
            objSpccer.Number_of_players = 11;
            objSpccer.Equipment = "2 equipos";
            objSpccer.Gamer_name = "futboll";
            objSpccer.Game_time = "90 minitos";


            string msj20 = objSpccer.Star();
            Lblmsj20.Text = msj20;

            Laptop objLatop = new Laptop();
            objLatop.Brand = "acer";
            objLatop.Ram = 8;
            objLatop.Size1 = 15.8;
            objLatop.Processor1 = "i core 5";

            string msj4 = objLatop.Star();
            Lblmsj4.Text = msj4;

            Card objcard = new Card();
            objcard.Owner1 = "Andres martinez";
            objcard.Bank = "Bancolombia";
            objcard.Due_date = "21 noviembre 2023";
            objcard.Number = 1088944866;


            string msj5 = objcard.Star();
            Lblmsj5.Text = msj5;

            Book objbook = new Book();
            objbook.Name_book = "Narnia";
            objbook.Pag = 526;
            objbook.Chapters = 10;
            objbook.Date_lounch = "10 de abril 1995";

            string msj6 = objbook.initbook();
            Lblsmj6.Text = msj5;

            person objperson = new person();
            objperson.Coloreyes = "Azul";
            objperson.Ege = 19;
            objperson.Document = 1019012090;
            objperson.Height = 1.58;

            string msj7 = objperson.infoper();
            Lblmsj7.Text = msj7;

            house objhouse = new house();
            objhouse.Room = 5;
            objhouse.Neighborhood = "Brookland";
            objhouse.Bathroom = 4;
            objhouse.Floor = 2;
            string msj8 = objhouse.infohouse();
            Lblmsj8.Text = msj7;


        }
    }
}