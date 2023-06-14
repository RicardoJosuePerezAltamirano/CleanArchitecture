using StreamCasa.Abstractions.Entities;

namespace StreamCasa.Entities
{
    public class Users : IEntity
    {
        public Users()
        {
            DateRegistry = DateTime.UtcNow;
        }
        public Guid Id { get ; set ; }
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime DateRegistry { get; set; }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetBithDate(DateTime bithDate)
        {
            ValidateAge(bithDate);
            BirthDate = bithDate;
        }
        public void SetEmail(string email)
        {
           Email= email;
        }
        public void SetPassword(string password)
        {
            Password= password;
        }
        private void ValidateAge(DateTime date)
        {
            var local = DateTime.Now;
            int age = 0;
            age= local.Year - date.Year;
            if (local.DayOfYear < date.DayOfYear)
                age = age - 1;
            if (age < 16)
                throw new Exception("Edad no permitida para el registro en los cursos");
        }
        public List<Profiles> Profiles { get; set; }
        public List<Favorites> Favorites { get; set; }
    }
}