﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LaboratoryPosts.Pages
{   
    [Authorize]
    public class AdministrativePanelModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnGetVizualize(int id)
        {
            return Redirect("/Vizualization");
        }

        public IActionResult OnGetAlterPost(int id)
        {
            return Redirect("/AlterPost");
        }
    }
}