namespace appquanlydanhba.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSinhVien { get; set; }

        [StringLength(50)]
        public string TenSinhVien { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? SDT { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        public int? ID { get; set; }

        public virtual nhom nhom { get; set; }
    }
}
