using System;
using D5HW5_GameCorpV4.Adapters;
using D5HW5_GameCorpV4.Concrete;


namespace D5HW5_GameCorpV4
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new MernisServiceAdapter());
            User user1 = new User { UserId = 1, FirstName = "Erkan", LastName = "Akkoç", BirthYear = 1989, IdentityId="1234567890" };
            //userManager.Add(new User { UserId = 1, BirthYear = 1989, FirstName = "ERKAN", LastName = "AKKOÇ",IdentityId="1234567890" });

            GameManager gameManager = new GameManager();
            //gameManager.Add(new Game { GameId = 1, GameName="GTA V", GamePrice=149.99 });

            CampaignManager campaignManager = new CampaignManager();
            //campaignManager.Add(new Campaign { CampaignId=1, CampaignName="Yaza Özel", CampaignDiscount=10 });

            Console.WriteLine("Yapmak istediğiniz işlem nedir? \n 1) Oyuncu Ekle \n 2) Oyuncu Güncelle \n 3) Oyuncu Sil");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            //if (choice1 == 1)
            //{
            //    Console.WriteLine();
            //}
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Oyuncunun Adı");
                    string aAd1=Console.ReadLine();
                    Console.WriteLine("Oyuncunun Soyadı");
                    string aSd1 = Console.ReadLine();
                    Console.WriteLine("Oyuncunun Doğum Yılı");
                    int aDy1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Oyuncunun TCKN");
                    string oTc1 = Console.ReadLine();
                    
                    userManager.Add(new User { FirstName = aAd1.ToUpper(), LastName = aSd1.ToUpper(), BirthYear=aDy1, IdentityId=oTc1});
                    break;
                case 2:
                    Console.WriteLine(user1.FirstName + " isimli oyuncunun yeni adı");
                    user1.FirstName = Console.ReadLine();
                    Console.WriteLine(user1.LastName + " soyadlı oyuncunun yeni soyadı");
                    user1.LastName = Console.ReadLine();
                    Console.WriteLine(user1.BirthYear + " doğum tarihli oyuncunun yeni doğum yılı");
                    user1.BirthYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(user1.IdentityId + " TCKN'li oyuncunun yeni TCKN");
                    user1.IdentityId = Console.ReadLine();


                    userManager.Update(user1);
                    break;
                case 3:
                    userManager.Delete(user1);
                    break;
                default:
                    break;
            }

        }
    }
}
