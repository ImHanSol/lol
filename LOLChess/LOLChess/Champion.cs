using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLChess
{
	public abstract class Champion
	{
		private string name;
		private string element;
		private string sClass;

		public Champion(string chamName, string chamElement, string chamClass)
		{
			name = chamName;
			element = chamElement;
			sClass = chamClass;
		}

		public virtual string GetName => name;
		public string GetElement => element;
		public string GetClass => sClass;
	}

    class Aatrox : Champion
    {
        public Aatrox(string chamName, string chamElement, string chamClass) : base(chamName, chamElement, chamClass) { }
    }

    class Nami : Champion
    {
        public Nami(string chamName, string chamElement, string chamClass) : base(chamName, chamElement, chamClass) { }
    }
}
