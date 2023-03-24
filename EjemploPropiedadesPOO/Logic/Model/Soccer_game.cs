using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class Soccer_game
    {
        //Defino las caracteristicas de soccer_game

        private int number_of_players;
        private string game_time ;
        private string equipment;
        private string gamer_name;

        public Soccer_game(int number_of_players, string game_time, string equipment, string gamer_name)
        {
            this.number_of_players = number_of_players;
            this.game_time = game_time;
            this.equipment = equipment;
            this.gamer_name = gamer_name;
        }

        public int Number_of_players { get => number_of_players; set => number_of_players = value; }
        public string Game_time { get => game_time; set => game_time = value; }
        public string Equipment { get => equipment; set => equipment = value; }
        public string Gamer_name { get => gamer_name; set => gamer_name = value; }

        //defino los metodos
        public string Star()
        {
            string msj = "El juego de " + Gamer_name + " tiene duracion de "+Game_time+" y juegan "+Equipment+" Equipos"+" cada equipo tiene "+Number_of_players;
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