using System;
using System.Text;

namespace ConsoleApp21
{
	class Program 
	{
		static void Main(string[] args)
		{
			MyList<int> spisok = new MyList<int>();

			spisok.Add(new Node<int>(20));
			spisok.Add(new Node<int>(30));
			spisok.Add(new Node<int>(40));
			spisok.Add(new Node<int>(50));
			spisok.Add(new Node<int>(60));

			spisok.PushBack(new Node<int>(10));//Добавляем элемент в начеле списка
			spisok.PushFront(new Node<int>(70));


			Console.WriteLine();
			spisok.Print();
			Console.WriteLine("Первый элемент списка (не считая который мы добавили)");
			Console.WriteLine(spisok.Get(1));
			Console.WriteLine();
			

			spisok.Print();
			Console.WriteLine("Последний элемент списка (не считая который мы добавили)");
			Console.WriteLine(spisok.Get(5));

			Console.WriteLine();
			Console.WriteLine("Список в обратном порядеке");
			spisok.PrintForward(new Node<int>(60));

		}
	}
}
