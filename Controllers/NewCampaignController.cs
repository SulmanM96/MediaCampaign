using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MediaCampaign.Models;

namespace MediaCampaign.Models
{
    public class NewCampaignController : Controller
    {

        List<Campaign> Table = new List<Campaign>();
        Campaign sul = new Campaign();
        Campaign sul2 = new Campaign();

     
        // GET: Companies in a list
        public ActionResult Index()
        {
            sul.CampaignName1 = "Petersburg";
            sul.CampaignType1 = "TV";
            sul.CompanyName1 = "Tesco";
            sul.EndDate1 = 2018;
            sul.StartDate1 = 2020;

            sul2.CompanyName1 = "";
            return View(sul);
        }

        // GET: NewCampaign/Details/5
        public ActionResult Details(int id)//view db
        {
            return View();
        }

        // GET: NewCampaign/Create
        public ActionResult Create() //new entries
        {
            return View();
        }

        public ActionResult Edit() //new entries
        {
            sul2.CompanyName1 = "";
            return View(sul2.CampaignName1);
        }

       
    }
}
