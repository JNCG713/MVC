using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasic_Clone.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PassViewData()
        {
            ViewData["Name"]="Kevin";//儲存字串
            ViewData["Age"] = 33;//儲存整數
            ViewData["Single"] = true;//儲存布林值
            return View();
        }

        public ActionResult PassViewBag()
        {
            ViewBag.NickName = "Mary";
            ViewBag.Height = 168;
            ViewBag.Weight = 52;
            ViewBag.Married = false;
            return View();
        }

        public ActionResult PetShop()
        {
            ViewData["Company"] = "汪星人寵物店";
            ViewBag.Address = "台北市信義區松山路100號";
            
            List<string> PetList = new List<string>();
            PetList.Add("狗");
            PetList.Add("貓");
            PetList.Add("魚");
            PetList.Add("鼠");
            PetList.Add("變色龍");
            ViewData.Model = PetList;

            return View();
            // return View(PetList);
        }
        public ActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "無足夠權限存取系統資料，請聯絡系統管理人員";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();
            return RedirectToAction("Error Message", "ErrorHandler");
        }
    }
}