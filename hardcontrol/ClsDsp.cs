
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using DoPE_HANDLE = System.Int32;
using XLNet;
using PipesServerTest;
namespace ClsStaticStation
{

    public class CDsp : ClsBaseControl
    {
        public TransferData MyTransferData;

        private byte[] _vchar;
        private ulong _ctr = 0;

        [DllImport("kernel32.dll")]
        public static extern UIntPtr SetThreadAffinityMask(IntPtr hThread,
       UIntPtr dwThreadAffinityMask);

        //得到当前线程的handler  
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetCurrentThread();

        //获取cpu的id号  
        public static ulong SetCpuID(int id)
        {
            ulong cpuid = 0;
            if (id < 0 || id >= System.Environment.ProcessorCount)
            {
                id = 0;
            }
            cpuid |= 1UL << id;

            return cpuid;
        }

        Mutex mt = new Mutex();//创建一个同步基元

        private double mstarttickcount;
        private int mspenum = 0;
        private RawDataDataGroup[] r = new RawDataDataGroup[1];
        private float[] rr;
        private System.Windows.Forms.Timer mtimer;
        public XLNet.XLDOPE.Data GGMsg;
        private RawDataStruct b;
        public short DeviceNum = 1;

        private int m_runstate;

        private PipeServer _pipeServer;
        private PipeClient _pipeClient;








        private double pos;
        private double load;
        private double ext;

        private double cmd;

        private double time;
        private double count;
       

        public List<CComLibrary.CmdSeg> mrunlist;


        private double mstarttime;
        private double moritime;

        public double mrunstarttime = 0;

        private double sensor4;
        private double sensor5;
        private double sensor6;
        private double sensor7;
        private double sensor8;


        private Queue<XLDOPE.MDataIno> mdatalist;


        public long oncount = 0;

        private Boolean mrun = false;//函数执行后置位

        private double m_keeptime;//保持时间

        private double m_keepstarttime;//开始保持时时间

        private bool m_keepstart = false;//开始保持

        private int m_returnstep;//返回步骤
        private int m_returncount;//返回次数


        public override void findzero(double speed)
        {

            short tan = 0;
            myedc.Move.OrgMove(XLDOPE.MOVE.UP, XLDOPE.CTRL.POS, speed, ref tan);
        }
        public byte[] StructTOBytes(object obj)
        {
            int size = Marshal.SizeOf(obj);
            //创建byte数组
            byte[] bytes = new byte[size];
            IntPtr structPtr = Marshal.AllocHGlobal(size);
            //将结构体拷贝到分配好的内存空间
            Marshal.StructureToPtr(obj, structPtr, false);
            //从内存空间拷贝到byte数组
            Marshal.Copy(structPtr, bytes, 0, size);


            //释放内存空间
            Marshal.FreeHGlobal(structPtr);


            return bytes;
        }

        public void SendTransferCmd()
        {
            _pipeClient._TransferCmd.FuncID = this.DeviceNum;
            _pipeClient._TransferCmd.tcount = _ctr;
            _vchar = StructTOBytes(_pipeClient._TransferCmd);

            int l = Marshal.SizeOf(_pipeClient._TransferCmd);



            _pipeClient.Send(_vchar, "TestPipe1", l, 10000);

            _ctr = _ctr + 1;

        }
        public override void DriveOn()
        {


        }
        public override void DriveOff()
        {

        }

        public override void CrossDown(int ctrlmode, double speed)
        {
            short tan = 0;

            double m = speed;




        }

        public override void btnzeroall()
        {
            for (int i = 0; i < m_Global.mycls.chsignals.Count; i++)
            {


                //清零

            }

        }

        public override void btnrestoreall()
        {

            for (int i = 0; i < m_Global.mycls.chsignals.Count; i++)
            {




                //复原

            }
        }



        public override void cleartime()
        {
            base.cleartime();
          




            


            if (CComLibrary.GlobeVal.filesave.Samplingmode == 0)
            {
                mt.WaitOne();

                mdatalist.Clear();

                mt.ReleaseMutex();


            }
        }

