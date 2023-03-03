using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class house
    {
        int room = 5;
        string neighborhood = "Brookland";
        int bathroom = 4;
        int floor = 2;

        //metodo
        public string infohouse()
        {
            string msj = "La casa de "+floor+" pisos cuenta con "+room+" habitaciones y "+bathroom+" baños en el barrio"+neighborhood+"";
            return msj;
        }
    }
}