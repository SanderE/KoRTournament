using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KoR.Tournament.Entities;

namespace KoR.Tournament.Backend
{
    public class MockData
    {
        public List<Player> GetPlayers()
        {
            return new List<Player>() { new Player() { AccountName = "Abradix", CountryOfOrigin = "South Korea", FirstName = "Sander", LastName = "Egberink" } };
        }
    }
}