using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarz.WebUI.Models.DataContexts;
using Tarz.WebUI.Models.Entities;

namespace Tarz.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandsController : Controller
    {
        readonly TarzDbContext db;
        public BrandsController(TarzDbContext db)
        {
            this.db = db;
        }
        public async  Task <IActionResult> Index()
        {
            var data =await db.Brands.ToListAsync();
            return View(data);
        }

        public  IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Brand model)
        {
            if (ModelState.IsValid)
            {
                db.Brands.Add(model);
               await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           
            return View(model);
        }
        public async Task <IActionResult> Edit(int id)
        {
            if (id <1)
            {
                return NotFound();//404
            }
            var entity = await db.Brands.FirstOrDefaultAsync(b=>b.Id == id);

            if (entity == null)
            {
                return NotFound();//404
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit([FromRoute]int id,Brand model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (id!= model.Id || id < 1)
            {
                return BadRequest();
            }
            var entity = await db.Brands.FirstOrDefaultAsync(b => b.Id == id);

            if (entity == null)
            {
                return NotFound();//404
            }
            entity.Name = model.Name;
            entity.Description = model.Description;

            //db.Brands.Update(entity)
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            
        }
    }
}
