using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WindowsClient.States.ConatactDialog;

namespace WindowsClient.ContactDialog
{
    /// <summary>
    /// Interaction logic for CreateContactDialog.xaml
    /// </summary>
    public partial class CreateContactDialog : Window
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CreateContactDialog()
        {
            InitializeComponent();
            State = new ContactDialogState();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onAddClicked(object sender, EventArgs e)
        {
            State.CurrentState = ContactDialogState.ContactDialogStates.Accepted;
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onCancelClicked(object sender, EventArgs e)
        {
            State.CurrentState = ContactDialogState.ContactDialogStates.Canceled;
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ContactDialogState contactDialogState()
        {
            return State;
        }

        private ContactDialogState State;
    }
}
