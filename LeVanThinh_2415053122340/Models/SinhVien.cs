namespace LeVanThinh_2415053122340.Models
{
    public class SinhVien
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ICollection<DangKi> DangKis { get; set; }
    }
}
