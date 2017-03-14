using System;

namespace LinuxClient
{
	public partial class DialogState : Gtk.ActionGroup
	{
		public DialogState () :
			base ("LinuxClient.DialogState")
		{
			this.Build ();
		}
	}
}