        public override void starttest(int spenum)
        {
            short k = 0;
            RawDataDataGroup d;

            oldcount = 0;
            mspenum = spenum;

            CComLibrary.GlobeVal.filesave.Extensometer_DataFrozenFlag = false;


            duanliebaohu = false;

            m_runstate = 0;

            mtestrun = true;


            _pipeClient._TransferCmd.cmdName = 121;

         

            SendTransferCmd();

            if (CComLibrary.GlobeVal.filesave.mcontrolprocess == 1) //中级试验
            {


                CComLibrary.GlobeVal.filesave.mseglist = new List<CComLibrary.CmdSeg>();


               



                int i = 0;



                int m = CComLibrary.GlobeVal.filesave.msegtestcount;

                for (i = 0; i < m; i++)
                {
                    CComLibrary.CmdSeg n = new CComLibrary.CmdSeg();
                    n.check = true;
                    n.controlmode = CComLibrary.GlobeVal.filesave.msegtest[i].controlmode;
                    n.speed = CComLibrary.GlobeVal.filesave.msegtest[i].speed;
                    n.destcontrolmode = CComLibrary.GlobeVal.filesave.msegtest[i].destcontrolmode;
                    n.dest = CComLibrary.GlobeVal.filesave.msegtest[i].dest;
                    n.keeptime = CComLibrary.GlobeVal.filesave.msegtest[i].keeptime;
                    n.cmd = CComLibrary.GlobeVal.filesave.msegtest[i].cmd;
                    n.action = CComLibrary.GlobeVal.filesave.msegtest[i].action;

                    if (CComLibrary.GlobeVal.filesave.msegtest[i].cyclicrun == true)
                    {
                        n.returncount = CComLibrary.GlobeVal.filesave.msegtest[i].cycliccount;
                        n.returnstep = CComLibrary.GlobeVal.filesave.msegtest[i].returnstep;
                    }
                    else
                    {
                        n.returncount = 0;
                        n.returnstep = 0;
                    }
                    CComLibrary.GlobeVal.filesave.mseglist.Add(n);
                }



                mrunlist = new List<CComLibrary.CmdSeg>();
                mrunlist.Clear();

                if (CComLibrary.GlobeVal.filesave.pretest_cmd.check == true)
                {
                    mrunlist.Add(CComLibrary.GlobeVal.filesave.pretest_cmd);
                    mrunlist[0].keeptime = 0;

                    mrunlist[0].action = 0;

                }

                for (i = 0; i < CComLibrary.GlobeVal.filesave.mseglist.Count; i++)
                {
                    if (CComLibrary.GlobeVal.filesave.mseglist[i].check == true)
                    {
                        mrunlist.Add(CComLibrary.GlobeVal.filesave.mseglist[i]);
                    }
                    else
                    {
                        break;
                    }

                }

                if (mrunlist.Count > 0)
                {
                }
                else
                {

                    MessageBox.Show("错误，您没有设置中级测试过程");
                    mtestrun = false;
                    return;
                }


                mcurseg = 0;



                for (int ii = mcurseg; ii < mrunlist.Count; ii++)
                {
                    if (mrunlist[ii].controlmode ==
                   mrunlist[ii].destcontrolmode)
                    {
                        k = 1;
                    }
                    else
                    {
                        k = 0;
                    }
                    if (mrunlist[ii].action == 1)
                    {
                        segstep(mrunlist[ii].cmd, mrunlist[ii].destorigin(),
                           Convert.ToInt16(mrunlist[ii].controlmode),
                             Convert.ToInt16(mrunlist[ii].destcontrolmode),
                            k, Convert.ToSingle(mrunlist[ii].speedorigin()),
                          mrunlist[ii].keeptime, mrunlist[ii].returnstep, mrunlist[ii].returncount, mrunlist[ii].action, mrunlist[ii].destmode);

                        mcurseg = ii;
                    }
                    else
                    {

                        if (ii == mcurseg)
                        {
                            segstep(mrunlist[ii].cmd, mrunlist[ii].destorigin(),
                       Convert.ToInt16(mrunlist[ii].controlmode),
                        Convert.ToInt16(mrunlist[ii].destcontrolmode),
                       k, Convert.ToSingle(mrunlist[ii].speedorigin()),
                       mrunlist[ii].keeptime, mrunlist[ii].returnstep, mrunlist[ii].returncount, mrunlist[ii].action, mrunlist[ii].destmode);

                            mcurseg = ii;
                        }
                        break;


                    }


                }


                total_returncount = 0;

                current_returncount = 0;


            }



            mrunstarttime = System.Environment.TickCount / 1000;



        }
        public override void DestStart(int ctrlmode, double dest, double speed)
        {

            short tan = 0;
            double destination;
            double mspeed;





        }

        public override void DestStop(int ctrlmode)
        {
            short tan = 0;





        }

        public override void CrossUp(int ctrlmode, double speed)
        {
            short tan = 0;
            double m = speed;





        }


        public override void CrossStop(int ctrlmode)
        {
            short tan = 0;


        }
        public override void endtest()
        {

            _pipeClient._TransferCmd.cmdName = 120;
          

            SendTransferCmd();


            mstarttime = 0;

            endcontrol();

            mtestrun = false;
            mrun = false;



            CComLibrary.GlobeVal.filesave.Extensometer_DataFrozenFlag = false;



            CrossStop(0);




            mtestrun = false;

            CComLibrary.GlobeVal.InitUserCalcChannel();//初始化用户自定义通道
        }


        public override void demotest(bool testing)
        {



        }

        public override int ConvertCtrlMode(int ctrl)
        {
            XLDOPE.CTRL t = default(XLDOPE.CTRL);
            if (ctrl == 0) //位移
            {
                t = XLDOPE.CTRL.POS;

            }
            if (ctrl == 1)  //负荷
            {
                t = XLDOPE.CTRL.LOAD;
            }

            if (ctrl == 2) //变形
            {
                t = XLDOPE.CTRL.EXTENSION;
            }

            return Convert.ToInt16(t);



        }
        public override bool getlimit(int ch)
        {
            return false;
        }

        public override bool getEmergencyStop()
        {
            return false;
        }
        public override void btnkey(Button b)
        {
            if (Convert.ToBoolean(b.Tag) == false)
            {
                b.ForeColor = System.Drawing.Color.Red;
                b.Tag = true;
                btnzero(b);

            }
            else
            {
                b.ForeColor = System.Drawing.Color.Black;

                b.Tag = false;
                restorezero(b);
            }


        }

        public override void btnzero(Button b)
        {

            for (int i = 0; i < m_Global.mycls.chsignals.Count; i++)
            {

                if (b.Text == m_Global.mycls.chsignals[i].cName)
                {
                    //if (m_Global.mycls.hardsignals[i].SignName == "Ch Disp")
                    if (i == 0)
                    {

                    }
                    if (i == 1)
                    // if (m_Global.mycls.hardsignals[i].SignName == "Ch Load")
                    {

                    }

                    if (i == 2)
                    //if (m_Global.mycls.hardsignals[i].SignName == "Ch Ext")
                    {

                    }
                    if (i == 3)
                    //if (m_Global.mycls.hardsignals[i].SignName == "Ch Sensor3")
                    {

                    }
                    if (i == 4)
                    //if (m_Global.mycls.hardsignals[i].SignName == "Ch Sensor4")
                    {

                    }

                    if (i == 5)
                    //if (m_Global.mycls.hardsignals[i].SignName == "Ch Sensor5")
                    {

                    }
                    if (i == 6)
                    // if (m_Global.mycls.hardsignals[i].SignName == "Ch Sensor6")
                    {

                    }
                    if (i == 7)

                    //if (m_Global.mycls.hardsignals[i].SignName == "Ch Sensor7")
                    {

                    }



                }
            }


        }
        void restorezero(Button b)
        {
            for (int i = 0; i < m_Global.mycls.chsignals.Count; i++)
            {
                if (b.Text == m_Global.mycls.chsignals[i].cName)
                {
                    if (i == 0)

                    //if (m_Global.mycls.hardsignals[i].SignName == "Ch Disp")
                    {


                    }
                    if (i == 1)

                    // if (m_Global.mycls.hardsignals[i].SignName == "Ch Load")
                    {


                    }
                    if (i == 2)
                    //if (m_Global.mycls.hardsignals[i].SignName == "Ch Ext")
                    {


                    }
                    if (i == 3)
                    //if (m_Global.mycls.hardsignals[i].SignName == "Ch Sensor3")
                    {


                    }
                    if (i == 4)
                    //if (m_Global.mycls.hardsignals[i].SignName == "Ch Sensor4")
                    {


                    }
                    if (i == 5)

                    //if (m_Global.mycls.hardsignals[i].SignName == "Ch Sensor5")
                    {


                    }
                    if (i == 6)
                    //if (m_Global.mycls.hardsignals[i].SignName == "Ch Sensor6")
                    {


                    }
                    if (i == 7)
                    //if (m_Global.mycls.hardsignals[i].SignName == "Ch Sensor7")
                    {


                    }


                }

            }
        }

