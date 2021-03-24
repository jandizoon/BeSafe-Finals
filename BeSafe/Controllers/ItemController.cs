using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MyInventory.Data;
using MyInventory.Models;
namespace MyInventory.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Products()
        {
            var list = _context.Items.ToList();
            return View(list);
            
        }

        public IActionResult Create()
        {

            return View();

        }

        [HttpPost]
        public IActionResult Create(Item record)
        {
            var item = new Item();
            item.CompanyName = record.CompanyName;
            item.Code = record.Code;
            item.Address = record.Address;
            item.Representative = record.Representative;
            item.DateAdded = DateTime.Now;
            item.Type = record.Type;

            _context.Items.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Products");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Products");
            }

            var item = _context.Items.Where(i => i.SupplierId == id).SingleOrDefault();
            if (item == null)
            {
                return RedirectToAction("Products");
            }

            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Item record)
        {
            var item = _context.Items.Where(i => i.SupplierId == id).SingleOrDefault();
            item.CompanyName = record.CompanyName;
            item.Code = record.Code;
            item.Address = record.Address;
            item.Representative = record.Representative;
            item.DateModified = DateTime.Now;
            item.Type = record.Type;

            _context.Items.Update(item);
            _context.SaveChanges();

            return RedirectToAction("Products");
        }

        public IActionResult Delete (int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Products");
            }

            var item = _context.Items.Where(i => i.SupplierId == id).SingleOrDefault();
            if (item == null)
            {
                return RedirectToAction("Products");
            }

            _context.Items.Remove(item);
            _context.SaveChanges();

            return RedirectToAction("Products");
        }
    }
}
