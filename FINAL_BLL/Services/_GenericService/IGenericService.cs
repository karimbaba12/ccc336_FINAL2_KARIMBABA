using FINAL_BLL.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Services._GenericService
{
    public interface IGenericService<Dto> where Dto : class
    {
        ApiResponse<IEnumerable<Dto>> GetAll();

        ApiResponse<Dto> GetById(int id);
        ApiResponse<Dto> Add(Dto Pilot);
        ApiResponse<Dto> Update(Dto Pilot);
        ApiResponse<bool> Delete(int id);
        ApiResponse<bool> Delete(Dto Pilot);
    }
}
