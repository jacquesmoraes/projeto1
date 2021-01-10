using PROJETO1.Data;
using PROJETO1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO1.Services
{
    public class SellerService
    {
        private readonly PROJETO1Context _context;
        public SellerService(PROJETO1Context context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }


    }
}
