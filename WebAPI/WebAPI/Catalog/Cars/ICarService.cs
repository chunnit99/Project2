using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Catalog.Cars
{
    public interface ICarService
    {
        Task<int> Create(CreateCar request);
        Task<int> Update(EditCar request);
        Task<int> Delete(int id_xe);
        Task<List<CarViewModel>> GetAll();
        Task<PageResult<CarViewModel>> GetAllPaging(GetCarPagingRequest request);
        Task<CarViewModel> GetById(int id_xe);
    }
}
