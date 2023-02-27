using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class Car
    {
        /*
         * Defino las caracteristicas del objeto carro
         * Es decir la Abstraccion
         */

        string color = "verde";
        int model = 2023;
        double gallons = 15.8;


        /*
         * Defino los metodos
         */
        public string stop()
        {
            string msj = "El carro de color " + color + " esta detenido";
            return msj;
        }
        public string star()
        {
            string msj = "El carro de modelo " + model + " Esta encendido";
            return msj;
        }
    }
}