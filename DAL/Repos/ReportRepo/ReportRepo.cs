using DAL.Data.Context;
using DAL.Data.Models;
using DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.ReportRepo
{
    public class ReportRepo : GenericRepo<Report>, IReportRepo
    {
        private readonly AppDbContext _appDbContext;
        public ReportRepo(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
