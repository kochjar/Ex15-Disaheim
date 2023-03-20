using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Disaheim
{
    public class Controller
    {
        private ValuableRepository _valuableRepository;

        public Controller() {
            _valuableRepository = new ValuableRepository();
        }

        public void AddToList(IValuable valuable)
        {
            _valuableRepository.AddValuable(valuable);
        }
    }
}
