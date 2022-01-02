using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ORM_Core;

namespace HW_20Web.Pages
{
    public class InfoModel : PageModel
    {
        ORM_Core.NotesCollection col;

        public void OnGet()
        {
            string [] req = Request.QueryString.Value.Split('=');

            col = new NotesCollection();

            ViewData.Add("Res", GetNoteAccordToId(Convert.ToInt32(req[1])));
        }

        public IQueryable<Notes> GetNoteAccordToId(int id)
        {
            return  from n in col.Notes
                      where n.Id == id
                      select n;            
        }

    }
}
