using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Concurrent;
using MessagePack;

namespace IoTTilesAudioStreaming
{
    public partial class Form1 : Form
    {
        private TcpClient _TcpClient;
        private NetworkStream _netStream;
        private SslStream _ssl;
        private bool _startRecordingLock = true;
        private bool _lock = false;
        public AudioRead _audioRead = new AudioRead();
        private FixedSizedQueue<byte[]> SendQueue = new FixedSizedQueue<byte[]>(32);
        private FixedSizedQueue<byte[]> RecieveQueue = new FixedSizedQueue<byte[]>(32);
        public AudioMsgPack _recieve;
        public AudioMsgPack _send;
        private Timer _audioTimer;

        public Form1()
        {
            InitializeComponent();

            _audioTimer = new Timer();
            _audioTimer.Interval = 5;
            _audioTimer.Tick += SendData;
            _audioTimer.Start();

            _send = new AudioMsgPack()
            {
                mic = false,
                speaker = false,
                mp3 = null
            };
        }

        private void SendData(object sender, EventArgs e)
        {
            if (_lock)
            {
                if (_startRecordingLock) // only want to start recording once for the request
                {
                    _startRecordingLock = false;
                    _audioRead.StartRecording(_ssl);
                }
                //    _send.mic = false;
                //    _send.speaker = true;
                //    byte[] mp3;
                //    bool success = SendQueue.TryDequeue(out mp3);
                //    if (success)
                //    {
                //        _send.mp3 = mp3;
                //        var dataToSend = MessagePackSerializer.Serialize(_send);
                //        textBox1.AppendText(Encoding.UTF8.GetString(dataToSend));
                //        _ssl.Write(dataToSend, 0, dataToSend.Length);
                //    }
                //}
            }
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("USB Driver Thread Started.");
            _TcpClient = new TcpClient();
            var result = _TcpClient.BeginConnect("192.168.0.201", 12345, null, null);
            var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(2));
            if (!success)
            {
                Console.WriteLine("Failed to connect to device");
            }
            else
            {
                _TcpClient.EndConnect(result);
                _netStream = _TcpClient.GetStream();
                _ssl = new SslStream(_TcpClient.GetStream(), false, new RemoteCertificateValidationCallback((obj, a, b, c) => true));
                _ssl.AuthenticateAsClient("iot.duality.co.nz");
            }
        }

        private void SendCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SendCb.Checked)
            {
                _lock = true;


            }
            else
            {
                _lock = false;
            }
        }
    }
}