        public override void setrunstate(int m)
        {

        }


        public override void segstep(int cmd, double dest, short firstctl, short destctl, short destkeepstyle, float speed, double keeptime, int reurnstep, int returncount, int action, int destmode)
        {

            bool b = false;
            short tan = 0;



            m_keeptime = keeptime;
            m_keepstart = false;
            keepingstate = false;

            m_returncount = returncount;
            m_returnstep = reurnstep;
            if (m_returncount > 0)
            {
                total_returncount = m_returncount;
            }

            m_runstate = 1;
            // myedc.Move.PosExt((XLDOPE.CTRL)ConvertCtrlMode(firstctl), Convert.ToSingle(speed), XLDOPE.LIMITMODE.NOT_ACTIVE, 5, (XLDOPE.CTRL)ConvertCtrlMode(destctl)
            //    , Convert.ToSingle(dest), (XLDOPE.DESTMODE)destmode, ref tan);

            mrun = true;


        }




        public CDsp()
        {
            _pipeClient = new PipeClient();

            _pipeServer = new PipeServer();
            _pipeServer.PipeMessage += new PipeServer.DelegateMessage(PipesMessageHandler);

            MyTransferData.init();

            rr = new float[10];
            GGMsg = new XLDOPE.Data();
            mdatalist = new Queue<XLDOPE.MDataIno>();


            mtimer = new System.Windows.Forms.Timer();
            mtimer.Tick += new EventHandler(mtimer_Tick);
            mtimer.Interval = 40;



            mstarttickcount = Environment.TickCount;

            mtimer.Start();


            //SetThreadAffinityMask(GetCurrentThread(), new UIntPtr(SetCpuID(0)));



        }


        public TransferData ByteToTransferData<TransferData>(byte[] dataBuffer)
        {
            object structure = null;
            int size = Marshal.SizeOf(typeof(TransferData));
            IntPtr allocIntPtr = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.Copy(dataBuffer, 0, allocIntPtr, size);
                structure = Marshal.PtrToStructure(allocIntPtr, typeof(TransferData));
            }
            finally
            {
                Marshal.FreeHGlobal(allocIntPtr);
            }
            return (TransferData)structure;

        }

        //采集数据
        private void PipesMessageHandler(byte[] message)
        {
            if (connected == false)

            {
                return;
            }

            _pipeServer._TransferData = ByteToTransferData<TransferData>(message);

            MyTransferData = _pipeServer._TransferData;


            XLDOPE.Data m1 = new XLDOPE.Data();

            m1.Sensor = new double[16];

            m1.Sensor[0] = _pipeServer._TransferData.CHANNEL_S[m_Global.currentmachineId];
            m1.Sensor[1] = _pipeServer._TransferData.CHANNEL_F[m_Global.currentmachineId];


            m1.Sensor[2] = _pipeServer._TransferData.CHANNEL_4[m_Global.currentmachineId];
            m1.Sensor[3] = _pipeServer._TransferData.CHANNEL_5[m_Global.currentmachineId];
            m1.Sensor[4] = _pipeServer._TransferData.CHANNEL_E[m_Global.currentmachineId];
            m1.Sensor[5] = _pipeServer._TransferData.CHANNEL_7[m_Global.currentmachineId];
            m1.Sensor[6] = _pipeServer._TransferData.CHANNEL_8[m_Global.currentmachineId];
            m1.Sensor[7] = _pipeServer._TransferData.CHANNEL_9[m_Global.currentmachineId];
            m1.Cycles =Convert.ToInt32( _pipeServer._TransferData.CYCLE_COUNT[m_Global.currentmachineId]);

            m1.Time = _pipeServer._TransferData.TEST_TIME[m_Global.currentmachineId];
            XLDOPE.MDataIno ma = new XLDOPE.MDataIno();
            ma.Id = 0;
            ma.mydatainfo = m1;


            mt.WaitOne();
            if (mdatalist.Count > 300)
            {
                mdatalist.Dequeue();
            }

            mdatalist.Enqueue(ma);
            mt.ReleaseMutex();


        }


        ~CDsp()
        {
            mtimer.Stop();

        }

