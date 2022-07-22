using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using  STW_DevExpress_Demo.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace  STW_DevExpress_Demo.Controllers
{

    [Route("api/[controller]")]
    public class SparkDataController : Controller
    {
        private readonly SparkContext db;
        public SparkDataController(SparkContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public object Get()
        {
            var data = db.ServiceTypes.ToList();

            return data;

        }
        
    }
}