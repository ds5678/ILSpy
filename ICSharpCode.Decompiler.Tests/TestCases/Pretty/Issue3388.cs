using System.Collections.Generic;

namespace ICSharpCode.Decompiler.Tests.TestCases.Pretty
{
	internal static class Issue3388
	{
		public struct Data
		{
			public void Deconstruct(out object o1, out object o2)
			{
				o1 = default;
				o2 = default;
			}
		}

		public static void Test(KeyValuePair<object, Data> pair)
		{
			var (key, (value, _)) = pair;

			Empty(key);
			Empty(value);
		}

		public static void Empty(object o) => _ = o;
	}
}
