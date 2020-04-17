using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAthena.Data;
using ProjectAthena.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ProjectAthena.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        [BindProperty]
        public Report Report { get; set; }

        public ReportsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Reports()
        {
            var currentUser = await GetCurrentUserAsync();
            ViewBag.UserId = currentUser.Id;

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Upsert(int? id)
        {
            Report = new Report();

            var currentUser = await GetCurrentUserAsync();

            List<CampaignUser> myCampaigns = new List<CampaignUser>();
            myCampaigns = (from x in _context.CampaignUsers.Where(a => a.ApplicationUserId == currentUser.Id) select x).ToList();
            ViewBag.UserReportsList = myCampaigns;

            if (id == null)
            {
                //create
                return View(Report);
            }

            //update
            Report = _context.Reports.FirstOrDefault(u => u.Id == id);
            if (Report == null)
            {
                return NotFound();
            }

            return View(Report);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(int CampaignId)
        {
            var currentUser = await GetCurrentUserAsync();
            var campaign = await _context.Campaigns.FirstOrDefaultAsync(x => x.Id == CampaignId);

            if (ModelState.IsValid)
            {
                if (Report.Id == 0)
                {
                    Report.ManagerId = currentUser.ManagerID;
                    Report.SubmissionDate = DateTime.Now;
                    Report.ApplicationUserId = currentUser.Id;
                    Report.ApplicationUserName = currentUser.FullName;
                    Report.CampaignId = CampaignId;
                    Report.CampaignName = campaign.Name;
                    _context.Reports.Add(Report);
                }
                else
                {
                    Report.ManagerId = currentUser.ManagerID;
                    Report.LastEditDate = DateTime.Now;
                    Report.ApplicationUserId = currentUser.Id;
                    Report.ApplicationUserName = currentUser.FullName;
                    Report.CampaignId = CampaignId;
                    Report.CampaignName = campaign.Name;
                    _context.Reports.Update(Report);
                }
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Report);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var currentUser = await GetCurrentUserAsync();

            return Json(new { data = await _context.Reports.Where(a => a.ApplicationUserId == currentUser.Id).ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var reportFromDb = await _context.Reports.FirstOrDefaultAsync(u => u.Id == id);
            if (reportFromDb == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });
            }
            _context.Reports.Remove(reportFromDb);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = "Delete Successful" });

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var report = await _context.Reports.FirstOrDefaultAsync(x => x.Id == id);
            var currentUser = await GetCurrentUserAsync();
            
            if (report.ApplicationUserId == currentUser.Id)
            {
                return View(report);
            }
            else
            {
                return NotFound();
            }

        }

    }
}