using System;
using System.Collections.Generic;
using System.Text;

namespace ÖdevDevamSon
{
    class CompanyName : ICompanyName
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
