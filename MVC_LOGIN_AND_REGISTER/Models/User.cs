﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_LOGIN_AND_REGISTER.Models
{
    public class User
    {
        [Key]

        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }


    }
}