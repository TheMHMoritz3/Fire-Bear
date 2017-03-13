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
			win.DeleteEvent += OnDelete;
			win.Show ();
			Application.Run ();
		}

		static void OnDelete (object o, DeleteEventArgs e)
		{
			Application.Quit ();
		}
	}
}
