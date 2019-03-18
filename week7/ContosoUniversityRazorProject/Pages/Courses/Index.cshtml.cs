using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversityRazorProject.Models;

namespace ContosoUniversityRazorProject.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ContosoUniversityRazorProject.Models.SchoolContext _context;

        public IndexModel(ContosoUniversityRazorProject.Models.SchoolContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Courses
                .Include(c => c.Department)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
