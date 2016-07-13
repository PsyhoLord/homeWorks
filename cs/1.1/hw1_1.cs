//using System;

//class Constr{
//	public Constr(params string[] value){
//		for (int i = 0; i < value.Length; i++){
//			Console.WriteLine(value[i].Trim('"').MaxValue);
//		}
//	}
//}

//class Programm{
//	static void Main(){
//		Constr a = new Constr("int", "byte");
//	}
//}

using System;
// # Такое расположение фигурных скобок хорошо если проект мелкий.
// # В большом проекте - лучше писать с новой строки,
// # так как оно создает видимость в програме отдельных блоков
public class Programm {
	static void Main(){
		// * Очень много повторения кода. Подумай как это поправить.
		Console.WriteLine("Type byte: default " + default(byte) + ", min " + byte.MinValue + ", max " + byte.MaxValue);
		Console.WriteLine("Type sbyte: default " + default(sbyte) + ", min " + sbyte.MinValue + ", max " + sbyte.MaxValue);
		Console.WriteLine("Type short: default " + default(short) + ", min " + short.MinValue + ", max " + short.MaxValue);
		Console.WriteLine("Type ushort: default " + default(ushort) + ", min " + ushort.MinValue + ", max " + ushort.MaxValue);
		Console.WriteLine("Type int: default " + default(int) + ", min " + int.MinValue + ", max " + int.MaxValue);
		Console.WriteLine("Type uint: default " + default(uint) + ", min " + uint.MinValue + ", max " + uint.MaxValue);
		Console.WriteLine("Type long: default " + default(long) + ", min " + long.MinValue + ", max " + long.MaxValue);
		Console.WriteLine("Type ulong: default " + default(ulong) + ", min " + ulong.MinValue + ", max " + ulong.MaxValue);
		Console.WriteLine("Type float: default " + default(float) + ", min " + float.MinValue + ", max " + float.MaxValue);
		Console.WriteLine("Type double: default " + default(double) + ", min " + double.MinValue + ", max " + double.MaxValue);
		Console.WriteLine("Type decimal: default " + default(decimal) + ", min " + decimal.MinValue + ", max " + decimal.MaxValue);
		Console.WriteLine("Type byte: default " + default(bool));
		Console.WriteLine("Type byte: default " + default(string));
		Console.WriteLine("Type byte: default " + default(char));
		// !!! неправильный формат вывода на экран, внимательно просмотри условие
		// !!! а последнии 3.... на экране вообще не ясно что делают...
		Console.ReadKey();
	}
// # не оставляй такие пробелы

}

