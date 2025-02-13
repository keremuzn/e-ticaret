﻿using And.Eticaret.Core.Model;
using And.Eticaret.UI.WEB.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace And.Eticaret.UI.WEB.Controllers
{
    public class CategoryController : AndControllerBase
    {
        AndDB db = new AndDB();
        // GET: Category
        [Route("Kategori/{isim}/{id}")]
        public ActionResult Index(string isim, int id)
        {
            var categoryProduct = db.Products.Where(x => x.IsActive == true && x.CategoryID == id).ToList();
            ViewBag.category = db.Categories.Where(x => x.ID == id).FirstOrDefault();
            return View(categoryProduct);
        }

    }
}