using System;

namespace SkillabWeb.Models
{
    public class Employee
    {

        public int id { get; set; }
        public string fullname { get; set; }
        public DateTime birthdate { get; set; }
        public string job { get; set; }
        public string hobby { get; set; }
        public string favouritepicturelink { get; set; }
    }
}
