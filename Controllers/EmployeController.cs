using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TpGl2021Core.Models;

namespace exposerReact2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        private readonly CoreContext _context;

        public EmployeController(CoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public JsonResult list()
        {
            return new JsonResult( _context.employes.ToList());
        }
           


        [HttpPost]
        public JsonResult Create([Bind("Name,Age,State,Country")] Employe employe)
        {
          
                _context.Add(employe);
                 _context.SaveChanges();
            return new JsonResult("employé créé");

        }

        [HttpPost("{id}")]
        public JsonResult Edit(int id, [Bind("EmployeeID,Name,Age,State,Country")] Employe employe)
        {
            if (id ==employe.EmployeeID)
            {
                _context.Update(employe);
                _context.SaveChanges();
                return new JsonResult("employé Modifié");
            }
            else
            {
                return new JsonResult("employé introuvable");

            }

        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            var employe =  _context.employes.Find(id);
            _context.employes.Remove(employe);
             _context.SaveChanges();
            return new JsonResult("employé supprimé");
        }
    }
}
