using System;
using LinuxClient.States;

namespace LinuxClient.Dialogs
{
	public partial class LoginDialog : Gtk.Dialog
	{
		public LoginDialog ()
		{
			this.Build ();
			CurrentState = new DialogState ();
		}

		protected void onCancelClicked (object sender, EventArgs e)
		{
			CurrentState.CurrentState = DialogState.DialogStates.Canceled;
			Destroy ();
		}

		protected void onOkClicked (object sender, EventArgs e)
		{
			CurrentState.CurrentState = DialogState.DialogStates.Accepted;
			Destroy ();
		}

		public DialogState getState()
		{
			return CurrentState;
		}

		DialogState CurrentState;
	}
}

