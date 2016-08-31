//KWVH

using System;
using Gtk;

namespace WWG
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			IntroWindow win = new IntroWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
