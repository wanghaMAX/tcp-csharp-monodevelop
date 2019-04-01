using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Gtk;
using System.Text;

public partial class MainWindow : Gtk.Window
{
    TcpListener tcplistener;
    Thread t;
    TcpClient client;
    NetworkStream stream;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnConnect(object sender, EventArgs e)
    {
        tcplistener = new TcpListener(IPAddress.Any,int.Parse(entry1.Text));
        tcplistener.Start();
        t = new Thread(Server)
        {
            IsBackground = true
        };
        t.Start(tcplistener);
    }

    private void Server(object o) {
        TcpListener list = o as TcpListener;
        label7.Text = "connect succeed";
        const int bufferSize = 4 * 1024;
        client = list.AcceptTcpClient();
        label7.Text = client.Client.RemoteEndPoint.ToString() + " is connected.";
        while (true)
        {
            stream = client.GetStream();
            byte[] b = new byte[bufferSize];
            int n = stream.Read(b, 0, bufferSize);
            string str = Encoding.UTF8.GetString(b);
            textview2.Buffer.Text = str;
        }
    }

    protected void UnConnect(object sender, EventArgs e)
    {
        label7.Text = "Nothing is connected.";
        stream.Close();
        client.Close();
        t.Abort();
    }

    protected void OnSend(object sender, EventArgs e)
    {
        if(!IsOnline(client))
        {
            label7.Text = "Nothing is connected.";
        }
        else
        {
            byte[] tex = Encoding.Default.GetBytes(entry2.Text);
            stream.Write(tex, 0, tex.Length);
            entry2.Text = "";
        }
    }
    private bool IsOnline(TcpClient c)
    {
        return c.Client.Connected;
    }
}
