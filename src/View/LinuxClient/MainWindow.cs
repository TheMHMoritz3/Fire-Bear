using System;

namespace LinuxClient
{
	public partial class MainWindow : Gtk.Window
	{
		public MainWindow () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			UserView = new Gtk.TreeView ();
			Gtk.TreeViewColumn user = new Gtk.TreeViewColumn ();
			user.Title = "TestUser";
			UserView.AppendColumn (user);
			frame1.Add (UserView);
		}


		Gtk.TreeView UserView;
	}
}

