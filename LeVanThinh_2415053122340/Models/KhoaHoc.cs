namespace LeVanThinh_2415053122340.Models
{
    public class KhoaHoc
    {
        public string Id { get; set; }
        public string tenKH { get; set; }
        public string moTa { get; set; }
        public ICollection<DangKi> DangKis { get; set; }

    }
}
