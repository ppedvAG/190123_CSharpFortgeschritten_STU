using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Serialisierung
{
    class Socket_Demo
    {
        // Uralter Beispielcode aus 2014 :)

        // public void Demo()
        //{
        //    s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //    s.Bind(new IPEndPoint(IPAddress.Any, 5555));
        //    s.Listen(3);
        //    s.BeginAccept(new AsyncCallback(callback), s);
        //}
        //// Callback für BeginAccept:
        //private void callback(IAsyncResult res) // Parameter immer gleich
        //{
        //    Socket s = (Socket)res.AsyncState; // In .AsynchState ist das Objekt drinnen
        //    Socket c = s.EndAccept(res);
        //    c.Send(Encoding.Default.GetBytes("Hallo vom Server"));
        //    byte[] buffer = new byte[1024];
        //    c.BeginReceive(buffer, 0, 1024, SocketFlags.None, new AsyncCallback(recieve), new Object[] { s, buffer, c }); // alternative : klasse generieren

        //}
        //private void recieve(IAsyncResult res)
        //{
        //    object[] z = (object[])res.AsyncState;
        //    int anz = (z[2] as Socket).EndReceive(res);
        //    //Dispatcher.Invoke((Action)delegate
        //    //{
        //    //    ListBoxRandom.Items.Add((Encoding.Default.GetString(z[1] as byte[], 0, anz)));
        //    //});
        //    (z[2] as Socket).Close();
        //    s.BeginAccept(new AsyncCallback(callback), s);
        //}

        //private void demo()
        //{

        //  Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //    s.BeginConnect(new IPEndPoint(IPAddress.Loopback, 5555), new AsyncCallback(connectcallback), s);
        //}
        //private void connectcallback(IAsyncResult res)
        //{
        //    //(res.AsyncState as Socket).EndConnect(res);
        //    byte[] buffer = new byte[max_size];
        //    (res.AsyncState as Socket).BeginReceive(buffer, 0, 1024, SocketFlags.None, new AsyncCallback(callback), new Object[] { (res.AsyncState as Socket), buffer }); // alternative : klasse generieren
        //}

        //private void callback(IAsyncResult res)
        //{
        //    object[] z = (object[])res.AsyncState;
        //    int anz = (z[0] as Socket).EndReceive(res);
        //    // MessageBox.Show(Encoding.Default.GetString(z[1] as byte[], 0, anz));
        //    (z[0] as Socket).Send(Encoding.Default.GetBytes("Randomzahl: " + new Random().Next(0, 100)));
        //}
    }
}
