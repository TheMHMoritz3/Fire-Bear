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
using WindowsClient.Manager;
using WindowsClient.Items;
using Model.Manager;
using Model.Data;
using System.Threading;

namespace WindowsClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            createInstanceManager();
            //Header.Text = Manager.generateMenuManager().WidgetArray[0].Title;
            //Panel.Children.Add(Manager.generateMenuManager().getContentOfCurrentItem());
            IConnection connection = new IConnection();
            //Thread ConnectionThread = new Thread(()=>connection.openConnection("jabber.german-software-engineers.com", 5222, new LoginData("the_mhmoritz3","", "german-software-engineers.com")));
            //ConnectionThread.Start();
        }

        public void createInstanceManager()
        {
            //Manager = new InstanceManager();
            //ViewSliderItem[] items = Manager.generateMenuManager().WidgetArray;
            //foreach (ViewSliderItem item in items)
                //ListOfContent.Items.Add(item.Title);
        }

        private InstanceManager Manager;

        private void ListOfContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //int selectedIndex = ListOfContent.SelectedIndex;

            //if (selectedIndex < 0)
            //    return;

            //Panel.Children.Remove(Manager.generateMenuManager().getContentOfCurrentItem());
            //Manager.generateMenuManager().setCurrentItem(selectedIndex);
            //Header.Text = Manager.generateMenuManager().WidgetArray[selectedIndex].Title;
            //Panel.Children.Add(Manager.generateMenuManager().getContentOfCurrentItem());
            //Controls.Add(newPanelButton); Manager.getContentOfCurrentItem();
        }
    }
}
