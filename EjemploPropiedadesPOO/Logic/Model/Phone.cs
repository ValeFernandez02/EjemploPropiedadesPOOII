using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class Phone
    {
        /*
         * Defino Las caracteristicas del objeto Phone
         */

        private string brand ;
        private double Series ;
        private string color ;
        private string model ;

        public string Brand { get => brand; set => brand = value; }
        public double Series1 { get => Series; set => Series = value; }
        public string Color { get => color; set => color = value; }
        public string Model1 { get => model; set => model = value; }

        /*
         * DEfino los metodos
         * 
         * 
         */
        //encapsulamiento


        public string Star()
        {
            string msj = "El celular de la marca " + Brand +" color "+ Color+" serie"+Series1+" Modelo "+Model1+" Esta encendido";
            return msj;
        }
        public string off()
        {
            string msj = "El celular de color " + Color + "Esta encendido";
            return msj;
        }
        public string Model()
        {
            string msj = "El celular del modelo " + Model1 + "Esta encendido";
            return msj;
        }
        public string Email()
        {
            string msj = "serie" + Series1 + "";
            return msj;
        }

    }
}