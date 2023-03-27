using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class person
    {
        private string nombre;
        private string apellido ;
        private string document ;
        //private double height ;

        public person(string nombre, string apellido, string document/*, double height*/)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.document = document;
            //this.height = height;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ege { get => apellido; set => apellido = value; }
        public string Document { get => document; set => document = value; }
        //public double Height { get => height; set => height = value; }

        //metodo 
        //public string infoper()
        //{
        //    string msj = " La persona con el color de ojos  " + Coloreyes + "  y de estatura " " Con la edad "+Ege+" y el documento "+Document;
        //    return msj;
        //}
        public string doc()
        {
            string msj = "La edad es de "+Ege+"coincide con el documento de numero "+Document+"";
            return msj;
        }
    }
}