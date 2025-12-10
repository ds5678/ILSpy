using System;

namespace ICSharpCode.Decompiler.Tests.TestCases.Pretty
{
	internal class FieldKeyword
	{
		public int ValidatedProperty {
			get;
			set {
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException();
				}
				field = value;
			}
		}

		public string LazyProperty {
			get {
				if (field == null)
				{
					field = "default";
				}
				return field;
			}
			set;
		}

		public int NotifyProperty {
			get;
			set {
				if (field != value)
				{
					field = value;
					OnPropertyChanged();
				}
			}
		}

		public int ReadOnlyWithInit {
			get {
				if (field == 0)
				{
					field = 42;
				}
				return field;
			}
		}

		private void OnPropertyChanged()
		{
		}
	}
}
