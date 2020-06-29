using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ultilities;
using WebAPI.Catalog.Drivers.Dtos;
using WebAPI.Models;
using System.Collections.Immutable;
using System.Security.Cryptography.Xml;

namespace WebAPI.Catalog
{
    public class ManageDriverService : IUserService
    {
        private readonly AuthenticationContext _context;
        public ManageDriverService(AuthenticationContext context)
        {
            _context = context;
        }
        public async Task<int> Create(CreateDriver request)
        {
            var driver = new Lst_LaiXe()
            {
                id_lg_xe=request.id_lg_xe,
                ten_lai_xe = request.ten_lai_xe,
                gioi_tinh=request.gioi_tinh,
                so_dien_thoai=request.so_dien_thoai,
                id_RFID=request.id_RFID,
                avatar=request.avatar,
                nghi_viec=request.nghi_viec,
                ten_donvi=request.ten_donvi,
                email=request.email
            };
            _context.Lst_LaiXe.Add(driver);
             await _context.SaveChangesAsync();
            return driver.id_lg_xe;
        }

        public async Task<int> Delete(int id_lg_xe)
        {
            var driver = await _context.Lst_LaiXe.FindAsync(id_lg_xe);
            if (driver == null) throw new ExceptionId($"Cannot find a driver: {id_lg_xe}");
            _context.Lst_LaiXe.Remove(driver);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<DriverViewModel>> GetAll()
        {
            var query = from dri in _context.Lst_LaiXe
                        select dri;
            var data = await query
                .Select(x => new DriverViewModel()
                {
                    id_lg_xe = x.id_lg_xe,
                    ten_lai_xe = x.ten_lai_xe,
                    gioi_tinh = x.gioi_tinh,
                    so_dien_thoai = x.so_dien_thoai,
                    id_RFID = x.id_RFID,
                    nghi_viec = x.nghi_viec,
                    avatar = x.avatar,
                    email = x.email,
                    ten_donvi = x.ten_donvi
                }
                ).ToListAsync();
            return data;
        }

        

        public async Task<PageResult<DriverViewModel>> GetAllPaging(GetDriverPagingRequest request)
        {
            var query = from dri in _context.Lst_LaiXe
                        select dri;
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.ten_lai_xe.Contains(request.Keyword));
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .Select(x => new DriverViewModel()
                {
                  id_lg_xe=x.id_lg_xe,
                  ten_lai_xe=x.ten_lai_xe,
                  gioi_tinh=x.gioi_tinh,
                  so_dien_thoai =x.so_dien_thoai,
                  id_RFID=x.id_RFID,
                  nghi_viec=x.nghi_viec,
                  avatar=x.avatar,
                  email=x.email,
                  ten_donvi=x.ten_donvi
                }
                ).ToListAsync();
            var pageResult = new PageResult<DriverViewModel>()
            {
                TotalRecord = totalRow,
                Items = data,
            };
            return pageResult;
        }

        public Task<DriverViewModel> GetById(int id_lg_xe)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(EditDriver request)
        {
            var driver = await _context.Lst_LaiXe.FindAsync(request.id_lg_xe);
            if (driver == null) throw new ExceptionId($"Cannot find a driver with id: {request.id_lg_xe}");
            driver.id_lg_xe = request.id_lg_xe;
            driver.ten_lai_xe = request.ten_lai_xe;
            driver.gioi_tinh = request.gioi_tinh;
            driver.so_dien_thoai = request.so_dien_thoai;
            driver.id_RFID = request.id_RFID;
            driver.nghi_viec = request.nghi_viec;
            driver.avatar = request.avatar;
            driver.email = request.email;
            driver.ten_donvi = request.ten_donvi;
            return await _context.SaveChangesAsync();
                
        }
    }
}

