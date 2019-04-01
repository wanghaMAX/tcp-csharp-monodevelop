using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using GLib;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    TcpClient tcpclient;
    NetworkStream sendStream;
    System.Threading.Thread thread;
    int bufferSize = 4 * 1024;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        if(tcpclient != null)
        {
            thread.Abort();
            tcpclient.Close();
        }
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnConnect(object sender, EventArgs e)
    {
        if (entry_ip.Text.Trim() == string.Empty)
        {
            return;
        }
        if (entry_port.Text.Trim() == string.Empty)
        {
            return;
        }
        IPAddress ip = IPAddress.Parse(entry_ip.Text);
        tcpclient = new TcpClient();
        tcpclient.Connect(ip, int.Parse(entry_port.Text));
        label1.Text = "start Connect...";
        if (tcpclient.Connected)
        {
            label1.Text = "connect succeed";
        }
        else
        {
            label1.Text = "connect fail";
            return;
        }
        // get the stream 
        sendStream = tcpclient.GetStream();
        // start a thread to receive msg
        thread = new System.Threading.Thread(new ThreadStart(ListenerServer));
        thread.Start();
        }

    protected void OnSend(object sender, EventArgs e)
    {
        if (tcpclient != null)
        {
            if (entry_send.Text.Trim() != string.Empty)
            {
                string msg = entry_send.Text;
                // put the msg to the buffer
                byte[] buffer = Encoding.Default.GetBytes(msg);
                // write the buffer to the stream
                // lock (sendStream)
                // {
                sendStream.Write(buffer, 0, buffer.Length);
                textview_receive.Buffer.Text = "send :" + msg +"\n";
                label1.Text = "Send succeed!";
                // }
                entry_send.Text = "";
            }
            else
            {
                label1.Text = "send error";
                return;
            }
        }
    }
    public void ListenerServer()
    {
        do
        {
            try
            {
                int readsize;
                byte[] buffer = new byte[bufferSize];
                lock (sendStream)
                {
                    readsize = sendStream.Read(buffer, 0, bufferSize);
                }
                if (readsize == 0)
                    return;
                textview_receive.Buffer.Text = "from server:\n"+Encoding.Default.GetString(buffer,0,readsize);
            }
            catch {
                label1.Text = "error";
            }
        } while (true);
    }

    protected void OnDisConnect(object sender, EventArgs e)
    {
        tcpclient.Close();
        thread.Abort();
    }
}
