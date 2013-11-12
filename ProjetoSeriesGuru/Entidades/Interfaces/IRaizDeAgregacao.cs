using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSeriesGuru.Entidades.Interfaces
{
    public interface IRaizDeAgregacao<T>
    {
        T Id { get; set; }
    }
}
