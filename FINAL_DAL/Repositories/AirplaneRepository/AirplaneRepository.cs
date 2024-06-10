using FINAL_DAL.Models;
using FINAL_DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_DAL.Repositories.AirplaneRepository
{
    public class AirplaneRepository : GenericRepository<Airplane> , IAirplaneRepository
    {
        public AirplaneRepository(AirplaneSystemContext AirplaneSystemContext) : base(AirplaneSystemContext)
        {
        }
    }
}
