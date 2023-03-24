using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class house
    {
        private int room ;
        private string neighborhood ;
        private int bathroom ;
        private int floor ;

        public house(int room, string neighborhood, int bathroom, int floor)
        {
            this.room = room;
            this.neighborhood = neighborhood;
            this.bathroom = bathroom;
            this.floor = floor;
        }

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