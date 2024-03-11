//using Project208.Image;
using System.Numerics;
using System.Text;
//Cтатичний імпорт класів
using static Project208.Calculation;
//Використання псевдонімів
using Bint = System.Numerics.BigInteger;

namespace Project208;
internal class Program
{
	static void Basics() {
		Console.WriteLine("\n================== Типи даних ==================\n");
		bool bo1 = true;                   //  1 байт | System.Boolean | true, false

		byte by1 = 100;                    //  1 байт | System.Byte    | 0 ... 255
		sbyte sb1 = -100;                  //  1 байт | System.SByte   | -128 ... 127
		short sh1 = -30000;                // 2 байти | System.Int16   | -32 768 ... 32 767
		ushort us1 = 30000;                // 2 байти | System.UInt16  | 0 ... 65 535
		int in1 = -2000111000;             // 4 байти | System.Int32   | -2 147 483 648 ... 2 147 483 647
		uint ui1 = 4200111295U;            // 4 байти | System.UInt32  | 0 ... 4 294 967 295 
		long lo1 = -9223372036854775808L;   // 8 байт | System.Int64   |  –9 223 372 036 854 775 808 ... 9 223 372 036 854 775 807
		ulong ul1 = 18446744073709551615UL; // 8 байт | System.UInt64  | 0 ... 18 446 744 073 709 551 615

		float fl1 = 5.37F;                 // 4 байти | System.Single  | -3.4 * 10^38 ... 3.4 * 10^38
		double do1 = 5.37;                 //  8 байт | System.Double  | ±5.0 * 10^-324 ... ±1.7 * 10^308
		decimal de1 = 5.37M;               // 16 байт | System.Decimal | ±1.0 * 10^-28 ... ±7.9228 * 10^28

		char ch1 = 'A';                    // 2 байти | System.Char    | 1 Символ з Unicode 0 ... 65 536
		string st1 = "Hello";  // 2 * к-ть симв. байт | System.String  | Символи з Unicode

		object ob1 = 25;                    // 8 байт | System.Object  | Значення будь-якого типу

		const int in2 = 20; // Константа
		var va1 = "World"; // Неявна типізація

		Bint bi1 = Bint.Parse("45446744073709551615000");
		Bint bi2 = Bint.Parse("10000000000000000000000");
		Console.WriteLine(bi1 + bi2); // 55446744073709551615000
		Bint bi3 = Bint.Multiply(17, Bint.Pow(10, 307));

		Console.WriteLine(bi3); // 170000...

		Console.WriteLine($" {bo1} \n {by1} \n {sb1} \n {sh1} \n {us1} \n {in1} \n {ui1} \n {lo1} \n {ul1} \n " +
			$"{fl1} \n {do1} \n {de1} \n {ch1} \n {st1} \n {ob1} \n {in2} \n {va1}");

		Console.WriteLine("\n============ Конвертація типів даних ============\n");
		// Метод Parse() як параметр приймає рядок та повертає об'єкт поточного типу.
		int in3 = int.Parse("2157566");
		double do2 = double.Parse("23,56");
		Console.WriteLine($" {in3} \n {do2} ");

		// Клас Convert містить методи, що приймають значення будь-яких типів.
		bool bo2 = Convert.ToBoolean(0);
		byte by2 = Convert.ToByte('5');
		sbyte sb2 = Convert.ToSByte("-5");
		short sh2 = Convert.ToInt16(-20000);
		ushort us2 = Convert.ToUInt16(20000);
		int in4 = Convert.ToInt32(4.56);
		uint ui2 = Convert.ToUInt32(5.2);
		long lo2 = Convert.ToInt64("-400000");
		ulong ul2 = Convert.ToUInt64("400000");
		float fl2 = Convert.ToSingle(4.6);
		double do3 = Convert.ToDouble(4.8M);
		decimal de2 = Convert.ToDecimal(5);
		char ch2 = Convert.ToChar(65);
		string st2 = Convert.ToString(30000);
		Console.WriteLine($" {bo2} \n {by2} \n {sb2} \n {sh2} \n {us2} \n {in4} \n {ui2} \n {lo2} \n {ul2} \n " +
			$"{fl2} \n {do3} \n {de2} \n {ch2} \n {st2}");


		Console.WriteLine("\n=================== Операції ===================\n");
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());

