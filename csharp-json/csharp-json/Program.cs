using System;
using CsharpJson;

namespace csharpjson
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			dynamic obj = Json.New ();
			obj.foo = "Foo!";
			obj.bar = Json.New ();
			obj.bar.baz = "Bar!";
			obj.arr = new int[] { 1,2,3 };
			Console.WriteLine (obj.ToString());
			Console.ReadKey ();
		}
	}
}
