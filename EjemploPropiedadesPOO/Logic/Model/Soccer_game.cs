using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class Soccer_game
    {
        //Defino las caracteristicas de soccer_game

        private int number_of_players = 11;
        private string game_time = "90 minutos";
        private string equipment = "2 equipos";
        private string gamer_name = "Futbool";

        public int Number_of_players { get => number_of_players; set => number_of_players = value; }
        public string Game_time { get => game_time; set => game_time = value; }
        public string Equipment { get => equipment; set => equipment = value; }
        public string Gamer_name { get => gamer_name; set => gamer_name = value; }

        //defino los metodos
        public string Star()
        {
            string msj = "El juego de " + Gamer_name + " tiene duracion de "+Game_time+" y juegan "+Equipment+" cada equipo tiene "+Number_of_players;
            return msj;
        }
        public string get_game_time()
        {
            string msj = "el juego es de" + Game_time + " y se juegan " + Equipment + "";
            return msj;
        }
        public string get_number_of_players()
        {
            string msj = "y cada equipo tiene "+Number_of_players+" jugadores";
            return msj;
        }





    }
}