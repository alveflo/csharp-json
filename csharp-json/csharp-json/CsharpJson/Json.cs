using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpJson
{
	public class Json
	{
		public static string Stringify(DynamicGracefulDictionary json)
		{
			return json.ToString ();
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

