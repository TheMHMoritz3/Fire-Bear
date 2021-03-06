
// This file has been generated by the GUI designer. Do not modify.
namespace LinuxClient
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.Action FileAction;
		
		private global::Gtk.Action LoginAction;
		
		private global::Gtk.Action LogoutAction;
		
		private global::Gtk.Action OptionsAction;
		
		private global::Gtk.Action ServerOptionsAction;
		
		private global::Gtk.Action ClientOptionsAction;
		
		private global::Gtk.Action HelpAction;
		
		private global::Gtk.Action HelpAction1;
		
		private global::Gtk.Action LicenceAction;
		
		private global::Gtk.Action ContributionAction;
		
		private global::Gtk.Action ThirdPartyAction;
		
		private global::Gtk.Action TwitterTheMHMoritz3Action;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.MenuBar menubar3;
		
		private global::Gtk.HPaned hpaned1;
		
		private global::Gtk.Frame frame1;
		
		private global::Gtk.Alignment GtkAlignment;
		
		private global::Gtk.VBox vbox5;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		
		private global::Gtk.TreeView treeview3;
		
		private global::Gtk.Button UserButton;
		
		private global::Gtk.Label GroupBoxLabel;
		
		private global::Gtk.VBox vbox4;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TreeView treeview2;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Entry entry1;
		
		private global::Gtk.Button button2;
		
		private global::Gtk.Statusbar statusbar2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LinuxClient.MainWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
			this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
			w1.Add (this.FileAction, null);
			this.LoginAction = new global::Gtk.Action ("LoginAction", global::Mono.Unix.Catalog.GetString ("Login"), null, null);
			this.LoginAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Login");
			w1.Add (this.LoginAction, null);
			this.LogoutAction = new global::Gtk.Action ("LogoutAction", global::Mono.Unix.Catalog.GetString ("Logout"), null, null);
			this.LogoutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Logout");
			w1.Add (this.LogoutAction, null);
			this.OptionsAction = new global::Gtk.Action ("OptionsAction", global::Mono.Unix.Catalog.GetString ("Options"), null, null);
			this.OptionsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Options");
			w1.Add (this.OptionsAction, null);
			this.ServerOptionsAction = new global::Gtk.Action ("ServerOptionsAction", global::Mono.Unix.Catalog.GetString ("Server-Options"), null, null);
			this.ServerOptionsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Server-Options");
			w1.Add (this.ServerOptionsAction, null);
			this.ClientOptionsAction = new global::Gtk.Action ("ClientOptionsAction", global::Mono.Unix.Catalog.GetString ("Client-Options"), null, null);
			this.ClientOptionsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Client-Options");
			w1.Add (this.ClientOptionsAction, null);
			this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
			this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
			w1.Add (this.HelpAction, null);
			this.HelpAction1 = new global::Gtk.Action ("HelpAction1", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
			this.HelpAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
			w1.Add (this.HelpAction1, null);
			this.LicenceAction = new global::Gtk.Action ("LicenceAction", global::Mono.Unix.Catalog.GetString ("Licence"), null, null);
			this.LicenceAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Licence");
			w1.Add (this.LicenceAction, null);
			this.ContributionAction = new global::Gtk.Action ("ContributionAction", global::Mono.Unix.Catalog.GetString ("Contribution"), null, null);
			this.ContributionAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Contribution");
			w1.Add (this.ContributionAction, null);
			this.ThirdPartyAction = new global::Gtk.Action ("ThirdPartyAction", global::Mono.Unix.Catalog.GetString ("Third Party"), null, null);
			this.ThirdPartyAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Third Party");
			w1.Add (this.ThirdPartyAction, null);
			this.TwitterTheMHMoritz3Action = new global::Gtk.Action ("TwitterTheMHMoritz3Action", global::Mono.Unix.Catalog.GetString ("Twitter TheMHMoritz3"), null, null);
			this.TwitterTheMHMoritz3Action.ShortLabel = global::Mono.Unix.Catalog.GetString ("Twitter TheMHMoritz3");
			w1.Add (this.TwitterTheMHMoritz3Action, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "LinuxClient.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Fire Bear");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child LinuxClient.MainWindow.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><menubar name='menubar3'><menu name='FileAction' action='FileAction'><menuitem name='LoginAction' action='LoginAction'/><menuitem name='LogoutAction' action='LogoutAction'/></menu><menu name='OptionsAction' action='OptionsAction'><menuitem name='ServerOptionsAction' action='ServerOptionsAction'/><menuitem name='ClientOptionsAction' action='ClientOptionsAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='HelpAction1' action='HelpAction1'/><separator/><menuitem name='LicenceAction' action='LicenceAction'/><menuitem name='ContributionAction' action='ContributionAction'/><menuitem name='ThirdPartyAction' action='ThirdPartyAction'/><menuitem name='TwitterTheMHMoritz3Action' action='TwitterTheMHMoritz3Action'/></menu></menubar></ui>");
			this.menubar3 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar3")));
			this.menubar3.Name = "menubar3";
			this.vbox2.Add (this.menubar3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.menubar3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 166;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.treeview3 = new global::Gtk.TreeView ();
			this.treeview3.CanFocus = true;
			this.treeview3.Name = "treeview3";
			this.GtkScrolledWindow1.Add (this.treeview3);
			this.vbox5.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.GtkScrolledWindow1]));
			w4.Position = 0;
			// Container child vbox5.Gtk.Box+BoxChild
			this.UserButton = new global::Gtk.Button ();
			this.UserButton.CanFocus = true;
			this.UserButton.Name = "UserButton";
			this.UserButton.UseUnderline = true;
			this.UserButton.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.vbox5.Add (this.UserButton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.UserButton]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.GtkAlignment.Add (this.vbox5);
			this.frame1.Add (this.GtkAlignment);
			this.GroupBoxLabel = new global::Gtk.Label ();
			this.GroupBoxLabel.Name = "GroupBoxLabel";
			this.GroupBoxLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Users</b>");
			this.GroupBoxLabel.UseMarkup = true;
			this.frame1.LabelWidget = this.GroupBoxLabel;
			this.hpaned1.Add (this.frame1);
			global::Gtk.Paned.PanedChild w8 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.frame1]));
			w8.Resize = false;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview2 = new global::Gtk.TreeView ();
			this.treeview2.CanFocus = true;
			this.treeview2.Name = "treeview2";
			this.GtkScrolledWindow.Add (this.treeview2);
			this.vbox4.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.GtkScrolledWindow]));
			w10.Position = 0;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry ();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.hbox1.Add (this.entry1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entry1]));
			w11.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button2 = new global::Gtk.Button ();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString ("Send");
			this.hbox1.Add (this.button2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button2]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox4.Add (this.hbox1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox1]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.hpaned1.Add (this.vbox4);
			this.vbox2.Add (this.hpaned1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hpaned1]));
			w15.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.statusbar2 = new global::Gtk.Statusbar ();
			this.statusbar2.Name = "statusbar2";
			this.statusbar2.Spacing = 6;
			this.vbox2.Add (this.statusbar2);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.statusbar2]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 1029;
			this.DefaultHeight = 479;
			this.Show ();
			this.LoginAction.Activated += new global::System.EventHandler (this.onLoginActionClicked);
			this.UserButton.Clicked += new global::System.EventHandler (this.onAddClicked);
		}
	}
}
