using System;
using Model.Manager.States;

namespace LinuxClient.States
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
			_CurrentState = DialogStates.NotDefined;
		}

		public int getState()
		{
			return (int)_CurrentState;
		}

		public DialogStates CurrentState
		{
			get {
				return _CurrentState;
			}
			set {
				_CurrentState = value;
			}
		}

		private DialogStates _CurrentState;
	}
}
	