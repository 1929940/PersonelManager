using API.Core.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.HR.Logic {
    public class DocumentContextManager<T> where T : class {
        private readonly Context _context;
        private readonly DbSet<T> _set;

        public DocumentContextManager(Context context) {
            _context = context;
            _set = context.Set<T>();
        }

        public DbSet<T> GetSet() => _set;
    }

}
