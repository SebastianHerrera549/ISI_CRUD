﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ISI_CRUD.Models;
using System.Data.SqlClient;
using System.Data.Entity;

namespace ISI_CRUD.Controllers
{
    public class SalesByCategory : Controller
    {

        //GET: vista “Sales By Category”
        public IActionResult Index()
        {

           return View();
        } 
        


    }
}