        public override void Exit()
        {
            base.Exit();
            mtimer.Stop();

            if (_pipeServer == null)
            {
            }
            else
            {
                _pipeServer.PipeMessage -= new PipeServer.DelegateMessage(PipesMessageHandler);
                _pipeServer = null;
                _pipeClient = null;
            }
            mdatalist.Clear();

        }
        public override int getrunstate() // 1运行 0 停止
        {
           

            return m_runstate;
        }
        void mtimer_Tick(object sender, EventArgs e)
        {
            short k;

            Timer();

            if (mtestrun == false)
            {
                return;
            }

            if (mrun == true)
            {

                if ((this.getrunstate() == 0))
                {


                    if (m_keeptime > 0)
                    {
                        keepingstate = true;

                        if (m_keepstart == false)
                        {
                            m_keepstart = true;

                            m_keepstarttime = System.Environment.TickCount / 1000.0;


                        }
                        else
                        {

                            keepingtime = System.Environment.TickCount / 1000.0 - m_keepstarttime;

                            if (keepingtime >= m_keeptime)
                            {
                                m_keeptime = -1;
                            }

                        }

                    }
                    else
                    {
                        mrun = false;
                        keepingstate = false;

                        if (m_returncount > 0)
                        {
                            current_returncount = current_returncount + 1;


                            mrunlist[mcurseg].mseq.finishedloopcount = current_returncount;


                            CComLibrary.GlobeVal.filesave.mseglist[mcurseg].mseq.finishedloopcount = current_returncount;


                            if (current_returncount >= m_returncount)
                            {
                                CComLibrary.GlobeVal.filesave.mseglist[mcurseg].mseq.runfinished = true;
                                CComLibrary.GlobeVal.filesave.mseglist[mcurseg].mseq.mfinishedcount = CComLibrary.GlobeVal.filesave.mseglist[mcurseg].mseq.mcurrentcount;


                                mcurseg = mcurseg + 1;
                                total_returncount = 0;
                                current_returncount = 0;

                                CComLibrary.SequenceFile sqf = new CComLibrary.SequenceFile();

                                for (int i = 0; i < mrunlist.Count; i++)
                                {
                                    sqf.add(mrunlist[i].mseq);
                                }
                                sqf.SerializeNow(System.Windows.Forms.Application.StartupPath + "\\AppleLabJ\\sequence\\" + CComLibrary.GlobeVal.filesave.SequenceName);

                                //  CComLibrary.GlobeVal.filesave.SerializeNow(CComLibrary.GlobeVal.filesave.methodname);



                            }
                            else
                            {
                                int bcur = mcurseg;
                                mcurseg = m_returnstep - 1;

                                for (int i = mcurseg; i < bcur; i++)
                                {
                                    CComLibrary.GlobeVal.filesave.mseglist[i].mseq.mfinishedcount = 0;
                                    CComLibrary.GlobeVal.filesave.mseglist[i].mseq.runfinished = false;
                                }

                            }


                        }
                        else
                        {

                            CComLibrary.GlobeVal.filesave.mseglist[mcurseg].mseq.runfinished = true;
                            CComLibrary.GlobeVal.filesave.mseglist[mcurseg].mseq.mfinishedcount = CComLibrary.GlobeVal.filesave.mseglist[mcurseg].mseq.mcurrentcount;


                            mcurseg = mcurseg + 1;
                        }

                        if ((mcurseg < mrunlist.Count))
                        {

                            for (int ii = mcurseg; ii < mrunlist.Count; ii++)
                            {
                                if (mrunlist[ii].controlmode ==
                               mrunlist[ii].destcontrolmode)
                                {
                                    k = 1;
                                }
                                else
                                {
                                    k = 0;
                                }
                                if (mrunlist[ii].action == 1)
                                {
                                    segstep(mrunlist[ii].cmd, mrunlist[ii].dest,
                                       Convert.ToInt16(mrunlist[ii].controlmode),
                                         Convert.ToInt16(mrunlist[ii].destcontrolmode),
                                        k, Convert.ToSingle(mrunlist[ii].speed),
                                      mrunlist[ii].keeptime, mrunlist[ii].returnstep, mrunlist[ii].returncount, mrunlist[ii].action, mrunlist[ii].destmode);
                                }
                                else
                                {
                                    if (ii == mcurseg)
                                    {
                                        segstep(mrunlist[ii].cmd, mrunlist[ii].dest,
                                   Convert.ToInt16(mrunlist[ii].controlmode),
                                    Convert.ToInt16(mrunlist[ii].destcontrolmode),
                                   k, Convert.ToSingle(mrunlist[ii].speed),
                                   mrunlist[ii].keeptime, mrunlist[ii].returnstep, mrunlist[ii].returncount, mrunlist[ii].action, mrunlist[ii].destmode);

                                        mcurseg = ii;
                                    }
                                    break;
                                }
                            }



                        }
                        else
                        {
                            mtestrun = false;
                        }
                    }


                }


            }



            return;

        }

