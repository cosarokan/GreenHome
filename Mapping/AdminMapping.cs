using DTOs.Admin;
using EntityLayer.Models;
namespace Mapping.AdminMapping
{
    public class AdminMapping
    {
        public Admin AdminDTOTOAdmin(AdminLoginDTO dto)
        {
            return new Admin()
            {
                ID = dto.ID,
                Username = dto.Username,
                Password = dto.Password
            };
        }
    }
}
