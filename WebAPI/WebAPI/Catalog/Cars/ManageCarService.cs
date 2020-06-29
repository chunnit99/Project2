using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ultilities;
using WebAPI.Models;

namespace WebAPI.Catalog.Cars
{
    public class ManageCarService : ICarService
    {

        private readonly AuthenticationContext _context;
        public ManageCarService(AuthenticationContext context)
        {
            _context = context;
        }
        public async Task<int> Create(CreateCar request)
        {
            var car = new Lst_Xe()
            {
               id_xe=request.id_xe,
               bien_kiem_soat=request.bien_kiem_soat,
               id_lai_xe_chinh=request.id_lai_xe_chinh,
               loai_xe=request.loai_xe,
               RFID_id=request.RFID_id,
               loai_nhien_lieu=request.loai_nhien_lieu,
               van_toc_gioi_han=request.van_toc_gioi_han,
               so_luong_camera=request.so_luong_camera
            };
            _context.Lst_Xe.Add(car);
            await _context.SaveChangesAsync();
            return car.id_xe;
        }

        public async Task<int> Delete(int id_xe)
        {
            var car = await _context.Lst_Xe.FindAsync(id_xe);
            if (car == null) throw new ExceptionId($"Cannot find a driver: {id_xe}");
            _context.Lst_Xe.Remove(car);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<CarViewModel>> GetAll()
        {
            var query = from car in _context.Lst_Xe
                        select car;
            var data = await query
                .Select(x => new CarViewModel()
                {
                    id_xe = x.id_xe,
                    bien_kiem_soat = x.bien_kiem_soat,
                    id_lai_xe_chinh = x.id_lai_xe_chinh,
                    loai_xe = x.loai_xe,
                    RFID_id = x.RFID_id,
                    loai_nhien_lieu = x.loai_nhien_lieu,
                    van_toc_gioi_han = x.van_toc_gioi_han,
                    so_luong_camera = x.so_luong_camera
                }
                ).ToListAsync();
            return data;
        }

        public async Task<PageResult<CarViewModel>> GetAllPaging(GetCarPagingRequest request)
        {
            var query = from dri in _context.Lst_Xe
                        select dri;
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.bien_kiem_soat.Contains(request.Keyword));
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .Select(x => new CarViewModel()
                {
                    id_xe = x.id_xe,
                    bien_kiem_soat = x.bien_kiem_soat,
                    id_lai_xe_chinh = x.id_lai_xe_chinh,
                    loai_xe = x.loai_xe,
                    RFID_id = x.RFID_id,
                    loai_nhien_lieu = x.loai_nhien_lieu,
                    van_toc_gioi_han = x.van_toc_gioi_han,
                    so_luong_camera = x.so_luong_camera
                }
                ).ToListAsync();
            var pageResult = new PageResult<CarViewModel>()
            {
                TotalRecord = totalRow,
                Items = data,
            };
            return pageResult;
        }

        public async Task<CarViewModel> GetById(int id_xe)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(EditCar request)
        {
            var car = await _context.Lst_Xe.FindAsync(request.id_xe);
            if (car == null) throw new ExceptionId($"Cannot find a car with id: {request.id_xe}");
            car.id_xe = request.id_xe;
            car.bien_kiem_soat = request.bien_kiem_soat;
            car.id_lai_xe_chinh = request.id_lai_xe_chinh;
            car.loai_xe = request.loai_xe;
            car.RFID_id = request.RFID_id;
            car.loai_nhien_lieu = request.loai_nhien_lieu;
            car.van_toc_gioi_han = request.van_toc_gioi_han;
            car.so_luong_camera = request.so_luong_camera;
            return await _context.SaveChangesAsync();
        }
    }
}
