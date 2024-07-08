using System.Collections.Generic;

// List trong dấu <> là kiểu dữ liệu của phần của list
// Ví dụ int là kiểu số nguyên => List<int> => Danh sách số nguyên | tương cho cho các kiểu dữ liệu khác và các kiểu dữ liệu
// do bản thân lập trình viên tự tạo ra
List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
