using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RedPointeTimeCapture.Models
{
    public class Admin
    {
        public int ID { get; set; }
        public string AdminName { get; set; }


    }
}
