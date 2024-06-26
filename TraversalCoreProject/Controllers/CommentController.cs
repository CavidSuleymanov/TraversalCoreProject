using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]

    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }


        [HttpPost]
        public IActionResult AddComment(Comment c)
        {
            c.CommentDate = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            c.CommentState = true;
            _commentService.TAdd(c);
            return RedirectToAction("Index","Destination");
        }
    }
}
