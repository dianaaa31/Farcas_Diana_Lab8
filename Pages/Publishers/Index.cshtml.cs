﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Farcas_Diana_Lab8.Data;
using Farcas_Diana_Lab8.Models;

namespace Farcas_Diana_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Farcas_Diana_Lab8.Data.Farcas_Diana_Lab8Context _context;

        public IndexModel(Farcas_Diana_Lab8.Data.Farcas_Diana_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
