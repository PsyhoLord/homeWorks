using System;

class Constr{

	public	Constr(string str){

		for(int i = 0; i < str.Length; i++){
			Console.WriteLine(str[i] + ": dec" + (int)str[i] + " hex " + Convert.ToByte((int)str[i]).ToString("X"));
		}
	}

}

class Prog{
	static void Main(){
		Constr stringParse = new Constr("Hello world!");
	}
}


//using System;

//class Parse{
//	static void Main(){
//		string str = "Hello world!";
//
//		for(int i = 0; i < str.Length; i++){
//			Console.WriteLine(str[i] + ": dec" + (int)str[i] + " hex " + Convert.ToByte((int)str[i]).ToString("X"));
//		}
//	}
//}