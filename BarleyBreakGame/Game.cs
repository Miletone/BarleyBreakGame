using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BarleyBreakGame
{
    class Game
    {
        int size; //Размер игрового поля
        int space_x, space_y; //Координаты пустого поля
        int[,] map; //Карта игры
        static Random rand = new Random(); //Рандомное число

        public Game(int size)
        {
            if (size < 2) size = 2; //Если размер игрового поля < 2, установить его равным 2
            if (size > 5) size = 5; //Если размер игрового поля > 5, установить его равным 5
            this.size = size; //Сохранить размер игрового поля в текущем экземпляре класса
            map = new int[size, size]; //Создать новую карту игрового поля
        }

        public void Start()
        {
            //Записать в поля игрового поля соответствующие им числа
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    map[x, y] = СoordinatesToPosition(x, y) + 1; 
                }
            }
            space_x = size - 1; //Координата x пустого поля
            space_y = size - 1; //Координата y пустого поля
            map[space_x, space_y] = 0; // Номер пустого поля
        }

        public void SetMap(int[,] newMap)
        {
            map = newMap; //Установить новую карту игры
            //Установить новые координаты пустого поля
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if(map[i, j] == 0)
                    {
                        space_x = i;
                        space_y = j;
                    }
                }
            }
        }

        public int[,] GetMap()
        {
            return map; //Получить карту игрового поля
        }

        private int СoordinatesToPosition(int x, int y)
        {
            if (x < 0) x = 0; //Если x < 0 приравниваем x к нулю
            if (x > size - 1) x = size - 1; //Если x < size-1 приравниваем x к size-1
            if (y < 0) y = 0; //Если y < 0 приравниваем x к нулю
            if (y > size - 1) y = size - 1; //Если y < size-1 приравниваем x к size-1
            return y * size + x; //Вернуть позицию, вычесленную из координат
        }

        private void PositionToСoordinates(int position, out int x, out int y)
        {
            if (position < 0) position = 0; //Если position < 0 приравниваем position к нулю
            if (position > size * size - 1) position = size * size - 1; //Если position > size * size - 1 приравниваем position к size * size - 1
            x = position % size; //Получить координату x, вычесленную из позиции
            y = position / size; //Получить координату y, вычесленную из позиции
        }

        public void ShiftRandom()
        {
            int a = rand.Next(0, 4); //Получить случайное целое число от 0 до 4
            int x = space_x; //Получить координату x пустого поля
            int y = space_y; //Получить координату y пустого поля
            switch (a)
            {
                case 0: x--; break; //Сдвиг влево
                case 1: x++; break; //Сдвиг вправо
                case 2: y--; break; //Сдвиг вниз
                case 3: y++; break; //Сдвиг вверх
            }
            Shift(СoordinatesToPosition(x, y)); //Передвинуть поле
        }

        public void Shift(int position)
        {
            int x, y; //Координаты поля
            PositionToСoordinates(position, out x, out y); //Получить координаты поля из позиции
            if (Math.Abs(space_x - x) + Math.Abs(space_y - y) != 1)
                return; //Нельзя передвигать поле, если оно не граничит с пустым полем
            map[space_x, space_y] = map[x, y]; //Меняем местами пустое поле и сдвигаемое поле
            map[x, y] = 0; //Цифра пустого поля равна нулю
            space_x = x; //Координата x пустого поля равна координате x сдвигаемого поля
            space_y = y; //Координата y пустого поля равна координате y сдвигаемого поля
        }

        public bool CheckNumbers()
        {
            if (!(space_x == size - 1 && space_y == size - 1)) //Если пустое поле не на последней позиции
                return false; //Победа не одержана

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if (!(x == size - 1 && y == size - 1)) //Если не последнее поле
                        if (map[x, y] != СoordinatesToPosition(x, y) + 1) // Если число поля не равно его позиции
                            return false; //Победа не одержана
                }
            }
            return true; //Если все условия пройдены - победа одержана
        }

        public int GetNumber(int position)
        {
            int x, y; //Переменные для хранения координат поля
            PositionToСoordinates(position, out x, out y); //Получить координаты поля из позиции
            if (x < 0 || x >= size) return 0; //Если координата x лежит в нелопустимых пределах - приравнимаем её к нулю
            if (y < 0 || y >= size) return 0; //Если координата y лежит в нелопустимых пределах - приравнимаем её к нулю
            return map[x, y]; //Вернуть цифру поля с координатами [x, y]
        }
    }
}