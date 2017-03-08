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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsClient.Widgets.ContactDialog
{
    /// <summary>
    /// Interaction logic for ContactDialogButtonBox.xaml
    /// </summary>
    public partial class ContactDialogButtonBox : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ContactDialogButtonBox()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Is Triggered if Add is Clicked
        /// </summary>
        public event EventHandler AddClicked;
        /// <summary>
        /// Is Triggered if Cancel is Clicked
        /// </summary>
        public event EventHandler CancelClicked;
        /// <summary>
        /// Forwars click on CancelButton to event CancelClicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onCancelClicked(object sender, RoutedEventArgs e)
        {
            CancelClicked(sender, e);
        }
        /// <summary>
        /// Forwards click on AddButton to event AddClicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onAddClicked(object sender, RoutedEventArgs e)
        {
            AddClicked(sender, e);
        }
    }
}
