using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Student Name: 
 * Student Id:
 * Description: This is the Hero Data Container Class
 */
namespace COMP123_s2019_finalTestA.Objects
{
    class Hero
    {
        //Identity
        public string HeroName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Physical Abilities
        public string Fighting { get; set; }
        public string Strength { get; set; }
        public string Agility { get; set; }
        public string Endurance { get; set; }

        //Mental Abilities
        public string Reason { get; set; }
        public string Intuition { get; set; }
        public string Psyche { get; set; }
        public string Popularity { get; set; }
        //public string Strength { get; set; }

        List<Power> Powers;

        Hero()
        {
            Powers = new List<Power>();
        }
    }
}
