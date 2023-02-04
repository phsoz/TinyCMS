using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TinyCMS.Domain.Entities;
using TinyCMS.Infrastructure.Persistence;

namespace TinyCMS.Web.Controllers
{
    public class PostCommentsController : Controller
    {
        private readonly TinyDatabaseContext _context;

        public PostCommentsController(TinyDatabaseContext context)
        {
            _context = context;
        }

        // GET: PostComments
        public async Task<IActionResult> Index()
        {
            var tinyDatabaseContext = _context.PostComments.Include(p => p.ParentComment).Include(p => p.Post);
            return View(await tinyDatabaseContext.ToListAsync());
        }

        // GET: PostComments/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.PostComments == null)
            {
                return NotFound();
            }

            var postComment = await _context.PostComments
                .Include(p => p.ParentComment)
                .Include(p => p.Post)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postComment == null)
            {
                return NotFound();
            }

            return View(postComment);
        }

        // GET: PostComments/Create
        public IActionResult Create()
        {
            ViewData["ParentId"] = new SelectList(_context.PostComments, "Id", "Id");
            ViewData["PostId"] = new SelectList(_context.Posts, "Id", "Id");
            return View();
        }

        // POST: PostComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,ParentId,Title,Published,PublishedAt,Content,Id,CreatedBy,ModifiedBy,CreatedDate,ModifiedDate")] PostComment postComment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(postComment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ParentId"] = new SelectList(_context.PostComments, "Id", "Id", postComment.ParentId);
            ViewData["PostId"] = new SelectList(_context.Posts, "Id", "Id", postComment.PostId);
            return View(postComment);
        }

        // GET: PostComments/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.PostComments == null)
            {
                return NotFound();
            }

            var postComment = await _context.PostComments.FindAsync(id);
            if (postComment == null)
            {
                return NotFound();
            }
            ViewData["ParentId"] = new SelectList(_context.PostComments, "Id", "Id", postComment.ParentId);
            ViewData["PostId"] = new SelectList(_context.Posts, "Id", "Id", postComment.PostId);
            return View(postComment);
        }

        // POST: PostComments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("PostId,ParentId,Title,Published,PublishedAt,Content,Id,CreatedBy,ModifiedBy,CreatedDate,ModifiedDate")] PostComment postComment)
        {
            if (id != postComment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postComment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostCommentExists(postComment.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ParentId"] = new SelectList(_context.PostComments, "Id", "Id", postComment.ParentId);
            ViewData["PostId"] = new SelectList(_context.Posts, "Id", "Id", postComment.PostId);
            return View(postComment);
        }

        // GET: PostComments/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.PostComments == null)
            {
                return NotFound();
            }

            var postComment = await _context.PostComments
                .Include(p => p.ParentComment)
                .Include(p => p.Post)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postComment == null)
            {
                return NotFound();
            }

            return View(postComment);
        }

        // POST: PostComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.PostComments == null)
            {
                return Problem("Entity set 'TinyDatabaseContext.PostComments'  is null.");
            }
            var postComment = await _context.PostComments.FindAsync(id);
            if (postComment != null)
            {
                _context.PostComments.Remove(postComment);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostCommentExists(long id)
        {
          return (_context.PostComments?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
