using Barfi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfi.Services
{
    public interface IBarData
    {
        IEnumerable<Bar> getAll();

        Bar Get(int id);

        void Add(Bar bar);
    }
}