		//Арифметичні операції
		int r1 = a + b;
		int r2 = a - b;
		int r3 = a * b;
		double r4 = (double)a / b;
		int r5 = a % b;

		Console.Write($"{r1} {r2} {r3} {r4} {r5}");

		//Операції присвоювання
		r1 += a; // r1 = r1 + a;
		r2 -= a;
		r3 *= a;
		r4 /= a;
		r5 %= a;
		Console.Write($"\n{r1} {r2} {r3} {r4} {r5}\n");

		//Унарні операції
		Console.WriteLine(a);
		Console.WriteLine(++a);
		Console.WriteLine(a++);
		Console.WriteLine(a);
		Console.WriteLine(--a);
		Console.WriteLine(a--);
		Console.WriteLine(a);

		//Операції порівняння
		bool bo3 = a == b;
		bool bo4 = a != b;
		bool bo5 = a > b;
		bool bo6 = a < b;
		bool bo7 = a >= b;
		bool bo8 = a <= b;
		Console.Write($"\n{bo3} {bo4} {bo5} {bo6} {bo7} {bo8}\n");

		//Логічні операції
		bool bo9 = !Convert.ToBoolean(a) && Convert.ToBoolean(b);
		bool bo10 = Convert.ToBoolean(a) || Convert.ToBoolean(b);
		Console.Write($"\n{bo9} {bo10}\n");

		Console.WriteLine("\n=================== Умовні конструкції ===================\n");
		// if ... else
		if (a != b)
		{
			Console.WriteLine("Спрацював блок if");
		}
		else
		{
			Console.WriteLine("Спрацював блок else");
		}
		// switch .. case
		string? st3 = Console.ReadLine();
		switch (st3)
		{
			case "1": Console.WriteLine("Спрацював випадок 1"); break;
			case "2": Console.WriteLine("Спрацював випадок 2"); break;
			default: Console.WriteLine("Спрацював випадок за замовчуванням"); break;
		}
		//Тернарний оператор
		Console.WriteLine((a != b) ? "Спрацював блок if" : "Спрацював блок else");

		Console.WriteLine("\n=================== Цикли ===================\n");
		//Цикл for
		for (int i = 1; i < 5; i++)
		{
			Console.Write($"{i} ");
		}
		Console.WriteLine();

		//Цикл while
		int j = 1;
		while (j < 5)
		{
			Console.Write($"{j} ");
			j++;
		}
		Console.WriteLine();

		//Цикл do ... while
		j = 1;
		do
		{
			Console.Write($"{j} ");
			j++;
		}
		while (j < 5);
		Console.WriteLine();

		/* 
		 for (int a : arr)
		 */
		//Цикл foreach
		foreach (char k in "1234")
		{
			Console.Write($"{k} ");
		}
		Console.WriteLine("\n=================== Масиви ===================\n");
		//Одновимірні масиви
		int[] arr1 = new int[4] { 2, 4, 6, 8 };
		int[] arr2 = new int[] { 2, 4, 6, 8 };
		int[] arr3 = { 2, 4, 6, 8 };
		Console.WriteLine($"{arr1[0]} {arr1[1]} {arr1[2]} {arr1[3]}");
		Console.WriteLine(arr2.Length);
		arr1[arr1.Length - 1] = 9;
		foreach (int i in arr3)
		{
			Console.Write($"{i} ");
		}
		Console.WriteLine();
		for (int i = 0; i < arr3.Length; i++)
		{
			Console.Write($"{arr3[i]} ");
		}
		Console.WriteLine();

