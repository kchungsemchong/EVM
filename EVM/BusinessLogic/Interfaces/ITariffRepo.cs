using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVM.Models;

namespace EVM.BusinessLogic.Interfaces
{
    public interface ITariffRepo
    {
        IEnumerable<TariffRepo> Retrieve();
        TariffRepo Get(int id);
        TariffRepo Create();
        TariffRepo Edit();
        bool Delete(int id);
    }
}