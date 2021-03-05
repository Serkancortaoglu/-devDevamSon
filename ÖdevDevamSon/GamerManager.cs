using System;
using System.Collections.Generic;
using System.Text;

namespace ÖdevDevamSon
{
    class GamerManager : IGamerManager
    {

        IValidation _validation;

        public GamerManager(IValidation validation)
        {
            _validation = validation;
        }

        public void Add(Gamer gamer)
        {
            if (_validation.Validate(gamer)==(true))
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
