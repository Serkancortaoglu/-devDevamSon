using System;
using System.Collections.Generic;
using System.Text;

namespace ÖdevDevamSon
{
    class GameSale : IGameSale
    {
        ICompanyName _companyname;

        public GameSale(ICompanyName companyname)
        {
            companyname = _companyname;
        }
        
        public void Sale(Gamer gamer)
        {
            Console.WriteLine( "Satış yapıldı" );
        }
    }
}
