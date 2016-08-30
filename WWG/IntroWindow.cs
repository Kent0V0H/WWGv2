using System;
using Gtk;

namespace WWG
{
	public partial class IntroWindow : Gtk.Window
	{
		public IntroWindow () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnPlayButtonClicked (object sender, EventArgs e)
		{
			MainWindow win = new MainWindow ();
			this.Hide ();
			win.Show ();
		}

		protected void OnExitButtonClicked (object sender, EventArgs e)
		{
			Application.Quit ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}
	}
}

