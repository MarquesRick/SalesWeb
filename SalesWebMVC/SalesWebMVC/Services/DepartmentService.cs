﻿using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        //Previne que a dependencia não possa ser alterada
        private readonly SalesWebMVCContext _context;

        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        //Retornar todos os vendedores do banco de dados
        public async Task<List<Department>> FindAllAsync() //Alterações para tornar a função Asincrona
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync(); //Traz a lista já ordenada por nome
        }
    }
}
