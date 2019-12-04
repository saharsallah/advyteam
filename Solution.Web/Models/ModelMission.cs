using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution.Web.Models
{
    public class ModelMission
    {

     
        public string Mission1 { get; set; }

        public int id { get; set; }

       
        public string description { get; set; }

        public DateTime? duree { get; set; }

        public employee emp { get; set; }

        public bool? etat { get; set; }

        public string libelle { get; set; }
        public String ImageUrl { get; set; }
        public bool MissionReussit { get; set; }
        public int nbrMissionReussit { get; set; }
        public bool missionNational { get; set; }
        public bool missionInternational { get; set; }
    }
}
