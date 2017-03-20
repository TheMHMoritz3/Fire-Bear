using System;
using LinuxClient.States;

namespace LinuxClient.Dialogs
{
	public partial class LoginDialog : Gtk.Dialog
	{
		public LoginDialog ()
		{
			this.Build ();
			_CurrentState = new DialogState ();
		}

		protected void onCancelClicked (object sender, EventArgs e)
		{
			_CurrentState.CurrentState = DialogState.DialogStates.Canceled;
			Destroy ();
		}

		protected void onOkClicked (object sender, EventArgs e)
		{
			_CurrentState.CurrentState = DialogState.DialogStates.Accepted;
			Destroy ();
		}

		public DialogState getState()
		{
			return _CurrentState;
		}

		private DialogState _CurrentState;
	}
}

