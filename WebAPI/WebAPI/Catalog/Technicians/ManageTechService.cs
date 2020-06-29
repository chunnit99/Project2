using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ultilities;
using WebAPI.Models;

namespace WebAPI.Catalog.Technicians
{
    public class ManageTechService : ITechService
    {

        private readonly AuthenticationContext _context;
        public ManageTechService(AuthenticationContext context)
        {
            _context = context;
        }
        public async Task<int> Create(CreateTech request)
        {
            var tech = new Lst_KiThuatVien()
            {
                id_ktv=request.id_ktv,
                ten_ktv=request.ten_ktv,
                RFID_id=request.RFID_id,
                so_dien_thoai=request.so_dien_thoai,
                dia_chi=request.dia_chi,
                email=request.email,
                avartar=request.avartar,
                id_don_vi=request.id_don_vi,
                nghi_viec=request.nghi_viec,
                ma_can_bo=request.ma_can_bo,
                gioi_tinh=request.gioi_tinh
                
            };
            _context.Lst_KiThuatVien.Add(tech);
            await _context.SaveChangesAsync();
            return tech.id_ktv;
        }

        public async Task<int> Delete(int id_ktv)
        {
            var tech = await _context.Lst_KiThuatVien.FindAsync(id_ktv);
            if (tech == null) throw new ExceptionId($"Cannot find a driver: {id_ktv}");
            _context.Lst_KiThuatVien.Remove(tech);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<TechViewModel>> GetAll()
        {
            var query = from tech in _context.Lst_KiThuatVien
                        select tech;
            var data = await query
                .Select(x => new TechViewModel()
                {
                    id_ktv = x.id_ktv,
                    ten_ktv = x.ten_ktv,
                    RFID_id = x.RFID_id,
                    so_dien_thoai = x.so_dien_thoai,
                    dia_chi = x.dia_chi,
                    email = x.email,
                    avartar = x.avartar,
                    id_don_vi = x.id_don_vi,
                    nghi_viec = x.nghi_viec,
                    ma_can_bo = x.ma_can_bo,
                    gioi_tinh = x.gioi_tinh
                }
                ).ToListAsync();
            return data;
        }

        public async Task<PageResult<TechViewModel>> GetAllPaging(GetTechPagingRequest request)
        {
            var query = from tech in _context.Lst_KiThuatVien
                        select tech;
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.ten_ktv.Contains(request.Keyword));
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .Select(x => new TechViewModel()
                {
                    id_ktv = x.id_ktv,
                    ten_ktv = x.ten_ktv,
                    RFID_id = x.RFID_id,
                    so_dien_thoai = x.so_dien_thoai,
                    dia_chi = x.dia_chi,
                    email = x.email,
                    avartar = x.avartar,
                    id_don_vi = x.id_don_vi,
                    nghi_viec = x.nghi_viec,
                    ma_can_bo = x.ma_can_bo,
                    gioi_tinh = x.gioi_tinh
                }
                ).ToListAsync();
            var pageResult = new PageResult<TechViewModel>()
            {
                TotalRecord = totalRow,
                Items = data,
            };
            return pageResult;
        }

        public async Task<TechViewModel> GetById(int id_ktv)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(EditTech request)
        {
            var tech = await _context.Lst_KiThuatVien.FindAsync(request.id_ktv);
            if (tech == null) throw new ExceptionId($"Cannot find a technician with id: {request.id_ktv}");
            tech.id_ktv = request.id_ktv;
            tech.ten_ktv = request.ten_ktv;
            tech.RFID_id = request.RFID_id;
            tech.so_dien_thoai = request.so_dien_thoai;
            tech.dia_chi = request.dia_chi;
            tech.email = request.email;
            tech.avartar = request.avartar;
            tech.id_don_vi = request.id_don_vi;
            tech.nghi_viec = request.nghi_viec;
            tech.ma_can_bo = request.ma_can_bo;
            tech.gioi_tinh = request.gioi_tinh;
            return await _context.SaveChangesAsync();
        }
    }
}
