using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class Book
    {
        private string name_book ;
        private int pag ;
        private int chapters ;
        private string date_lounch;

        public string Name_book { get => name_book; set => name_book = value; }
        public int Pag { get => pag; set => pag = value; }
        public int Chapters { get => chapters; set => chapters = value; }
        public string Date_lounch { get => date_lounch; set => date_lounch = value; }

        //metodo

        public string initbook()
        {
            string msj = "has iniciado a leer el libro " + Name_book + "que contiene " + Pag + "y " + Chapters + "capitulos"+ "Se lanzo en "+date_lounch;
            return msj;
        }
        public string date()
        {
            string msj = "fue lazado en "+Date_lounch+"";
            return msj;
        }
    }
}