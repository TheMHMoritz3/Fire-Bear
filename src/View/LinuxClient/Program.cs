using System;
using Gtk;

namespace LinuxClient
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.DeleteEvent += onDelete;
			win.Show ();
			Application.Run ();
		}

		static void onDelete (object o, DeleteEventArgs e)
		{
			Application.Quit ();
		}
	}
}
