
using System.Drawing;

namespace HomeWork7
{
    internal class Square
    {
        public double _length;
        private string _color;
        private double _area;

        public void GetInfo()
        {
            Console.WriteLine($"Length: {_length}, color: {_color}, area: {_area}\n");
        }

        public Square()
        {

        }

        public Square( double length, string color ) 
        { 
            _length = length;
            _color = color;
            _area = Math.Pow(_length, 2);
        }

        public void Rewriter(Square figure1, Square figure2)
        {
            figure1._length = figure2._length * 3;
            _area = Math.Pow(figure1._length, 2);
        }

    }
}


/*1.Создать класс Квадрат
Поля:
длина cтороны
цвет
площадь
Метод:
вывести на экран информацию о фигуре
Конструктор принимает параметры:
длина стороны, цвет
Высчитывает площадь фигуры
Создать объекты:
Зеленый квадрат, длина стороны 5
Синий квадрат, длина стороны 2
Голубой квадрат, длина стороны 15
Вывести информацию о фигурах на экран
Поменять длину стороны зеленого квадрата = длина стороны
синего квадрата * 3
Вывести информацию о фигурах на экран*/