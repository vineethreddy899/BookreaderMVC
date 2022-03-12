using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentPageService _commentPageService;

        public CommentController(ICommentPageService commentPageService)
        {
            this._commentPageService = commentPageService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetComments()
        {
            var commentList = await _commentPageService.GetComments();
            return View(commentList);
        }

        public async Task<ActionResult> ViewComment(int id)
        {
            var comment = await _commentPageService.ViewComment(id);
            if (comment == null)
            {
                return RedirectToAction("GetComments");
            }
            return View(comment);
        }

        [HttpPost]
        public async Task<IActionResult> PostComment(CommentModel commentModel)
        {
            var result = await _commentPageService.PostComment(commentModel);
            if (result > 0)
            {
                return RedirectToAction("ViewDetails", "Event", new { id = commentModel.EventId });

            }
            return RedirectToAction("Index", "Home");
        }

    }
}
