using Microsoft.AspNetCore.Mvc;
using PROJECT_CVRDE_FINAL.Models;
using System.Collections.Generic;

namespace PROJECT_CVRDE_FINAL.Controllers
{
    public class ComplaintController : Controller
    {
        public IActionResult Index()
        {
            Complaint complaint = new Complaint();
            List<Complaint> list = complaint.GetAllComplaints();

            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Complaint c)
        {
            c.InsertComplaint();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Complaint complaint = new Complaint();

            Complaint c = complaint.GetComplaintById(id);

            return View(c);
        }

        public IActionResult Edit(int id)
        {
            Complaint complaint = new Complaint();

            Complaint c = complaint.GetComplaintById(id);

            return View(c);
        }

        [HttpPost]
        public IActionResult Edit(Complaint c)
        {
            c.UpdateComplaint();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Complaint complaint = new Complaint();

            Complaint c = complaint.GetComplaintById(id);

            return View(c);
        }

        [HttpPost]
        public IActionResult Delete(Complaint c)
        {
            c.DeleteComplaint();

            return RedirectToAction("Index");
        }

        public IActionResult Search(string search)
        {
            Complaint complaint = new Complaint();

            List<Complaint> list = complaint.SearchComplaint(search);

            return View("Index", list);
        }

        public IActionResult Filter(string status)
        {
            Complaint complaint = new Complaint();

            List<Complaint> list;

            if (string.IsNullOrEmpty(status))
            {
                list = complaint.GetAllComplaints();
            }
            else
            {
                list = complaint.FilterComplaint(status);
            }

            return View("Index", list);
        }

        public IActionResult FilterByType(string type)
        {
            Complaint complaint = new Complaint();

            List<Complaint> list;

            if (string.IsNullOrEmpty(type))
            {
                list = complaint.GetAllComplaints();
            }
            else
            {
                list = complaint.FilterComplaintByType(type);
            }

            return View("Index", list);
        }

        public IActionResult Dashboard()
        {
            Complaint complaint = new Complaint();

            ViewBag.Total = complaint.GetCount("SELECT COUNT(*) FROM complaints");
            ViewBag.Open = complaint.GetCount("SELECT COUNT(*) FROM complaints WHERE Status='Open'");
            ViewBag.InProgress = complaint.GetCount("SELECT COUNT(*) FROM complaints WHERE Status='In Progress'");
            ViewBag.Resolved = complaint.GetCount("SELECT COUNT(*) FROM complaints WHERE Status='Resolved'");
            ViewBag.High = complaint.GetCount("SELECT COUNT(*) FROM complaints WHERE Priority='High'");
            ViewBag.Medium = complaint.GetCount("SELECT COUNT(*) FROM complaints WHERE Priority='Medium'");
            ViewBag.Low = complaint.GetCount("SELECT COUNT(*) FROM complaints WHERE Priority='Low'");
            ViewBag.Computer = complaint.GetCount("SELECT COUNT(*) FROM complaints WHERE ComplaintType='Computer Error'");
            ViewBag.Network = complaint.GetCount("SELECT COUNT(*) FROM complaints WHERE ComplaintType='Network Error'");

            return View();
        }
    }
}