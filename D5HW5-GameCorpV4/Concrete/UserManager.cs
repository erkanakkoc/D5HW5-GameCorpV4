using System;
using System.Collections.Generic;
using System.Text;
using D5HW5_GameCorpV4.Interface;

namespace D5HW5_GameCorpV4
{
    // SOMUT ÇÜNKÜ EKRANA ÇIKTI VERİYOR
    // Eğer interface olarak eklemezsek 
    // Yani eğer Inheritance ya da Implementation almıyorsa ilerde problem yaratır
    // MicroService

    //Eğer bir manager sınıfının içerisinde başka bir manager sınıfını kullanacaksan
    //asla new leme. Onun yerine bir tane constructer oluştur
    class UserManager : IUserService  
    {
        IUserValidationService _userValidationService; //constructor

        public UserManager(IUserValidationService userValidationService)   // Kimlik paylaşım sisteminin soyutu
        {
            _userValidationService = userValidationService;
        }

        public void Add(User user)
        {
            if (_userValidationService.Validate(user)==true)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName + " isimli kullanıcı kaydedildi.");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız - Kayıt Başarısız");
            }
        
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " isimli kullanıcının kaydı silindi");
        }

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " isimli kullanıcının kaydı güncellendi");
        }
    }
}