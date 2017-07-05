# NET.S.2017.Reznik.03
1. Даны два целых знаковых четырехбайтовых числа и две позиции битов i и j (i<j). Реализовать алгоритм вставки одного числа в другое так, чтобы второе число занимало позицию с бита j по бит i (биты нумеруются справа налево).

Например.
Insertion(8,15,0,0) ->9
Insertion(0, 15, 30, 30) ->1073741824
Insertion(0, 15, 0, 30) -> 15
Insertion(15, -15, 0, 4) -> 31
Insertion(15, int.MaxValue, 3, 5)->63

Разработать unit-тесты с использованием как NUnit Framework, так и MS Unit Test Framework (здесь использовать подход  Data Driven Testing, пример в архиве UnitTesting.zip, проекты DDT.Demo и DDT.Demo.Tests) для тестирования полученного метода (ниже пример заготовки для тестового класса с использованием NUnit Famework-a) (Если где-то не согласуются результаты, пишите). 

 public class *********Tests
    {
        [TestCase(8,15,0,0, ExpectedResult = 9)]
        [TestCase(0, 15, 30, 30, ExpectedResult = 1073741824)]
        [TestCase(0, 15, 0, 30, ExpectedResult = 15)]
        [TestCase(int.MaxValue, int.MaxValue, 3, 5, ExpectedResult = int.MaxValue)]
        [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
        [TestCase(15, 15, 1, 3, ExpectedResult = 15)]
        [TestCase(15, 15, 1, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 0, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 1, 4, ExpectedResult = 15)]
        [TestCase(-8, -15, 1, 4, ExpectedResult = -6)]
        public int ******_PositiveTest(int first, int second, int startPosition, int finishPosition)
        {
            return *****(first, second, startPosition, finishPosition);
        }
        
        [TestCase(8, 15, -1, 5)]
        [TestCase(8, 15, 5, -1)]
        [TestCase(8, 15, 31, 5)]
        [TestCase(8, 15, 5, 31)]
        public void ******_ThrowsArgumentOutOfRangeException(int first, int second, int startPosition, int finishPosition)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ******(first, second, startPosition, finishPosition));
        }

        [TestCase(8, 15, 7, 5)]
        [TestCase(8, 15, 1, 0)]
        public void *******_ThrowsArgumentException(int first, int second, int startPosition, int finishPosition)
        {
            Assert.Throws<ArgumentException>(() => *******(first, second, startPosition, finishPosition));
        }
    }

2. Дан массив целых чисел. Найти в массиве и вернуть такой индекс n, для которого сумма элементов слева от него равно сумме элементов справа. Если такого индекса нет вернуть null   или -1.
Например.
•	Для массива {1,2,3,4,3,2,1} функция вернет индекс 3, поскольку на 3-й
 позиции массива, суммы слева от индекса ({1,2,3}) и справа от индекса ({3,2, 1})
  равны 6.
•	Для массива {1,100,50, -51,1,1} функция вернет индекс 1, поскольку на 1-й 
позиции массива, суммы слева от индекса ({1}) и справа от индекса ({50, -51,1,1 }) 
равны 1.
Входные данные: Целочисленный массив длины 0 <length <1000. Числа в массиве могут быть любым целыми положительными или отрицательными.
Выходные данные: Наименьший индекс, для которого сторона слева равна стороне справа. Если такого индекса не существует вернуть -1(null).

Разработать unit-тесты для тестирования метода (здесь и далее желательно использовать для тестирования NUnit Framework).

3. Добавить к задаче по сортировкам массивов (день 1) модульные тесты.

4. Реализовать метод NextBiggerNumber, который принимает положительное целое число и возвращает ближайше наибольшее  целое, состоящее из цифр исходного числа, и - 1 (null), если такого числа не существует. Примерные тест-кейсы

[TestCase(12, ExpectedResult = 21)]
[TestCase(513, ExpectedResult = 531)]
[TestCase(2017, ExpectedResult = 2071)]
[TestCase(414, ExpectedResult = 441)]
[TestCase(144, ExpectedResult = 414)]
[TestCase(1234321, ExpectedResult = 1241233)]
[TestCase(1234126, ExpectedResult = 1234162)]
[TestCase(3456432, ExpectedResult = 3462345)]
[TestCase(10, ExpectedResult = -1)]
[TestCase(20, ExpectedResult = -1)]
