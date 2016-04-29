using System;

namespace CsharpJson
{
	public class Json
	{
		public static string Stringify(Json json)
		{
			throw new NotImplementedException ();
		}

		public static Json Parse(string jsonString)
		{
			throw new NotImplementedException ();
		}

		public static DynamicGracefulDictionary New ()
		{
			return new DynamicGracefulDictionary (new GracefulDictionary ());
		}
	}
}

