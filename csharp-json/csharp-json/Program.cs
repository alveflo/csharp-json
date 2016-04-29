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
			Console.WriteLine (obj.foo);
			Console.WriteLine (obj.bar.baz);
		}
	}
}
