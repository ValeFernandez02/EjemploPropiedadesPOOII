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

        string brand = "iPhone";
        double Series = 010203030;
        string color = "dorado";
        string model = "Xs max";

        /*
         * DEfino los metodos
         */
        public string Star()
        {
            string msj = "El celular de la marca " + brand + "Esta encendido";
            return msj;
        }
        public string off()
        {
            string msj = "El celular de color " + color + "Esta encendido";
            return msj;
        }
        public string Model()
        {
            string msj = "El celular del modelo " + model + "Esta encendido";
            return msj;
        }
        public string Email()
        {
            string msj = "serie" + Series + "";
            return msj;
        }

    }
}