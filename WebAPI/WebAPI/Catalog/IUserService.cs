using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Catalog.Drivers.Dtos;

namespace WebAPI.Catalog
{
    public interface IUserService
    {
        Task<int> Create(CreateDriver request);
        Task<int> Update(EditDriver request);
        Task<int> Delete(int id_lg_xe);
        Task<List<DriverViewModel>> GetAll();
        Task<PageResult<DriverViewModel>> GetAllPaging(GetDriverPagingRequest request);
        Task<DriverViewModel> GetById(int id_lg_xe);
    }
}
