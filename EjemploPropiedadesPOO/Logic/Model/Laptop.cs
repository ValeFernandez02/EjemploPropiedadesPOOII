using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class Laptop
    {
        string brand = "acer";
        string processor = "i core 5";
        double size = 15.6;
        int ram = 8;

        //metodos
        public string Star()
        {
            string msj = "El computador de la marca " + brand + " Esta encendido ";
            return msj;
        }
        public string Processor()
        {
            string msj = "El precesador de la laptop es el " + processor + " y tiene una ram de " + ram;
            return msj;
        }
        public string Size()
        {
            string msj = "El tamaño de la laptop es de " + size + "";
            return msj;
        }
    }
}