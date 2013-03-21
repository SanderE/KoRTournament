using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoR.Tournament.Entities
{
    public class Player
    {
        public BNetProfile BnetProfile { get; set; }
        public string AccountName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CountryOfOrigin { get; set; }
    }
}