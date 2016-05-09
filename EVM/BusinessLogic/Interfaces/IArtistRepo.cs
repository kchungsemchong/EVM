using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EVM.Models;

namespace EVM.BusinessLogic
{
    public interface IArtistRepo
    {
        IEnumerable<Artist> Retrieve();
        Artist Get(int id);
        Artist Create();
        Artist Edit();
        bool Delete(int id);
    }
}