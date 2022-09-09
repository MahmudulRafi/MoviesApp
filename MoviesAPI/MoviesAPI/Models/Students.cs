namespace MoviesAPI.Models
{
    public class Students
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Roll { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age => CalculateAge(DateOfBirth);
        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age--;

            return age;
        }

    }

}
