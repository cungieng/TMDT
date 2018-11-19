using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using c2cWebsite.Models;
using System.Data.Entity.Validation;
namespace c2cWebsite.Controllers
{
    public class TaiKhoanController : Controller
    {
        
        // GET: TaiKhoan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult dangky()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult dangky([Bind(Include = "username,password,email,hoten,ngaysinh,sodienthoai,gioitinh,diachi,salt")] customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (c2cwebsiteEntities db = new c2cwebsiteEntities()){
                        db.customers.Add(customer);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        ModelState.AddModelError("", "Property:" + validationError.PropertyName + " Error:" + validationError.ErrorMessage);
                    }
                }
            }
            catch (DataException dex)
            {
                ModelState.AddModelError("", "Data Exception: "+dex.InnerException);
            }
            return View(customer);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult dangnhap(customer objCustomer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Console.WriteLine("Model is valid");
                    using (c2cwebsiteEntities db = new c2cwebsiteEntities())
                    {
                        var obj = db.customers.Where(a => a.username.Equals(objCustomer.username) && a.password.Equals(objCustomer.password)).FirstOrDefault();
                        if (obj != null)
                        {
                            Console.WriteLine("Da dang nhap");
                            Session["CustomerID"] = obj.customer_id.ToString();
                            Session["Username"] = obj.username.ToString();
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            throw new Exception("Tên tài khoản hoặc mật khẩu không đúng");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("",e.Message);
            }
            

            return View("Index");
        }


    }
}