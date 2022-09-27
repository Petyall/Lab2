using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    interface ICalcPS
    {
        /// <summary>
        /// Вычисление периметра
        /// </summary>
        /// <returns>Периметр</returns>
        double P();

        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns>Площадь</returns>
        double S();
    }
}
