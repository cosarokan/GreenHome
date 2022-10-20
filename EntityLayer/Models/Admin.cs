using EntityLayer.Models.Abstract;
namespace EntityLayer.Models
{
    public class Admin : Base
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return Username;
        }
    }
}
