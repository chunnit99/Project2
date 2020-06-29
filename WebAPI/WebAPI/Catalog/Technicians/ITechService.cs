using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Catalog.Technicians
{
   public interface ITechService
    {
        Task<int> Create(CreateTech request);
        Task<int> Update(EditTech request);
        Task<int> Delete(int id_ktv);
        Task<List<TechViewModel>> GetAll();
        Task<PageResult<TechViewModel>> GetAllPaging(GetTechPagingRequest request);
        Task<TechViewModel> GetById(int id_ktv);
    }
}
