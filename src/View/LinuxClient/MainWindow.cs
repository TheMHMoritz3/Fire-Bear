using System;
using LinuxClient.Dialogs;

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
		protected void onLoginActionClicked (object sender, EventArgs e)
		{
			LoginDialog dialog = new LoginDialog();
			dialog.Show();
		}
	}
}

