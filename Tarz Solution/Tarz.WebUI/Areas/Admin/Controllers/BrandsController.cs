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
            var data =await db.Brands
                .Where(b => b.DeletedDate == null)
                .ToListAsync();

            return View(data);
        }
        public async Task<IActionResult>Details(int id)
        {
            if (id < 1)
            {
                return NotFound();//404
            }
            var entity = await db.Brands.FirstOrDefaultAsync(b => b.Id == id && b.DeletedDate == null);

            if (entity == null)
            {
                return NotFound();//404
            }

            return View(entity);
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
            var entity = await db.Brands.FirstOrDefaultAsync(b=>b.Id == id && b.DeletedDate == null);

            if (entity == null)
            {
                return NotFound();//404
            }

            return View(entity);
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
            var entity = await db.Brands.FirstOrDefaultAsync(b => b.Id == id && b.DeletedDate == null);

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
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            throw new Exception("erorrrrr");
            if (id < 1)
            {
                return Json(new
                {
                    error=true,
                    message = "Məlumat tapılmadı"
                });
            }
            var entity = await db.Brands.FirstOrDefaultAsync(b => b.Id == id && b.DeletedDate == null);

            if (entity == null)
                return Json(new
                {
                    error = true,
                    message = "Məlumat tapılmadı"
                });
            entity.DeletedDate = DateTime.UtcNow.AddHours(4);
           await db.SaveChangesAsync();

            return Json(new
            {
                error = false,
                message = "Məlumat silindi"
            });
        }
    }
}