		//Багатовимірні масиви
		const int n = 2, m = 3;
		int[,] arr4 = new int[n, m] { { 10, 11, 12 }, { 13, 14, 15 } };
		Console.WriteLine($"{arr4[0, 0]} {arr4[0, 1]} {arr4[0, 2]} {arr4[1, 0]} {arr4[1, 1]} {arr4[1, 2]}");
		for (int i = 0; i < n; i++)
		{
			for (int k = 0; k < m; k++)
			{
				Console.Write($"{arr4[i, k]} ");
			}
		}
		Console.WriteLine();

		//Зубчасті масиви
		int[][] arr5 = new int[3][] { new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2 } };
		Console.WriteLine($"{arr5[0][0]} {arr5[0][1]} {arr5[0][2]} {arr5[1][0]} {arr5[1][3]} {arr5[2][0]} {arr5[2][1]}");
		for (int i = 0; i < arr5.Length; i++)
		{
			for (int k = 0; k < arr5[i].Length; k++)
			{
				Console.Write($"{arr5[i][k]} ");
			}
		}
		Console.WriteLine();

		Console.WriteLine("\n=================== Функції ===================\n");
		// [Модифікатори_доступу] Тип_повертаючого_значення Назва_функції([Параметр1, Параметр2]) { Тіло функції }

		void SayHello()
		{
			Console.WriteLine("Hello World!");
		}
		SayHello();
		SayHello();

		string SayHello2(string s)
		{
			Console.WriteLine(s);
			return s;
		}
		string hello = SayHello2("Привітання!");
		SayHello2("Вітаємо!");
		Console.WriteLine(hello);

		int Substract(int x, int y)
		{
			return x - y;
		}
		Console.WriteLine(Substract(y: 10, x: 6));

		//Функція з переданим параметром по значенню
		void Increase(int x)
		{
			x += 2;
			Console.WriteLine(x);
		}
		int inc = 5;
		Increase(inc);
		Console.WriteLine(inc);

		//Функція з переданим параметром за посиланням (модифікатор ref) 
		void Increase2(ref int x)
		{
			x += 2;
			Console.WriteLine(x);
		}
		Increase2(ref inc);
		Console.WriteLine(inc);

		//Функція з вихідним параметром (модифікатор out)
		int Multiply(int x, int y, out int result)
		{
			x += 10;
			result = x * y;
			return y * y;
		}
		int res1, res2;
		res1 = Multiply(10, 30, out res2);
		Console.WriteLine(res1);
		Console.WriteLine(res2);

		//Функція з вхідними параметрами (модифікатор in)
		int Multiply2(in int x, in int y)
		{
			//x += 10;
			return x * y;
		}
		Console.WriteLine(Multiply2(10, 30));

		int Sum(params int[] nums)
		{
			int count = 0;
			foreach (int n in nums)
			{
				count += n;
			}
			return count;
		}
		int sum = Sum(1, 2, 3);
		int sum2 = Sum(1, 2, 3, 4, 5);

		Console.WriteLine(sum);
		Console.WriteLine(sum2);

		// Рекурсивна функція знаходження факторіалу числа
		ulong Factorial(ulong n)
		{
			if (n == 1) return 1;
			return n * Factorial(--n);
		}
		Console.WriteLine(Factorial(50));

		Console.WriteLine("\n=================== Переліки ===================\n");
		Operation operation = Operation.None;
		while (operation != Operation.Exit)
		{
			operation = (Operation)Convert.ToInt32(Console.ReadLine());
			DoOperation(a, b, operation);
		}
		void DoOperation(int a, int b, Operation c)
		{
			switch (c)
			{
				case Operation.Exit: break;
				case Operation.Add: Console.WriteLine(a + b); break;
				case Operation.Sub: Console.WriteLine(a - b); break;
				case Operation.Mult: Console.WriteLine(a * b); break;
				case Operation.Div: Console.WriteLine(a / b); break;
				default: Console.WriteLine("Операція задана некоректно!"); break;
			}
		}
	}
	static void Main()
	{
		Console.InputEncoding = Encoding.UTF8;
		Console.OutputEncoding = Encoding.UTF8;

		//Basics();

		Console.WriteLine("\n=================== Структури ===================\n");
		Person person1 = new Person("Ivan", 18);
		person1.Print();
		person1.Print("Ім'я", "Вік");
		//Class1 class1 = new Class1();
		person1.Deconstruct(out string name, out int age);
		Console.WriteLine($"{name}, {age}");
		person1.SetName("Petr");
		(name, _) = person1;
		Console.WriteLine($"{name}, {age}");
		person1.Age = 20;
		Console.WriteLine(person1.Age);
		person1.Position = "Worker";
		Console.WriteLine(person1.Position);
		person1.Age = 19;

		Console.WriteLine("\n=============== Класи та об'єкти ===============\n");
		Animal animal1 = new Animal("Cat", 3);
		animal1.PrintAnimal();
		Cat cat1 = new Cat("Cat", "Murka", 5);
		cat1.PrintAnimal();
		cat1.Rename("Vasya");
		Animal animal2 = new Animal();
		animal2.PrintAnimal();
		Console.WriteLine(Add(10, 9));
		Console.WriteLine(Sub(10, 9));
		Console.WriteLine(Div(10, 9));
		Console.WriteLine(Mult(10, 9));
		cat1.Move();

		Console.WriteLine("\n=============== Перевантаження операторів ===============\n");
		Box b1 = new Box(10, 60);
		Box b2 = new Box(10, 10);
		Console.WriteLine($"Висота: {b1.Height}, Ширина: {b1.Width}");
		Console.WriteLine($"Висота: {b2.Height}, Ширина: {b2.Width}");
		Box b3 = b1 + b2;
		Box b4 = b1 - b2;
		Console.WriteLine($"Висота: {b3.Height}, Ширина: {b3.Width}");
		Console.WriteLine($"Висота: {b4.Height}, Ширина: {b4.Width}");

		Console.WriteLine("\n=============== Узагальнення ===============\n");
		string a1 = "5px"; 
		string a2 = "7px";
		Console.WriteLine(a1 + " " + a2);
		Swap.GetSwap<string>(ref a1, ref a2);
		Console.WriteLine(a1 + " " + a2);

		Stacks<string> stack1 = new Stacks<string>();
		Stacks<int> stack2 = new Stacks<int>();

		string fname1 = "Ivan", fname2 = "Oleg", fname3 = "John";
		stack1.Add(fname1);
		stack1.Add(fname2);
		stack1.Add(fname3);
		stack1.GetArray();
		stack1.Rename();
		stack1.Add(fname1);
		stack1.GetArray();
		stack1.GetItem(1);

		int n1 = 24, n2 = 35, n3 = 12;
		stack2.Add(n1);
		stack2.Add(n2);
		stack2.GetItem(0);
		stack2.GetArray();
		stack2.Add(n3);
		stack2.GetArray();

		Console.WriteLine("\n=============== Колекції ===============\n");
		List<int> ints = [10, 46, 8];
		ints.Add(15);
		for (int i = 0; i < ints.Count; i++) Console.Write($"{ints[i]} ");
		Console.WriteLine();
		ints.Sort();
		ints.Reverse();
		ints.RemoveAt(0);
		ints.Remove(8);
		ints.Clear();
		ints.Add(4);
		for (int i = 0; i < ints.Count; i++) Console.Write($"{ints[i]} ");
		Console.WriteLine();

		SortedList<int, string> sints = new SortedList<int, string>
		{
			{ 96, "Ivan" },
			{ 45, "Oleg" },
			{ 18, "Jonh" }
		};
		sints.Remove(18);
		foreach (int i in sints.Keys) Console.Write($"{i} ");
		Console.WriteLine();
		foreach (string i in sints.Values) Console.Write($"{i} ");

		Console.WriteLine("\n=============== Файли ===============\n");
		string? s1 = Console.ReadLine();
		File.WriteAllText("text.txt", s1);
		Console.WriteLine($"В файл text.txt дані ({File.ReadAllText("text.txt")}) було записано!");
		File.AppendAllText("text.txt", " ");
		File.AppendAllText("text.txt", Console.ReadLine());
		Console.WriteLine($"Оновлений файл: {File.ReadAllText("text.txt")}");

		Console.WriteLine("\n=============== Обробка виключень ===============\n");
		int[] array = { 10, 15 };
		try
		{
			Console.WriteLine(array[1]);
		}
		catch (Exception e)
		{
			Console.WriteLine($"Помилка: {e.Message} Ви вийшли за діапазон масиву!");
		}
		finally 
		{
			Console.WriteLine(array[1]);
		}
		Console.ReadKey();
	}
}
class Stacks<Type> {
	private int index = 0;
	Type[] innerArr = new Type[10];
	public void Add(Type item) {
		if (index >= innerArr.Length) {
			index = 0;
		}
		innerArr[index++] = item;
	}
	public Type Rename()
	{
		Console.WriteLine($"Елемент {innerArr[--index]} будe у масиві перезаписано!");
		return innerArr[index];
	}
	public Type GetItem(int i) 
	{
		Console.WriteLine(innerArr[i]);
		return innerArr[i]; 
	}
	public void GetArray()
	{
		for (int i = 0; i < index; i++) {
			Console.Write($"{innerArr[i]} ");
		}
		Console.WriteLine();
	}
}
static class Swap {
	public static void GetSwap<Type>(ref Type a, ref Type b) {
		Type temp = a;
		a = b; 
		b = temp;
	}
}
class Box { 
	public double Height { get; set; }
	public double Width { get; set; }
	public Box(double height, double width) { 
		Height = height; 
		Width = width;	
	}
	public static Box operator+ (Box box1, Box box2) {
		double h = box1.Height + box2.Height;
		double w = box1.Width + box2.Width;
		Box box = new Box(h, w);
		return box;
	}
	public static Box operator- (Box box1, Box box2)
	{
		double h = box1.Height - box2.Height;
		double w = box1.Width - box2.Width;
		Box box = new Box(h, w);
		return box;
	}
}
enum Operation : sbyte { None = -1, Exit = 0, Add = 1, Sub, Mult, Div }

