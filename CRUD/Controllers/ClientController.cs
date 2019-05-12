using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using CRUD.ViewModels;
using Newtonsoft.Json;

namespace CRUD.Controllers
{
    public class ClientController : Controller
    {
        private ModelContext db = new ModelContext();

        //
        // GET: /Client/

        public ActionResult Index()
        {
            List<ClientViewModel> ModelList = new List<ClientViewModel>();
            try
            {
                List<Client> AllData = db.Client.ToList();
                foreach (Client Data in AllData)
                {
                    ClientViewModel NewData = new ClientViewModel();
                    NewData.ID = Data.ID;
                    NewData.FullName = Data.FullName;
                    NewData.Gender = Data.Gender;
                    NewData.DateOfBirth = Data.DateOfBirth;
                    NewData._dateOfBirth = Data.DateOfBirth.ToString("dd MMM yyyy");
                    ModelList.Add(NewData);
                }
            }
            catch
            {
            }

            return View(ModelList.ToList());
        }

        //
        // GET: /Client/Details/5

        public ActionResult Details(int id = 0)
        {
            ClientViewModel model = new ClientViewModel();
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            else
            {
                model.ID = client.ID;
                model.FullName = client.FullName;
                model.Gender = client.Gender;
                model.DateOfBirth = client.DateOfBirth;
                model._dateOfBirth = client.DateOfBirth.ToString("dd MMM yyyy");
            }
            return View(model);
        }

        //
        // GET: /Client/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Client/Create

        [HttpPost]
        public ActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                db.Client.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(client);
        }

        //
        // GET: /Client/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        //
        // POST: /Client/Edit/5

        [HttpPost]
        public ActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(client);
        }

        //
        // GET: /Client/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ClientViewModel model = new ClientViewModel();
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            else
            {
                model.ID = client.ID;
                model.FullName = client.FullName;
                model.Gender = client.Gender;
                model.DateOfBirth = client.DateOfBirth;
                model._dateOfBirth = client.DateOfBirth.ToString("dd MMM yyyy");
            }
            return View(model);
        }

        //
        // POST: /Client/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Client client = db.Client.Find(id);
            db.Client.Remove(client);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}