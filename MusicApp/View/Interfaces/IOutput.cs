using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.View.Interfaces
{
    public interface IOutput<T>
    {
        public void DisplayAll(List<T> entity);
        public void DisplayOptions();
    }
}
