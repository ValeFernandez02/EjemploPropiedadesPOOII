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

        public int Room { get => room; set => room = value; }
        public string Neighborhood { get => neighborhood; set => neighborhood = value; }
        public int Bathroom { get => bathroom; set => bathroom = value; }
        public int Floor { get => floor; set => floor = value; }

        //metodo
        public string infohouse()
        {
            string msj = "La casa de "+Floor+" pisos cuenta con "+Room+" habitaciones y "+Bathroom+" baños en el barrio"+Neighborhood+"";
            return msj;
        }
    }
}