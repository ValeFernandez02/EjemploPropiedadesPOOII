using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class Laptop
    {
        private string brand ;
        private string processor ;
        private double size ;
        private int ram ;

        public string Brand { get => brand; set => brand = value; }
        public string Processor1 { get => processor; set => processor = value; }
        public double Size1 { get => size; set => size = value; }
        public int Ram { get => ram; set => ram = value; }

        //metodos
        public string Star()
        {
            string msj = "El computador de la marca " + Brand + "con el procesador "+Processor1+"con una ram de "+Ram+" y una pantalla pantalla "+Size1;
            return msj;
        }
        public string Processor()
        {
            string msj = "El precesador de la laptop es el " + Processor1 + " y tiene una ram de " + Ram;
            return msj;
        }
        public string Size()
        {
            string msj = "El tamaño de la laptop es de " + Size1 + "";
            return msj;
        }
    }
}