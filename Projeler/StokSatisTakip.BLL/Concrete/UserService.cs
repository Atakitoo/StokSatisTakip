using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StokSatisTakip.BLL.Abstract;
using StokSatisTakip.DAL.Abstract;
using StokSatisTakip.DAL.Concrete;
using StokSatisTakip.Entities.Concrete;

namespace StokSatisTakip.BLL.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public User Login(string email, string password)
        {
            //  İş kuralları
            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("Email boş olamaz");

            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Şifre boş olamaz");

            //  Veritabanı sorgusu
            User user = _userRepository.GetByEmailAndPassword(email, password);

            //  Kullanıcı yoksa
            if (user == null)
                throw new Exception("Email veya şifre hatalı");

            //  Başarılı giriş
            return user;
        }
    }
}
