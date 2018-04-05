using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Beaver.Models;

namespace Beaver.Controllers
{
    public class VideosController : Controller
    {
        //create new database context variable
        private ApplicationDbContext _dbContext;

        public VideosController()
        {
            //initialize dbcontext with object
            _dbContext = new ApplicationDbContext();
        }
        // GET: Videos
        public ActionResult Index()
        {
            //storing list of videos in variable using ToList
            var videos = _dbContext.Videos.ToList();
            //pushing list of videos to our view
            return View(videos);
        }
        //add a new video record
        public ActionResult New()
        {
            return View();
        }
        //Add action to save video record
        public ActionResult Add(Video video)
        {
            _dbContext.Videos.Add(video);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");

        }
        //Edit Action
        public ActionResult Edit(int id)
        {
            var video = _dbContext.Videos.SingleOrDefault(v => v.id == id);

            if (video == null)
                return HttpNotFound();

            return View(video);
        }
        //update selected record in the database
        [HttpPost]
        public ActionResult Update(Video video)
        {
            var videoInDb = _dbContext.Videos.SingleOrDefault(v => v.id == video.id);
            //if record not found, show 404 not found page
            if (video == null)
                return HttpNotFound();
            //modify fields if record is found
            videoInDb.title = video.title;
            videoInDb.description = video.description;
            videoInDb.genre = video.genre;
            //save changes in database
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        //delete action
        public ActionResult Delete (int id)
        {
            var video = _dbContext.Videos.SingleOrDefault(v => v.id == id);
            //if record not found, show 404 not found page
            if (video == null)
                return HttpNotFound();

            return View(video);
        }
        //delete action
        [HttpPost]
        public ActionResult DoDelete(int id)
        {
            var video = _dbContext.Videos.SingleOrDefault(v => v.id == id);
            //if record not found, show 404 not found page
            if (video == null)
                return HttpNotFound();
            //call remove on selected record
            _dbContext.Videos.Remove(video);
            //save changes to database
            _dbContext.SaveChanges();
            //return user to Index page
            return RedirectToAction("Index");
        }
    }
}