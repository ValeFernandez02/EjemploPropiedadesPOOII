using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class Soccer_game
    {
        //Defino las caracteristicas de soccer_game

        int number_of_players = 11;
        string game_time = "90 minutos";
        string equipment = "2 equipos";
        string gamer_name = "Futbool";

        //defino los metodos
        public string Star()
        {
            string msj = "El juego de " + gamer_name + " ah iniciado";
            return msj;
        }
        public string get_game_time()
        {
            string msj = "el juego es de" + game_time + " y se juegan " + equipment + "";
            return msj;
        }
        public string get_number_of_players()
        {
            string msj = "y cada equipo tiene "+number_of_players+" jugadores";
            return msj;
        }





    }
}