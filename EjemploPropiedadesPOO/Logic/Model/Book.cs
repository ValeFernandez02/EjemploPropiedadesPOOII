using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class Book
    {
        string name_book = "narnia";
        int pag = 526;
        int chapters = 10;
        string date_lounch = "10 abril 1997";

        //metodo

        public string initbook()
        {
            string msj = "has iniciado a leer el libro " + name_book + "que contiene " + pag + "y " + chapters + "capitulos";
            return msj;
        }
        public string date()
        {
            string msj = "fue lazado en "+date_lounch+"";
            return msj;
        }
    }
}