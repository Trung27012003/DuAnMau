﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.DomainClass
{
    [Table("CuaHang")]
    [Index(nameof(Ma), Name = "UQ__CuaHang__3214CC9E451AF100", IsUnique = true)]
    public partial class CuaHang
    {
        public CuaHang()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(50)]
        public string Ten { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(50)]
        public string ThanhPho { get; set; }
        [StringLength(50)]
        public string QuocGia { get; set; }

        [InverseProperty(nameof(NhanVien.IdChNavigation))]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
