
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.Label label1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Label label3;

	private global::Gtk.Entry entry1;

	private global::Gtk.Button button1;

	private global::Gtk.Button button2;

	private global::Gtk.Label label5;

	private global::Gtk.ScrolledWindow scrolledwindow1;

	private global::Gtk.TextView textview2;

	private global::Gtk.Label label6;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Entry entry2;

	private global::Gtk.Button button3;

	private global::Gtk.Label label7;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("TcpServer");
		this.vbox1.Add(this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Port : ");
		this.hbox1.Add(this.label3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label3]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.hbox1.Add(this.entry1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entry1]));
		w3.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Link");
		this.hbox1.Add(this.button1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button1]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button2 = new global::Gtk.Button();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("UnLink");
		this.hbox1.Add(this.button2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button2]));
		w5.Position = 3;
		w5.Expand = false;
		w5.Fill = false;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Receive");
		this.vbox1.Add(this.label5);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label5]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
		this.scrolledwindow1.CanFocus = true;
		this.scrolledwindow1.Name = "scrolledwindow1";
		this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow1.Gtk.Container+ContainerChild
		this.textview2 = new global::Gtk.TextView();
		this.textview2.CanFocus = true;
		this.textview2.Name = "textview2";
		this.scrolledwindow1.Add(this.textview2);
		this.vbox1.Add(this.scrolledwindow1);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.scrolledwindow1]));
		w9.Position = 3;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Send");
		this.vbox1.Add(this.label6);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label6]));
		w10.Position = 4;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.entry2 = new global::Gtk.Entry();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.hbox2.Add(this.entry2);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entry2]));
		w11.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.button3 = new global::Gtk.Button();
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString("Send");
		this.hbox2.Add(this.button3);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.button3]));
		w12.Position = 1;
		w12.Expand = false;
		w12.Fill = false;
		this.vbox1.Add(this.hbox2);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
		w13.Position = 5;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label7 = new global::Gtk.Label();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Nothing is connected now!");
		this.vbox1.Add(this.label7);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label7]));
		w14.Position = 6;
		w14.Expand = false;
		w14.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button1.Clicked += new global::System.EventHandler(this.OnConnect);
		this.button2.Clicked += new global::System.EventHandler(this.UnConnect);
		this.button3.Clicked += new global::System.EventHandler(this.OnSend);
	}
}
