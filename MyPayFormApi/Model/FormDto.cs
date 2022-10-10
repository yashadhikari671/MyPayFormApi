using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPayFormApi.Model
{
    public class FormDto
    {
       
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Performance_Solo_Group { get; set; }
        public string GroupName { get; set; }
        public int Members { get; set; }
        public string AgeRange { get; set; }
        public string GroupType { get; set; }
        public string ParticipantName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        
    }
}
