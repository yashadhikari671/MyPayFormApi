﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPayFormApi.Model
{
    public class Form
    {
        [Key]
        public int Id { get; set; }
        public string OrderId { get; set; }
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
        public string TransactionId { get; set; }
        public string PaymentStatus { get; set; }




    }
}
