using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Figur
{
    class Group
    {
        static List<Forma> list_figur = new List<Forma>();
        //сумма площадей
        public double Sum()
        {

            double sum = list_figur.Sum(x => x.Yardage());
            return sum;
        }
        //добавление фигуры в коллекцию
        public void AddFigure(Forma f)
        {
            list_figur.Add(f);
        }
        
    }
}
