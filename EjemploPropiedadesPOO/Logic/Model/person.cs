using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class person
    {
        private string coloreyes ;
        private int ege ;
        private int document ;
        private double height ;

        public person(string coloreyes, int ege, int document, double height)
        {
            this.coloreyes = coloreyes;
            this.ege = ege;
            this.document = document;
            this.height = height;
        }

        public string Coloreyes { get => coloreyes; set => coloreyes = value; }
        public int Ege { get => ege; set => ege = value; }
        public int Document { get => document; set => document = value; }
        public double Height { get => height; set => height = value; }

        //metodo 
        public string infoper()
        {
            string msj = " La persona con el color de ojos  " + Coloreyes + "  y de estatura " + Height + " Con la edad "+Ege+" y el documento "+Document;
            return msj;
        }
        public string doc()
        {
            string msj = "La edad es de "+Ege+"coincide con el documento de numero "+Document+"";
            return msj;
        }
    }
}