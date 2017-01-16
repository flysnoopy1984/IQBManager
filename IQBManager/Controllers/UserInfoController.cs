using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IQBManager.Models;

namespace IQBManager.Controllers
{
    public class UserInfoController : Controller
    {
        private QBDbContext db = new QBDbContext();

        // GET: UserInfo
        public ActionResult Index()
        {
            var users = from u in db.UserInfoList  select u;
                        
            return View(users.ToList());
        }

        // GET: UserInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserInfoModel userInfoModel = db.UserInfoList.Find(id);
            if (userInfoModel == null)
            {
                return HttpNotFound();
            }
            return View(userInfoModel);
        }

        // GET: UserInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserInfo/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UserNo,Name,LoginID,Pwd,IdentityCard")] UserInfoModel userInfoModel)
        {
            if (ModelState.IsValid)
            {
                userInfoModel.RegDatetime = DateTime.Now;
                db.UserInfoList.Add(userInfoModel);
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }

            return View(userInfoModel);
        }

        // GET: UserInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserInfoModel userInfoModel = db.UserInfoList.Find(id);
            if (userInfoModel == null)
            {
                return HttpNotFound();
            }
            return View(userInfoModel);
        }

        // POST: UserInfo/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UserNo,Name,LoginID,Pwd,IdentityCard")] UserInfoModel userInfoModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userInfoModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userInfoModel);
        }

        // GET: UserInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserInfoModel userInfoModel = db.UserInfoList.Find(id);
            if (userInfoModel == null)
            {
                return HttpNotFound();
            }
            return View(userInfoModel);
        }

        // POST: UserInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserInfoModel userInfoModel = db.UserInfoList.Find(id);
            db.UserInfoList.Remove(userInfoModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
