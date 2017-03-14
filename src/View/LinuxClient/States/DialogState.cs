using System;
using Model.Manager.States;

namespace LinuxClient
{
	public class DialogState : IState
	{
		public enum DialogStates
		{
			Accepted = 0,
			Canceled = 1,
			NotDefined = 2
		};

		public DialogState ()
		{
			throw new NotImplementedException ("LinuxClient.DialogState.DialogState()");
		}

		public int getState()
		{
			throw new NotImplementedException ("LinuxClient.DialogState.getState()");
		}
	}
}
	