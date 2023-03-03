using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class Card
    {
        string owner = "Harrinson martinez";
        double number = 1088944866;
        string due_date = "21 de noviembre 2024";
        string bank = "colombina";

        //metodos 
        public string Star()
        {
            string msj = "La tajeta del banco " + bank + "y de numero "+number+" fue rechazada ";
            return msj;
        }
        public string Owner()
        {
            string msj = "A nombre de " + owner + " no es valida";
            return msj;
        }
        public string dueData()
        {
            string msj = "Con la fecha de vencimiento en " + due_date + "";
            return msj;
        }

        

        }
    }
