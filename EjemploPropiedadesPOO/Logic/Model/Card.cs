using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class Card
    {
        private string bank ;
        private double number ;
        private string owner ;
        private string due_data ;

        public Card(string owner, double number, string due_date, string bank)
        {
            this.bank = bank;
            this.number = number;
            this.owner = owner;
            this.due_data = due_date;
        }

        public string Bank { get => bank; set => bank = value; }
        public double Number { get => number; set => number = value; }
        public string Owner { get => owner; set => owner = value; }
        public string Due_data { get => due_data; set => due_data = value; }



        //metodos 
        public string Star()
        {
            string msj = "La tarjet del banco " + Bank + " de numero " + Number + " a nombre de " + Owner + " y fecha de vencimiento " + Due_data + " Fue rechazada";
            return msj;
        }
       

        

        }
    }