struct Person
{
	//Поля
	private string _name = "No Name";

	//Автоматична властивість
	public int Age { get; set; }

	//Методи
	public void Print()
	{
		Console.WriteLine($"Name: {_name}, age: {Age}");
	}
	//Стрілочний метод
	public void SetName(string name) => _name = name;

	//Властивості
	public string Position
	{
		get { return _name; }
		set { _name = value; }
	}
	//Перевантажений метод
	public void Print(string title1, string title2)
	{
		Console.WriteLine($"{title1}: {_name}, {title2}: {Age}");
	}
	//Конструктор
	public Person(string name, int age)
	{
		_name = name;
		Age = age;
	}
	//Деконструктор
	public void Deconstruct(out string name, out int age)
	{
		name = _name;
		age = Age;
	}
}
public class Animal
{
	protected string _type = "No Name";
	protected int _age = 0;
	public Animal()
	{
	}
	public Animal(string type, int age)
	{
		_type = type;
		_age = age;
	}
	public virtual void PrintAnimal() {
		Console.WriteLine($"{_type} {_age}");
	}
}
public class Cat : Animal, IMovable {
	private string _name;
	public override void PrintAnimal()
	{
		Console.WriteLine($"Type: {_type} Name: {_name} Age: {_age}");
	}
	public void Rename(string name)
	{
		_name = name;
		Console.WriteLine("Ім'я було змінено");
		PrintAnimal();
	}
	public Cat(string type, string name, int age) : base(type, age) {
		_name = name;
	}
	public void Move() {
		Console.WriteLine("Кішка рухається!");
	}
}
static class Calculation { 
	static public int Add(int x, int y) => x + y;
	static public int Sub(int x, int y) => x - y;
	static public int Mult(int x, int y) => x * y;
	static public double Div(int x, int y) => Convert.ToDouble(x) / y;
}
interface IMovable {
	public void Move();
}
