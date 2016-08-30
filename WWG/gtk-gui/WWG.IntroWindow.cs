
// This file has been generated by the GUI designer. Do not modify.
namespace WWG
{
	public partial class IntroWindow
	{
		private global::Gtk.Fixed fixed1;
		
		private global::Gtk.Image image1;
		
		private global::Gtk.Button playButton;
		
		private global::Gtk.Button exitButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget WWG.IntroWindow
			this.Name = "WWG.IntroWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("WWG v 2.0");
			this.WindowPosition = ((global::Gtk.WindowPosition)(2));
			this.AllowShrink = true;
			// Container child WWG.IntroWindow.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.image1 = new global::Gtk.Image ();
			this.image1.Name = "image1";
			this.image1.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("WWG.Images.wiz-hat.png");
			this.fixed1.Add (this.image1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.image1]));
			w1.X = 57;
			w1.Y = 10;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.playButton = new global::Gtk.Button ();
			this.playButton.CanFocus = true;
			this.playButton.Name = "playButton";
			this.playButton.UseUnderline = true;
			this.playButton.Label = global::Mono.Unix.Catalog.GetString ("Play");
			this.fixed1.Add (this.playButton);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.playButton]));
			w2.X = 22;
			w2.Y = 142;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.exitButton = new global::Gtk.Button ();
			this.exitButton.CanFocus = true;
			this.exitButton.Name = "exitButton";
			this.exitButton.UseUnderline = true;
			this.exitButton.Label = global::Mono.Unix.Catalog.GetString ("Exit");
			this.fixed1.Add (this.exitButton);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.exitButton]));
			w3.X = 265;
			w3.Y = 142;
			this.Add (this.fixed1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 322;
			this.DefaultHeight = 294;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.playButton.Clicked += new global::System.EventHandler (this.OnPlayButtonClicked);
			this.exitButton.Clicked += new global::System.EventHandler (this.OnExitButtonClicked);
		}
	}
}