namespace XamExxen.Models
{
    public class Cast
    {
        public int Id { get; set; }
        public string CastFirstName { get; set; }
        public string CastLastname { get; set; }
        public string CastImage { get; set; }
        public string CastFullName
        {
            get
            {
                return CastFirstName + " " + CastLastname;
            }
        }
    }
}
