using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class person
    {
        string coloreyes = "azul";
        int ege = 19;
        int document = 1019012090;
        double height = 1.58;

        public string Coloreyes { get => coloreyes; set => coloreyes = value; }
        public int Ege { get => ege; set => ege = value; }
        public int Document { get => document; set => document = value; }
        public double Height { get => height; set => height = value; }

        //metodo 
        public string infoper()
        {
            string msj = "La persona con el color de ojos " + Coloreyes + " y de estatura" + Height + " Con la edad "+Ege+" y el documento "+Document;
            return msj;
        }
        public string doc()
        {
            string msj = "La edad es de "+Ege+"coincide con el documento de numero "+Document+"";
            return msj;
        }
    }
}