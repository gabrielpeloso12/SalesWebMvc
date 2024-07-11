﻿using System.Linq;
using System.Collections.Generic;
using SalesWebMvc.Models;
using SalesWebMvc.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentsService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentsService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Departments> >FindAllAsync()
        {
            return await _context.Departments.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
