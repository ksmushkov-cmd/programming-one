using System;

class Program
{
  static void Main() {

  // Первое задание с вычислением натуральных чисел
  Console.Write("Enter support: ");
  int support = int.Parse(Console.ReadLine());
  Console.Write("Enter degree: ");
  int degree = int.Parse(Console.ReadLine());

  long result = 1;
  int count = 0;

  // Пока счетчик меньше степени, умножаем
  while (count < degree) {
    result *= support;
    ++count;
  }

  // Второе задание с вычеркиванием второй цифры
  Console.Write("Enter start (> 2 digits): ");
  string initialNumber = Console.ReadLine();

  // Проверка: число должно быть трехзначным или больше
  if (initialNumber.Length < 3) {
  Console.WriteLine("The number must contain more than two digits!");
  return;
  }

  // Берем вторую цифру (индекс 1, так как счет с 0)
  char secondDigit = initialNumber[1];

  // Убираем вторую цифру: первая часть (до) + третья и далее
  string removedSecond = initialNumber.Remove(1, 1);

  // Приписываем вторую цифру в конец
  string newString = removedSecond + secondDigit;

  // Преобразуем результат в число
  int endNumber = int.Parse(newString);

  Console.WriteLine($"Result: {result}");
  Console.WriteLine($"End number: {endNumber}");

  }
}