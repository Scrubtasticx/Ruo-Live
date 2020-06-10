using System;

using Server;
using Server.Gumps;

namespace Server.Gumps.Widgets
{
	public interface IGumpWidget
	{
		Gump Parent { get; }
		int X { get; set; }
		int Y { get; set; }

		void Add();
	}
}
