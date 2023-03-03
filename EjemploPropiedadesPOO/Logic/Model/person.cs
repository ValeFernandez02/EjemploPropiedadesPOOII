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

        //metodo 
        public string infoper()
        {
            string msj = "La persona con el color de ojos " + coloreyes + "y de estatura" + height + " te llamo";
            return msj;
        }
        public string doc()
        {
            string msj = "La edad es de "+ege+"coincide con el documento de numero "+document+"";
            return msj;
        }
    }
}