using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibraryForAlgLab
{
    public interface IForAlgLabs
    {
        /// <summary>
        /// Каждая структура должна уметь записать себя в файл или вывести в консоль
        /// </summary>
        /// <param name="writer">поток для записи</param>
        void Print(TextWriter writer = null);

        /// <summary>
        /// Каждая структура должна уметь заполняться
        /// </summary>
        void Fill(object obj = null);
    }
}
