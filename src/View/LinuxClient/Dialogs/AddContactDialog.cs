using System;
using LinuxClient.States;

namespace LinuxClient.Dialogs
{
	public partial class AddContactDialog : Gtk.Dialog
	{
		public AddContactDialog ()
		{
			_CurrentState = new DialogState ();
			this.Build ();
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