        void Timer()
        {
            int j;
            int i;
            int jj;
            int ii;
            if (connected == true)
            {
               // SendTransferCmd();
            }

            {

                ii = mdatalist.Count;

                for (jj = 0; jj < ii; jj++)
                {



                    mt.WaitOne();
                    XLDOPE.MDataIno md = mdatalist.Dequeue();


                    if (md.mydatainfo.Sensor == null)
                    {

                    }
                    else
                    {
                        GGMsg = md.mydatainfo;
                    }

                    mt.ReleaseMutex();

                    b = new RawDataStruct();
                    b.data = new double[24];



                    pos = GGMsg.Sensor[0];
                    load = GGMsg.Sensor[1];




                    ext = GGMsg.Sensor[2];



                    

                    cmd = GGMsg.Test1;

                    time = GGMsg.Time;

                    count = GGMsg.Cycles;

                   

                    if (mtestrun == true)
                    {
                        if (CComLibrary.GlobeVal.filesave.Extensometer_DataFrozenFlag == true)
                        {
                            ext = 0;
                        }
                    }


                    if (CComLibrary.GlobeVal.filesave != null)
                    {
                        if ((CComLibrary.GlobeVal.filesave.mseglist.Count > 0))
                        {
                            if ((mcurseg >= 0) && (mcurseg < CComLibrary.GlobeVal.filesave.mseglist.Count) && (CComLibrary.GlobeVal.filesave.mseglist[mcurseg].mseq.wavekind > 1))
                            {
                                if (mtestrun == true)
                                {


                                    count = CComLibrary.GlobeVal.filesave.mseglist[mcurseg].mseq.mfinishedcount + GGMsg.Cycles;
                                }
                                else
                                {

                                    count = CComLibrary.GlobeVal.filesave.mseglist[mcurseg].mseq.mfinishedcount;
                                }

                                base.count = Convert.ToInt32(count);
                            }

                        }




                        if (CComLibrary.GlobeVal.filesave.mseglist.Count > 0)
                        {
                            if ((mcurseg >= 0) && (mcurseg < CComLibrary.GlobeVal.filesave.mseglist.Count))
                            {

                                if ((CComLibrary.GlobeVal.filesave.mseglist[mcurseg].mseq.wavekind == 2) || (CComLibrary.GlobeVal.filesave.mseglist[mcurseg].mseq.wavekind == 3))
                                {
                                    CComLibrary.GlobeVal.filesave.mseglist[mcurseg].mseq.mcurrentcount = Convert.ToInt32(count);
                                }
                                else
                                {
                                    CComLibrary.GlobeVal.filesave.mseglist[mcurseg].mseq.mcurrentcount = 0;
                                }
                            }

                        }

                    }

                    ClsStaticStation.m_Global.msensor4 = GGMsg.Sensor[3];

                    ClsStaticStation.m_Global.msensor5 = GGMsg.Sensor[4];

                    ClsStaticStation.m_Global.msensor6 = GGMsg.Sensor[5];


                    ClsStaticStation.m_Global.msensor7 = GGMsg.Sensor[6];

                    ClsStaticStation.m_Global.msensor8 = GGMsg.Sensor[7];


                    //自定义通道赋值
                    ClsStaticStation.m_Global.mload = load;

                    ClsStaticStation.m_Global.mpos = pos;



                    double[] rr;

                    rr = new double[100];

                    for (j = 0; j < 100; j++)
                    {
                        rr[j] = 0;
                    }

                    if (CComLibrary.GlobeVal.filesave == null)
                    {
                    }
                    else
                    {

                        for (j = 0; j < CComLibrary.GlobeVal.filesave.muserchannel.Count; j++)
                        {
                            rr[j] = 0;
                        }

                        for (j = 0; j < CComLibrary.GlobeVal.filesave.muserchannel.Count; j++)
                        {



                            rr[j + 1] = CComLibrary.GlobeVal.gcalc.getresult通道(j + 1);

                        }
                    }



                    for (j = 0; j < m_Global.mycls.datalist.Count; j++)
                    {

                        for (int m = 0; m < 100; m++)
                        {
                            if (m_Global.mycls.datalist[j].SignName == "Ch User" + m.ToString().Trim())
                            {
                                b.data[m_Global.mycls.datalist[j].EdcId] = rr[m + 1];

                            }

                        }

                        if (m_Global.mycls.datalist[j].SignName == "Ch Time")
                        {

                            b.data[m_Global.mycls.datalist[j].EdcId] = time;


                            if (time > m_Global.mycls.datalist[j].bvaluemax)
                            {
                                m_Global.mycls.datalist[j].bvaluemax = time;
                            }
                            if (time < m_Global.mycls.datalist[j].bvaluemin)
                            {
                                m_Global.mycls.datalist[j].bvaluemin = time;
                            }


                            m_Global.mycls.datalist[j].rvaluemax = time;


                            m_Global.mycls.datalist[j].rvaluemin = 0;



                        }

                        if (m_Global.mycls.datalist[j].SignName == "Ch Sensor4")
                        {

                            b.data[m_Global.mycls.datalist[j].EdcId] = ClsStaticStation.m_Global.msensor4;


                            if (ClsStaticStation.m_Global.msensor4 > m_Global.mycls.datalist[j].bvaluemax)
                            {
                                m_Global.mycls.datalist[j].bvaluemax = ClsStaticStation.m_Global.msensor4;
                            }
                            if (ClsStaticStation.m_Global.msensor4 < m_Global.mycls.datalist[j].bvaluemin)
                            {
                                m_Global.mycls.datalist[j].bvaluemin = ClsStaticStation.m_Global.msensor4;
                            }
                            if (ClsStaticStation.m_Global.msensor4 > m_Global.mycls.datalist[j].rvaluemax)
                            {
                                m_Global.mycls.datalist[j].rvaluemax = ClsStaticStation.m_Global.msensor4;
                            }
                            if (ClsStaticStation.m_Global.msensor4 < m_Global.mycls.datalist[j].rvaluemin)
                            {
                                m_Global.mycls.datalist[j].rvaluemin = ClsStaticStation.m_Global.msensor4;
                            }


                        }

                        if (m_Global.mycls.datalist[j].SignName == "Ch Sensor5")
                        {

                            b.data[m_Global.mycls.datalist[j].EdcId] = ClsStaticStation.m_Global.msensor5;


                            if (ClsStaticStation.m_Global.msensor5 > m_Global.mycls.datalist[j].bvaluemax)
                            {
                                m_Global.mycls.datalist[j].bvaluemax = ClsStaticStation.m_Global.msensor5;
                            }
                            if (ClsStaticStation.m_Global.msensor5 < m_Global.mycls.datalist[j].bvaluemin)
                            {
                                m_Global.mycls.datalist[j].bvaluemin = ClsStaticStation.m_Global.msensor5;
                            }
                            if (ClsStaticStation.m_Global.msensor5 > m_Global.mycls.datalist[j].rvaluemax)
                            {
                                m_Global.mycls.datalist[j].rvaluemax = ClsStaticStation.m_Global.msensor5;
                            }
                            if (ClsStaticStation.m_Global.msensor5 < m_Global.mycls.datalist[j].rvaluemin)
                            {
                                m_Global.mycls.datalist[j].rvaluemin = ClsStaticStation.m_Global.msensor5;
                            }


                        }


                        if (m_Global.mycls.datalist[j].SignName == "Ch Sensor6")
                        {

                            b.data[m_Global.mycls.datalist[j].EdcId] = ClsStaticStation.m_Global.msensor6;


                            if (ClsStaticStation.m_Global.msensor6 > m_Global.mycls.datalist[j].bvaluemax)
                            {
                                m_Global.mycls.datalist[j].bvaluemax = ClsStaticStation.m_Global.msensor6;
                            }
                            if (ClsStaticStation.m_Global.msensor6 < m_Global.mycls.datalist[j].bvaluemin)
                            {
                                m_Global.mycls.datalist[j].bvaluemin = ClsStaticStation.m_Global.msensor6;
                            }
                            if (ClsStaticStation.m_Global.msensor6 > m_Global.mycls.datalist[j].rvaluemax)
                            {
                                m_Global.mycls.datalist[j].rvaluemax = ClsStaticStation.m_Global.msensor6;
                            }
                            if (ClsStaticStation.m_Global.msensor6 < m_Global.mycls.datalist[j].rvaluemin)
                            {
                                m_Global.mycls.datalist[j].rvaluemin = ClsStaticStation.m_Global.msensor6;
                            }


                        }

                        if (m_Global.mycls.datalist[j].SignName == "Ch Sensor7")
                        {

                            b.data[m_Global.mycls.datalist[j].EdcId] = ClsStaticStation.m_Global.msensor7;


                            if (ClsStaticStation.m_Global.msensor7 > m_Global.mycls.datalist[j].bvaluemax)
                            {
                                m_Global.mycls.datalist[j].bvaluemax = ClsStaticStation.m_Global.msensor7;
                            }
                            if (ClsStaticStation.m_Global.msensor7 < m_Global.mycls.datalist[j].bvaluemin)
                            {
                                m_Global.mycls.datalist[j].bvaluemin = ClsStaticStation.m_Global.msensor7;
                            }
                            if (ClsStaticStation.m_Global.msensor7 > m_Global.mycls.datalist[j].rvaluemax)
                            {
                                m_Global.mycls.datalist[j].rvaluemax = ClsStaticStation.m_Global.msensor7;
                            }
                            if (ClsStaticStation.m_Global.msensor7 < m_Global.mycls.datalist[j].rvaluemin)
                            {
                                m_Global.mycls.datalist[j].rvaluemin = ClsStaticStation.m_Global.msensor7;
                            }


                        }

                        if (m_Global.mycls.datalist[j].SignName == "Ch Sensor8")
                        {

                            b.data[m_Global.mycls.datalist[j].EdcId] = ClsStaticStation.m_Global.msensor8;


                            if (ClsStaticStation.m_Global.msensor8 > m_Global.mycls.datalist[j].bvaluemax)
                            {
                                m_Global.mycls.datalist[j].bvaluemax = ClsStaticStation.m_Global.msensor8;
                            }
                            if (ClsStaticStation.m_Global.msensor8 < m_Global.mycls.datalist[j].bvaluemin)
                            {
                                m_Global.mycls.datalist[j].bvaluemin = ClsStaticStation.m_Global.msensor8;
                            }
                            if (ClsStaticStation.m_Global.msensor8 > m_Global.mycls.datalist[j].rvaluemax)
                            {
                                m_Global.mycls.datalist[j].rvaluemax = ClsStaticStation.m_Global.msensor8;
                            }
                            if (ClsStaticStation.m_Global.msensor8 < m_Global.mycls.datalist[j].rvaluemin)
                            {
                                m_Global.mycls.datalist[j].rvaluemin = ClsStaticStation.m_Global.msensor8;
                            }


                        }


                        if (m_Global.mycls.datalist[j].SignName == "Ch Disp")
                        {

                            b.data[m_Global.mycls.datalist[j].EdcId] = pos;


                            if (pos > m_Global.mycls.datalist[j].bvaluemax)
                            {
                                m_Global.mycls.datalist[j].bvaluemax = pos;
                            }
                            if (pos < m_Global.mycls.datalist[j].bvaluemin)
                            {
                                m_Global.mycls.datalist[j].bvaluemin = pos;
                            }
                            if (pos > m_Global.mycls.datalist[j].rvaluemax)
                            {
                                m_Global.mycls.datalist[j].rvaluemax = pos;
                            }
                            if (pos < m_Global.mycls.datalist[j].rvaluemin)
                            {
                                m_Global.mycls.datalist[j].rvaluemin = pos;
                            }


                        }





                        if (m_Global.mycls.datalist[j].SignName == "Ch Load")
                        {

                            b.data[m_Global.mycls.datalist[j].EdcId] = load;


                            if (load > m_Global.mycls.datalist[j].bvaluemax)
                            {

                                m_Global.mycls.datalist[j].bvaluemax = load;
                            }
                            if (load < m_Global.mycls.datalist[j].bvaluemin)
                            {
                                m_Global.mycls.datalist[j].bvaluemin = load;
                            }

                            if (load > m_Global.mycls.datalist[j].rvaluemax)
                            {

                                m_Global.mycls.datalist[j].rvaluemax = load;
                            }
                            if (load < m_Global.mycls.datalist[j].rvaluemin)
                            {
                                m_Global.mycls.datalist[j].rvaluemin = load;
                            }

                        }

                        if (m_Global.mycls.datalist[j].SignName == "Ch Ext")
                        {

                            b.data[m_Global.mycls.datalist[j].EdcId] = ext;


                            if (ext > m_Global.mycls.datalist[j].bvaluemax)
                            {

                                m_Global.mycls.datalist[j].bvaluemax = ext;
                            }
                            if (ext < m_Global.mycls.datalist[j].bvaluemin)
                            {
                                m_Global.mycls.datalist[j].bvaluemin = ext;
                            }

                            if (ext > m_Global.mycls.datalist[j].rvaluemax)
                            {

                                m_Global.mycls.datalist[j].rvaluemax = ext;
                            }
                            if (ext < m_Global.mycls.datalist[j].rvaluemin)
                            {
                                m_Global.mycls.datalist[j].rvaluemin = ext;
                            }

                        }

                        if (m_Global.mycls.datalist[j].SignName == "Ch Command")
                        {

                            b.data[m_Global.mycls.datalist[j].EdcId] = cmd;


                        }




                        if (m_Global.mycls.datalist[j].SignName == "Ch Count")
                        {

                            b.data[m_Global.mycls.datalist[j].EdcId] = count;





                        }
                        if (m_Global.mycls.datalist[j].SignName == "Ch Disp Max")
                        {
                            for (int m = 0; m < m_Global.mycls.chsignals.Count; m++)
                            {
                                if (m_Global.mycls.chsignals[m].SignName == "Ch Disp")
                                {
                                    b.data[m_Global.mycls.datalist[j].EdcId] = m_Global.mycls.chsignals[m].cvaluemax;
                                }
                            }
                        }

                        if (m_Global.mycls.datalist[j].SignName == "Ch Disp Min")
                        {
                            for (int m = 0; m < m_Global.mycls.chsignals.Count; m++)
                            {
                                if (m_Global.mycls.chsignals[m].SignName == "Ch Disp")
                                {
                                    b.data[m_Global.mycls.datalist[j].EdcId] = m_Global.mycls.chsignals[m].cvaluemin;
                                }
                            }
                        }


                        if (m_Global.mycls.datalist[j].SignName == "Ch Load Max")
                        {
                            for (int m = 0; m < m_Global.mycls.chsignals.Count; m++)
                            {
                                if (m_Global.mycls.chsignals[m].SignName == "Ch Load")
                                {
                                    b.data[m_Global.mycls.datalist[j].EdcId] = m_Global.mycls.chsignals[m].cvaluemax;
                                }
                            }
                        }

                        if (m_Global.mycls.datalist[j].SignName == "Ch Load Min")
                        {
                            for (int m = 0; m < m_Global.mycls.chsignals.Count; m++)
                            {
                                if (m_Global.mycls.chsignals[m].SignName == "Ch Load")
                                {
                                    b.data[m_Global.mycls.datalist[j].EdcId] = m_Global.mycls.chsignals[m].cvaluemin;
                                }
                            }
                        }


                        if (m_Global.mycls.datalist[j].SignName == "Ch Ext Max")
                        {
                            for (int m = 0; m < m_Global.mycls.chsignals.Count; m++)
                            {
                                if (m_Global.mycls.chsignals[m].SignName == "Ch Ext")
                                {
                                    b.data[m_Global.mycls.datalist[j].EdcId] = m_Global.mycls.chsignals[m].cvaluemax;
                                }
                            }
                        }

                        if (m_Global.mycls.datalist[j].SignName == "Ch Ext Min")
                        {
                            for (int m = 0; m < m_Global.mycls.chsignals.Count; m++)
                            {
                                if (m_Global.mycls.chsignals[m].SignName == "Ch Ext")
                                {
                                    b.data[m_Global.mycls.datalist[j].EdcId] = m_Global.mycls.chsignals[m].cvaluemin;
                                }
                            }
                        }

                        if (m_Global.mycls.datalist[j].SignName == "Ch Feed")
                        {

                            b.data[m_Global.mycls.datalist[j].EdcId] = 0;
                        }

                        if (m_Global.mycls.datalist[j].SignName == "Ch Out")
                        {

                            b.data[m_Global.mycls.datalist[j].EdcId] = 0;
                        }


                        if (m_Global.mycls.datalist[j].SignName == "Ch Dynamic Stiffness")
                        {


                        }




                    }

                    RawDataDataGroup d;
                    RawDataDataGroup c = new RawDataDataGroup();
                    c.ID = 0;
                    m_Global.mycls.structcopy_RawDataData(ref c.rdata, b);


                    for (j = 0; j < 4; j++)
                    {

                        if (ClsStatic.arraydatacount[j] >= ClsStatic.arraydata[j].NodeCount - 1)
                        {

                            ClsStatic.arraydata[j].Read<RawDataDataGroup>(out d, 10);
                            ClsStatic.arraydatacount[j] = ClsStatic.arraydatacount[j] - 1;
                        }

                        ClsStatic.arraydatacount[j] = ClsStatic.arraydatacount[j] + 1;
                        ClsStatic.arraydata[j].Write<RawDataDataGroup>(ref c, 10);
                    }



                    /*
                    if (ClsStatic.savedatacount >= ClsStatic.savedata.NodeCount - 1)
                    {
                        ClsStatic.savedata.Read<RawDataDataGroup>(out d, 10);
                        ClsStatic.savedatacount = ClsStatic.savedatacount - 1;
                    }
                    ClsStatic.savedatacount = ClsStatic.savedatacount + 1;
                    ClsStatic.savedata.Write<RawDataDataGroup>(ref c, 10);
                    */

                    for (j = 0; j < m_Global.mycls.allsignals.Count; j++)
                    {
                        if (m_Global.mycls.allsignals[j].SignName == "Ch Command")
                        {

                            m_Global.mycls.allsignals[j].cvalue = cmd;

                        }




                    }
                    for (j = 0; j < m_Global.mycls.allsignals.Count; j++)
                    {

                        if (m_Global.mycls.allsignals[j].SignName == "Ch Time")
                        {
                            m_Global.mycls.allsignals[j].cvalue = time;
                        }

                        if (m_Global.mycls.allsignals[j].SignName == "Ch Sensor4")
                        {
                            m_Global.mycls.allsignals[j].cvalue = ClsStaticStation.m_Global.msensor4;
                        }

                        if (m_Global.mycls.allsignals[j].SignName == "Ch Sensor5")
                        {
                            m_Global.mycls.allsignals[j].cvalue = ClsStaticStation.m_Global.msensor5;
                        }


                        if (m_Global.mycls.allsignals[j].SignName == "Ch Sensor6")
                        {
                            m_Global.mycls.allsignals[j].cvalue = ClsStaticStation.m_Global.msensor6;
                        }

                        if (m_Global.mycls.allsignals[j].SignName == "Ch Sensor7")
                        {
                            m_Global.mycls.allsignals[j].cvalue = ClsStaticStation.m_Global.msensor7;
                        }

                        if (m_Global.mycls.allsignals[j].SignName == "Ch Sensor8")
                        {
                            m_Global.mycls.allsignals[j].cvalue = ClsStaticStation.m_Global.msensor8;
                        }
                        if (m_Global.mycls.allsignals[j].SignName == "Ch Disp")
                        {
                            m_Global.mycls.allsignals[j].cvalue = pos;
                            if (pos > m_Global.mycls.allsignals[j].bvaluemax)
                            {
                                m_Global.mycls.allsignals[j].bvaluemax = pos;
                            }
                            if (pos < m_Global.mycls.allsignals[j].bvaluemin)
                            {
                                m_Global.mycls.allsignals[j].bvaluemin = pos;
                            }
                            if (pos > m_Global.mycls.allsignals[j].rvaluemax)
                            {
                                m_Global.mycls.allsignals[j].rvaluemax = pos;
                            }
                            if (pos < m_Global.mycls.allsignals[j].rvaluemin)
                            {
                                m_Global.mycls.allsignals[j].rvaluemin = pos;
                            }

                        }

                        if (m_Global.mycls.allsignals[j].SignName == "Ch Load")
                        {
                            m_Global.mycls.allsignals[j].cvalue = load;

                            if (load > m_Global.mycls.allsignals[j].bvaluemax)
                            {
                                m_Global.mycls.allsignals[j].bvaluemax = load;
                            }
                            if (load < m_Global.mycls.allsignals[j].bvaluemin)
                            {
                                m_Global.mycls.allsignals[j].bvaluemin = load;
                            }
                            if (load > m_Global.mycls.allsignals[j].rvaluemax)
                            {
                                m_Global.mycls.allsignals[j].rvaluemax = load;
                            }
                            if (load < m_Global.mycls.allsignals[j].rvaluemin)
                            {
                                m_Global.mycls.allsignals[j].rvaluemin = load;
                            }


                        }

                        if (m_Global.mycls.allsignals[j].SignName == "Ch Ext")
                        {
                            m_Global.mycls.allsignals[j].cvalue = ext;

                            if (ext > m_Global.mycls.allsignals[j].bvaluemax)
                            {
                                m_Global.mycls.allsignals[j].bvaluemax = ext;
                            }
                            if (ext < m_Global.mycls.allsignals[j].bvaluemin)
                            {
                                m_Global.mycls.allsignals[j].bvaluemin = ext;
                            }
                            if (ext > m_Global.mycls.allsignals[j].rvaluemax)
                            {
                                m_Global.mycls.allsignals[j].rvaluemax = ext;
                            }
                            if (ext < m_Global.mycls.allsignals[j].rvaluemin)
                            {
                                m_Global.mycls.allsignals[j].rvaluemin = ext;
                            }



                        }

                        if (m_Global.mycls.allsignals[j].SignName == "Ch Count")
                        {
                            m_Global.mycls.allsignals[j].cvalue = count;

                            if (Math.Abs(Convert.ToInt32(count) - oldcount) >= 2)
                            {
                                for (int m = 0; m < m_Global.mycls.chsignals.Count; m++)
                                {
                                    m_Global.mycls.chsignals[m].cvaluemax = m_Global.mycls.chsignals[m].bvaluemax;
                                    m_Global.mycls.chsignals[m].cvaluemin = m_Global.mycls.chsignals[m].bvaluemin;
                                    m_Global.mycls.chsignals[m].bvaluemax = m_Global.mycls.chsignals[m].fullminbase;
                                    m_Global.mycls.chsignals[m].bvaluemin = m_Global.mycls.chsignals[m].fullmaxbase;




                                }

                                oldcount = Convert.ToInt32(count);
                            }


                        }

                        if (m_Global.mycls.allsignals[j].SignName == "Ch Disp Max")
                        {
                            for (int m = 0; m < m_Global.mycls.chsignals.Count; m++)
                            {
                                if (m_Global.mycls.chsignals[m].SignName == "Ch Disp")
                                {
                                    m_Global.mycls.allsignals[j].cvalue = m_Global.mycls.chsignals[m].cvaluemax;
                                }
                            }
                        }

                        if (m_Global.mycls.allsignals[j].SignName == "Ch Disp Min")
                        {
                            for (int m = 0; m < m_Global.mycls.chsignals.Count; m++)
                            {
                                if (m_Global.mycls.chsignals[m].SignName == "Ch Disp")
                                {
                                    m_Global.mycls.allsignals[j].cvalue = m_Global.mycls.chsignals[m].cvaluemin;
                                }
                            }
                        }

                        if (m_Global.mycls.allsignals[j].SignName == "Ch Load Max")
                        {
                            for (int m = 0; m < m_Global.mycls.chsignals.Count; m++)
                            {
                                if (m_Global.mycls.chsignals[m].SignName == "Ch Load")
                                {
                                    m_Global.mycls.allsignals[j].cvalue = m_Global.mycls.chsignals[m].cvaluemax;
                                }
                            }
                        }

                        if (m_Global.mycls.allsignals[j].SignName == "Ch Load Min")
                        {
                            for (int m = 0; m < m_Global.mycls.chsignals.Count; m++)
                            {
                                if (m_Global.mycls.chsignals[m].SignName == "Ch Load")
                                {
                                    m_Global.mycls.allsignals[j].cvalue = m_Global.mycls.chsignals[m].cvaluemin;
                                }
                            }
                        }

                        /*
                        for (int m = 0; m < 100; m++)
                        {
                            if (m_Global.mycls.allsignals[j].SignName == "Ch User" + m.ToString().Trim())
                            {
                                m_Global.mycls.allsignals[j].cvalue = rr[m + 1];

                            }

                        }
                        */

                    }

                }




            }
        }

        public override void Init(int handle)
        {

            OpenConnection();


        }

        int OpenConnection()
        {
            connected = false;
            try
            {
                _pipeServer.Listen("TestPipe");
                connected = true;

                mtimer.Start();
            }
            catch (Exception)
            {
                connected = false;
            }

            return 0;
        }


        public override int CloseConnection()
        {
            mtimer.Stop();




            return 0;
        }
    }
}

