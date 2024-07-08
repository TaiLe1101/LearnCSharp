using System.Collections.Generic;
// Stack hoạt động theo hướng LIFO (LAST IN FIST OUT) => Thêm phần vào cuối danh sách và khi lấy ra thì lấy phần tử đầu danh sách
// Ngược lại stack thì Queue hoạt động theo hướng FIFO (FIRST IN FIRST OUT) => Thêm phần tử vào đầu danh sách vào khi lấy ra thì lấy ở đầu danh sách
Stack<string> stack = new Stack<string>();
stack.Push("First");
stack.Push("Second");
stack.Push("Third");

while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop());
}
