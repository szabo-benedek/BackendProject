﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub.Entity.Dtos.User
{
    public class UserInputDto
    {
        [MinLength(6)]
        public required string UserName { get; set; } = "";
        [MinLength(6)]
        public required string Password { get; set; } = "";


        [MinLength(6)]
        public required string FirstName { get; set; } = "";

        [MinLength(5)]
        public required string LastName { get; set; } = "";
    }
}
