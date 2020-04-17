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
using ProjectAthena.Models.CampaignViewModels;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Data;

namespace ProjectAthena.Controllers
{
    public class CampaignsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        [BindProperty]
        public Campaign Campaign { get; set; }

        public CampaignsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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

        public async Task<IActionResult> Campaigns()
        {
            if (User.Identity.IsAuthenticated)
            {
                var currentUser = await GetCurrentUserAsync();
                ViewBag.UserId = currentUser.Id;
            }

            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Campaign = new Campaign();

            if (id == null)
            {
                //create
                return View(Campaign);
            }

            //update
            Campaign = _context.Campaigns.FirstOrDefault(u => u.Id == id);
            if (Campaign == null)
            {
                return NotFound();
            }
            return View(Campaign);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert()
        {
            var currentUser = await GetCurrentUserAsync();
            //ViewBag.UserId = currentUser.Id;

            if (ModelState.IsValid)
            {
                if (Campaign.Id == 0)
                {
                    Campaign.ManagerId = currentUser.Id;
                    Campaign.StartDate = DateTime.Now;
                    Campaign.CampaignActive = true;
                    _context.Campaigns.Add(Campaign);
                    //_context.SaveChanges();
                }
                else
                {
                    Campaign.ManagerId = currentUser.Id;
                    Campaign.StartDate = DateTime.Now;
                    Campaign.CampaignActive = true;
                    _context.Campaigns.Update(Campaign);
                    //_context.SaveChanges();
                }
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Campaign);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var currentUser = await GetCurrentUserAsync();

            return Json(new { data = await _context.Campaigns.Where(a => a.ManagerId == currentUser.Id).ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var campaignFromDb = await _context.Campaigns.FirstOrDefaultAsync(u => u.Id == id);
            if (campaignFromDb == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });
            }
            _context.Campaigns.Remove(campaignFromDb);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = "Delete Successful" });

        }

        public async Task<IActionResult> ManageCampaignUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaign = await _context.Campaigns.FirstOrDefaultAsync(m => m.Id == id);

            if (campaign == null)
            {
                return NotFound();
            }

            ViewBag.nameOfCampaign = campaign.Name;
            var currentUser = await GetCurrentUserAsync();
            CampaignUserData vm = new CampaignUserData();
            var applicationDbContext = _context.CampaignUsers
                .Include(o => o.ApplicationUser)
                .Where(a => a.CampaignId == id);
            vm.CampaignUsers = applicationDbContext;
            
            return View(vm);
        }

        public async Task<IActionResult> NewCampaignUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaign = await _context.Campaigns.FirstOrDefaultAsync(m => m.Id == id);

            if (campaign == null)
            {
                return NotFound();
            }

            var currentUser = await GetCurrentUserAsync();
            ViewBag.IdCampaign = campaign.Id;
            ViewBag.nameOfCampaign = campaign.Name;
            ViewBag.UserId = currentUser.Id;

            List<Campaign> campaignList = new List<Campaign>();
            campaignList = (from product in _context.Campaigns.Where(a => a.ManagerId == currentUser.Id) select product).ToList();
            ViewBag.ListofCampaigns = campaignList;

            List<ApplicationUser> applicationUserList = new List<ApplicationUser>();
            applicationUserList = (from product in _context.ApplicationUsers select product).ToList();
            ViewBag.ListofUsers = applicationUserList;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewCampaignUser(int CampaignId, string ApplicationUserId)
        {
            var campaign = await _context.Campaigns.FirstOrDefaultAsync(x => x.Id == CampaignId);
            var applicationUser = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == ApplicationUserId);

            CampaignUser campaignUser = new CampaignUser
            {
                Id = applicationUser.Id + campaign.Id,
                CampaignId = campaign.Id,
                CampaignName = campaign.Name,
                ApplicationUserId = applicationUser.Id,
                ApplicationUserFullName = applicationUser.FullName
            };

            if (!CampaignUserExists(campaignUser.Id))
            {
                _context.Add(campaignUser);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> AddUserToCampaign()
        {
            var currentUser = await GetCurrentUserAsync();
            ViewBag.UserId = currentUser.Id;

            List<Campaign> campaignList = new List<Campaign>();
            campaignList = (from product in _context.Campaigns.Where(a => a.ManagerId == currentUser.Id) select product).ToList();
            ViewBag.ListofCampaigns = campaignList;

            List<ApplicationUser> applicationUserList = new List<ApplicationUser>();
            applicationUserList = (from product in _context.ApplicationUsers select product).ToList();
            ViewBag.ListofUsers = applicationUserList;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUserToCampaign(int CampaignId, string ApplicationUserId)
        {
            var campaign = await _context.Campaigns.FirstOrDefaultAsync(x => x.Id == CampaignId);
            var applicationUser = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == ApplicationUserId);

            CampaignUser campaignUser = new CampaignUser
            {
                Id = applicationUser.Id + campaign.Id,
                CampaignId = campaign.Id,
                CampaignName = campaign.Name,
                ApplicationUserId = applicationUser.Id,
                ApplicationUserFullName = applicationUser.FullName
            };

            if (!CampaignUserExists(campaignUser.Id))
            {
                _context.Add(campaignUser);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CampaignUserCountBarGraph(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var currentUser = await GetCurrentUserAsync();

            List<CampaignUser> userCountList = new List<CampaignUser>();
            userCountList = (from x in _context.CampaignUsers
                             .Where(x => x.CampaignId == id) select x)
                             .Where(x => x.Campaign.ManagerId == currentUser.Id)
                             .Where(x => x.ApplicationUser.UserActive == true)
                             .ToList();

            int[] userCount = new int[3];
            userCount[0] = userCountList.Count();
            ViewBag.UserCount = userCount;

            return View();
        }

        public async Task<IActionResult> Dashboard(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaign = await _context.Campaigns.FirstOrDefaultAsync(x => x.Id == id);
            var currentUser = await GetCurrentUserAsync();

            List<CampaignUser> userCountList = new List<CampaignUser>();
            userCountList = (from x in _context.CampaignUsers
                             .Where(x => x.CampaignId == id) select x)
                             .Where(x => x.Campaign.ManagerId == currentUser.Id)
                             .Where(x => x.ApplicationUser.UserActive == true)
                             .ToList();

            int userCount = userCountList.Count();
            ViewBag.userCount = userCount;

            DateTime dt = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            ViewBag.dateTimeWeekStart = dt;

            string[] colNames = new string[10];
            colNames[0] = campaign.DataColumnNumber1Title;
            colNames[1] = campaign.DataColumnNumber2Title;
            colNames[2] = campaign.DataColumnNumber3Title;
            colNames[3] = campaign.DataColumnNumber4Title;
            colNames[4] = campaign.DataColumnNumber5Title;
            colNames[5] = campaign.DataColumnNumber6Title;
            colNames[6] = campaign.DataColumnNumber7Title;
            colNames[7] = campaign.DataColumnNumber8Title;
            colNames[8] = campaign.DataColumnNumber9Title;
            colNames[9] = campaign.DataColumnNumber10Title;
            colNames = colNames.Where(c => c != null).ToArray();
            ViewBag.colNames = colNames;

            List<Report> reportDataList = new List<Report>();
            reportDataList = (from y in _context.Reports
                .Where(y => y.CampaignId == id) select y)
                .Where(y => y.SubmissionDate >= dt)
                .ToList();
            int reportDataCount = reportDataList.Count();
            ViewBag.reportDataCount = reportDataCount;

            int[] reportData = new int[10];
            foreach (Report report in reportDataList)
            {
                reportData[0] += report.DataColumnNumber1;
                reportData[1] += report.DataColumnNumber2;
                reportData[2] += report.DataColumnNumber3;
                reportData[3] += report.DataColumnNumber4;
                reportData[4] += report.DataColumnNumber5;
                reportData[5] += report.DataColumnNumber6;
                reportData[6] += report.DataColumnNumber7;
                reportData[7] += report.DataColumnNumber8;
                reportData[8] += report.DataColumnNumber9;
                reportData[9] += report.DataColumnNumber10;

            }
            ViewBag.reportData = reportData;

            return View();
        }

        private bool CampaignExists(int id)
        {
            return _context.Campaigns.Any(e => e.Id == id);
        }

        private bool CampaignUserExists(string id)
        {
            return _context.CampaignUsers.Any(e => e.Id == id);
        }

    }

}