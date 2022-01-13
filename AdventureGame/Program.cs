using System;

namespace AdventureGame
{
    class Program
    {
        private static Model model;

        static void Main(string[] args)
        {
            model = new Model();
            while (true)
            {
                UpdateView();
                Console.Write("Angi kommando: ");
                var command = Console.ReadLine();
                //if(command.StartsWith("Låse opp")) 
                //if(command.StartsWith("Gå gjennom")) 
            }
        }

        static void UpdateView()
        {
            var player = model.player;
            var room = player.room;
            var headerText = room.vunnet
                ? "Gratulerer - du har fullført spillet! :-)"
                : $"Du er i rom {room.navn}";
            Console.WriteLine(
                $"{headerText}\n\nI rommet ser du:{room.hentInnhold()}\n\n" +
                $"Du har:{player.inventory()}\n\nDører:\n{model.Doors()}");
        }
    }
}


/* Siste delen av oppgaven er ikke ferdig enda. 
Referer til punkt 3 i oppgaven: Siste skritt er å ta i mot kommandoer og implementere controller-funksjonene for å plukke opp nøkler, låse opp dører og gå gjennom dører. 
Dette er foreløpig ikke dekket av løsningsforslaget, og det er helt ok å hoppe over denne biten. */