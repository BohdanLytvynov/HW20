using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ORM_Core;
using System.Diagnostics;

namespace HW_20Web.Pages
{
    public class IndexModel : PageModel
    {
        private bool IsCollectionCreated;

        protected NotesCollection dbcollection;

        public IndexModel()
        {
            IsCollectionCreated = false;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Note Holder";

            if (!IsCollectionCreated)
            {
                dbcollection = new NotesCollection();

                ViewData.Add("Get", new Func<IQueryable<Notes>>(GetNotes));

                IsCollectionCreated = false;
            }
                        
        }

        

        public IQueryable<Notes> GetNotes()
        {
            var res = from n in dbcollection.Notes
                      select n;

            return res;
        }
    }
}
