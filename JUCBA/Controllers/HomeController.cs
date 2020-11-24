using JUCBA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppContext = JUCBA.Core.Models.AppContext;


namespace JUCBA.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private AppContext db;
        private ApplicationDbContext appdb;

        public HomeController()
        {
            db = new AppContext();
            appdb = new ApplicationDbContext();
        }
        public HomeController(AppContext dbParam, ApplicationDbContext appdbParam)
        {
            db = new AppContext();
            appdb = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Index()
        {
            ViewBag.UserCount = appdb.Users.Count();

            ViewBag.CustomerCount = db.Customers.Count();
            ViewBag.CustomerAccountCount = db.CustomerAccounts.Count();

            ViewBag.BranchCount = db.Branches.Count();

            ViewBag.GlAccountCount = db.GlAccounts.Count();
            ViewBag.TransactionCount = db.Transactions.Count();

            int glPostApprovedCount = db.GlPostings.Where(g => g.Status == PostStatus.Approved).Count();
            int glPostPendingCount = db.GlPostings.Where(g => g.Status == PostStatus.Pending).Count();
            int glPostDeclinedCount = db.GlPostings.Where(g => g.Status == PostStatus.Declined).Count();
            ViewBag.GlPostApprovedCount = glPostApprovedCount;
            ViewBag.GlPostPendingCount = glPostPendingCount;

            int tellerPostApprovedCount = db.TellerPostings.Where(t => t.Status == PostStatus.Approved).Count();
            int tellerPostPendingCount = db.TellerPostings.Where(t => t.Status == PostStatus.Pending).Count();
            int tellerPostDeclinedCount = db.TellerPostings.Where(t => t.Status == PostStatus.Declined).Count();
            ViewBag.TellerPostApprovedCount = tellerPostApprovedCount;
            ViewBag.TellerPostPendingCount = tellerPostPendingCount;

            int allPostCount = (glPostApprovedCount + glPostDeclinedCount + glPostPendingCount + tellerPostApprovedCount + tellerPostPendingCount + tellerPostDeclinedCount);
            if(allPostCount!=0)
            { 
            var pendingPercent = (glPostPendingCount + tellerPostPendingCount) * 100 / allPostCount;
            var approvedPercent = (glPostApprovedCount + tellerPostApprovedCount) * 100 / allPostCount;
            var declinedPercent = (glPostDeclinedCount + tellerPostDeclinedCount) * 100 / allPostCount;
            ViewBag.PendingPercent = pendingPercent;
            ViewBag.ApprovedPercent = approvedPercent;
            ViewBag.DeclinedPercent = declinedPercent;
            }
            else
            {
                ViewBag.PendingPercent = 0;
                ViewBag.ApprovedPercent = 0;
                ViewBag.DeclinedPercent = 0;
            }
            if (Request.IsAuthenticated)
            {
                return View();
            }
            else
            {
               return RedirectToAction("Login", "Account");
            }
        }


        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}