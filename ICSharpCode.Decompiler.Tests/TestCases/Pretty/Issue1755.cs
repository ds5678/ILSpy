namespace ICSharpCode.Decompiler.Tests.TestCases.Pretty
{
	internal class Issue1755
	{
		public delegate void MyDelegate();
		private MyDelegate field;
		public MyDelegate Property { get; set; }

		private void Receive(MyDelegate d)
		{
		}
		private void Method()
		{
		}

		public void AddAssignMethodReferenceToField()
		{
			field += Method;
		}

		public void AddAssignMethodReferenceToFieldAndUseValue()
		{
			Receive(field += Method);
		}

		public void AddAssignMethodReferenceToLocal(MyDelegate p)
		{
			p += Method;
		}

		public void AddAssignMethodReferenceToLocalAndUseValue(MyDelegate p)
		{
			Receive(p += Method);
		}

		public void AddAssignMethodReferenceToProperty()
		{
			Property += Method;
		}

		public void AddAssignMethodReferenceToPropertyAndUseValue()
		{
			Receive(Property += Method);
		}
	}
}
