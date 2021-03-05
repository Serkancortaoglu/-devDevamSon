using System;

namespace ÖdevDevamSon
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new Validation());
            gamerManager.Add(new Gamer
            {
                IdentiytNumber = 46771,
                BirthYear=1998,
                LastName="CORT",
                FirstName="SERKAN"
            });

            GameSale gameSale = new GameSale(new CompanyName());
            gameSale.Sale(new Gamer
            {
                FirstName="SERKAN",
                LastName="CORT",
                BirthYear=1998,
                IdentiytNumber=46771
            });
            

            

           
            
            
        }
    }
}
