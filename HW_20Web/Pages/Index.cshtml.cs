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
        bool IsCollectionCreated;

        public IndexModel()
        {
            IsCollectionCreated = false;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Note Holder";

            if (!IsCollectionCreated)
            {
                NotesCollection dbcollection = new NotesCollection();

                IsCollectionCreated = false;
            }
            
        }
    }
}
