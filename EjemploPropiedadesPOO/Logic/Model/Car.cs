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
         * 
         * Defino el nivel de ocultacion cerrado.
         */

        private string color ;
        private int model ;
        private double gallons;
        private string brand;
        

        /*
* Encapsulacion
*/
        public string Color { get => color; set => color = value; }
        public int Model { get => model; set => model = value; }
        public double Gallons { get => gallons; set => gallons = value; }
        public string Brand { get => brand; set => brand = value; }

        /*
         * Constructor
         * /

        /*/

        public Car(string color, int model, double gallons, string brand)
        {
            this.color = color;
            this.model = model;
            this.gallons = gallons;
            this.brand = brand;
        }

            /*
             * Defino los metodos
             */
            public string stop()
        {
            string msj = "El carro de color " + Color + " esta detenido";
            return msj;
        }
        public string star()
        {
            string msj = "El carro de modelo " + Model + ", marca "+Brand+" y color  "+color+" Esta encendido";
            return msj;
        }

    }
}