using PROJETO1.Data;
using PROJETO1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO1.Services
{
    public class DepartmentService
    {
        private readonly PROJETO1Context _context;
        public DepartmentService(PROJETO1Context context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
