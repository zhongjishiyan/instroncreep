using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.IO.Pipes;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;


namespace PipesServerTest
{
    // Delegate for passing received message back to caller




    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TransferData
    {


        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I2)]
        public Int16[] Id;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.R4)]
        public float[] pos;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.R4)]
        public float[] load;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.R4)]
        public float[] extA;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.R4)]
        public float[] extB;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.R4)]
        public float[] extAve;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.R8)]
        public double[] time;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.R4)]
        public float[] Temperature1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.R4)]
        public float[] Temperature2;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.R4)]
        public float[] Temperature3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I2)]
        public Int16[] State;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.R4)]
        public float[] ControlValue;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.R4)]
        public float[] unbalancedness;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.R4)]
        public float[] Temperaturecontrol;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.R4)]
        public float[] temperaturegradient;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.R4)]
        public float[] testtime; //试验时间

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I8)]
        public long[] wavecount; //波形个数

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I8)]
        public long[] cycliccount; //循环次数


        public ulong tcount;


        public void init()
        {
            int size = 100;

            Id = new Int16[size];
            pos = new float[size];
            load = new float[size];
            extA = new float[size];
            extB = new float[size];
            extAve = new float[size];

            time = new double[size];
            Temperature1 = new float[size];
            Temperature2 = new float[size];
            Temperature3 = new float[size];
            State = new Int16[size];
            ControlValue = new float[size];
            unbalancedness = new float[size];
            Temperaturecontrol = new float[size];
            temperaturegradient = new float[size];
            testtime = new float[size];
            wavecount = new long[size];
            cycliccount = new long[size];
        }


    }


    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TransferCmd
    {

        public double speed;
        public double dest;
        public int controlmode;

        public ulong tcount;



    }

    class PipeClient
    {
       

        NamedPipeClientStream pipeStream;


        public TransferCmd _TransferCmd;


        public void Send(byte[] SendStr, string PipeName, int count, int TimeOut = 1000)
        {
            try
            {
                NamedPipeClientStream pipeStream = new NamedPipeClientStream(".", PipeName, PipeDirection.Out, PipeOptions.Asynchronous);

                // The connect function will indefinitely wait for the pipe to become available
                // If that is not acceptable specify a maximum waiting time (in ms)
                pipeStream.Connect(TimeOut);
                Debug.WriteLine("[Client] Pipe connection established");


                pipeStream.BeginWrite(SendStr, 0, count, AsyncSend, pipeStream);
            }
            catch (TimeoutException oEX)
            {
                Debug.WriteLine(oEX.Message);
            }
        }



        private void AsyncSend(IAsyncResult iar)
        {
            try
            {
                // Get the pipe
                NamedPipeClientStream pipeStream = (NamedPipeClientStream)iar.AsyncState;

                // End the write
                pipeStream.EndWrite(iar);
                pipeStream.Flush();
                pipeStream.Close();
                pipeStream.Dispose();
            }
            catch (Exception oEX)
            {
                Debug.WriteLine(oEX.Message);
            }
        }

    }

    class PipeServer
    {
        public TransferData _TransferData;

        public delegate void DelegateMessage(byte[] Reply);


        public event DelegateMessage PipeMessage;
        string _pipeName;

        public void Listen(string PipeName)
        {
            try
            {
                // Set to class level var so we can re-use in the async callback method
                _pipeName = PipeName;
               

               NamedPipeServerStream pipeServer = new NamedPipeServerStream(PipeName, PipeDirection.In , 1, PipeTransmissionMode.Byte, PipeOptions.Asynchronous);

              

                // Wait for a connection
                pipeServer.BeginWaitForConnection(new AsyncCallback(WaitForConnectionCallBack), pipeServer);
            }
            catch (Exception oEX)
            {
                Debug.WriteLine(oEX.Message);
            }
        }

        private void WaitForConnectionCallBack(IAsyncResult iar)
        {
            try
            {


                // Get the pipe
                NamedPipeServerStream pipeServer = (NamedPipeServerStream)iar.AsyncState;
                // End waiting for the connection
                pipeServer.EndWaitForConnection(iar);
                int l = Marshal.SizeOf(_TransferData);

                byte[] buffer = new byte[l];

                // Read the incoming message
                pipeServer.Read(buffer, 0, l); 

                // Convert byte buffer to string
                //  string stringData = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                // Debug.WriteLine(stringData + Environment.NewLine);

                // Pass message back to calling form
              
               // char[] stringData = Encoding.UTF8.GetChars(buffer, 0,l); 
                PipeMessage.Invoke(buffer);




                // Kill original sever and create new wait server
                pipeServer.Close();
                pipeServer = null;
                pipeServer = new NamedPipeServerStream(_pipeName, PipeDirection.In, 1, PipeTransmissionMode.Byte, PipeOptions.Asynchronous);

                // Recursively wait for the connection again and again....
                pipeServer.BeginWaitForConnection(new AsyncCallback(WaitForConnectionCallBack), pipeServer);
            }
            catch
            {
                return;
            }
        }
    }
}
