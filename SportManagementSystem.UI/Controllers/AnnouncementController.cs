using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using SportManagementSystem.Data.DataContext;
using SportManagementSystem.Data.DbModels;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace SportManagementSystem.UI.Controllers
{
    public class AnnouncementController : Controller
    {

        private readonly UdemySportManagementSystemContext _db;

        public AnnouncementController(UdemySportManagementSystemContext db)
        {
            _db = db;
        }
        public IActionResult Index()
    {
            List<Announcement> announcements = _db.Announcement.OrderByDescending(x=>x.Id).ToList();
            Dictionary<string,string> announcementTitles = new Dictionary<string, string>();
            foreach (var announcement in announcements)
            {
                HtmlWeb web = new HtmlWeb();
                web.OverrideEncoding = Encoding.GetEncoding("ISO-8859-9");

                HtmlDocument doc = web.Load(announcement.Explanation.ToString());

                string duyuruBasligi = doc.DocumentNode.SelectSingleNode("//title").InnerText;
                announcementTitles.Add(duyuruBasligi, announcement.Explanation.ToString());
            }

            ViewBag.AnnouncementTitles = announcementTitles;
            return View();
    }

    public IActionResult DuyuruDetay()
        {
            // Duyuru detay sayfasının işlemleri burada yapılır
            // Örneğin, duyurunun olduğu linkteki detay sayfasını göstermek için gerekli kodları ekleyebilirsiniz

            return View();
        }

        private string GetHtmlContent(string url)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }
        [HttpPost]
        public IActionResult Add(string url)
        {
            Announcement newAnnouncement = new Announcement()
            {
                Explanation = url
            };

            _db.Announcement.Add(newAnnouncement);
            _db.SaveChanges();


            return Ok(); // Başarılı yanıt döndür
        }
    }
}
