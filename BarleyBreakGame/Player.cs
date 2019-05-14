using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BarleyBreakGame
{
    class Player
    {
        public string name; //Имя игрока
        public int movesCount; //Количество ходов
        public string date; //Дата

        //Констректор, устанавливающий значения переменных класса
        public Player(string n, int mc, string d)
        {
            name = n;
            movesCount = mc;
            date = d;
        }
    }
}
