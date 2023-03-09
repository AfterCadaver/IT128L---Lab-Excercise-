using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogDataLibrary.Data;
using BlogDataLibrary.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace BlogDataLibrary.Models
{
    public class UserLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }


}
