using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class Card
    {
        private string owner ;
        private double number ;
        private string due_date ;
        private string bank ;

        public string Owner1 { get => owner; set => owner = value; }
        public double Number { get => number; set => number = value; }
        public string Due_date { get => due_date; set => due_date = value; }
        public string Bank { get => bank; set => bank = value; }

        //metodos 
        public string Star()
        {
            string msj = "La tajeta del banco " + Bank + "y de numero "+Number+" fue rechazada "+"A nombre de "+owner+"y vence en"+Due_date;
            return msj;
        }
        public string Owner()
        {
            string msj = "A nombre de " + Owner1 + " no es valida";
            return msj;
        }
        public string dueData()
        {
            string msj = "Con la fecha de vencimiento en " + Due_date + "";
            return msj;
        }

        

        }
    }
