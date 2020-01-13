using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drink_Menu.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
