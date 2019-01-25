using System;
using System.Collections.Generic;
using System.Text;
using Doli.DoSANet;
using System.IO;

 namespace ClsStaticStation
{
    public class modMain
    {
        //public static int SysNum = 3;
        public static DoSA[] MeDoSA;
        public static DoSAall MeDoSAall;
        public static bool[] blnStartTest;
        public static bool[] blnPipeConnectOK;//pipe连接正常
        public static int[] intPipeErrorNum;//pipe连接没有接收数据的次数        

        public const int MAX_SENSORS = 16;
        public const int DoSAVersionEDC220 = 9;
        public const int DoSAVersionEDCi15 = 10;
        public const int ConnectToEdcAll = 10000;
        public const int ConnectToEdcFuncID = 10001;
        public const int CloseLink_FuncID = 10002;
        public const int CloseAll = 10003;
        public const int CloseLink_DoSAHdl = 10004;
        public const int TestPara_Name = 10005;
        public const int Config_File = 10006;//前台软件发送来的设备数量和控制器类型等配置文件
        public const int Test_Recovery = 10007;//恢复试验
        public const int thread_Start = 10008;//

        public enum EDC_State
        {
            EDC_STATE_NOT_READY = 0,
            EDC_STATE_OFF = 1,
            EDC_STATE_ON = 2,
            EDC_STATE_TEST = 3,

        }


       
        public enum CtlerType
        {
            SIM = 0,
            EDCi15 = 1,
            EDC220 = 2,
            TMC = 3,         
        }

        public enum SENSOR
        {
            SENSOR_S = 0,
            SENSOR_F = 1,
            SENSOR_E = 2,
            SENSOR_D = 3,
            SENSOR_4 = 4,
            SENSOR_5 = 5,
            SENSOR_6 = 6,
            SENSOR_7 = 7,
            SENSOR_8 = 8,
            SENSOR_9 = 9,
            SENSOR_10 = 10,
            SENSOR_11 = 11,
            SENSOR_12 = 12,
            SENSOR_13 = 13,
            SENSOR_14 = 14,
            SENSOR_15 = 15,
            SENSOR_No = 255,
        }

        public enum CtlMode
        {
            Ramp = 0,
            Halt = 1,
            Cosine = 2,
            Triangle = 3,
            Rectangle = 4,            
        }

        public enum CtlUnit//控制量的单位
        {
            No_Unit = -1,//无单位

            mm = 0,
            um = 1,

            mm_min = 0,
            um_min=1,
            mm_s=2,
            um_s = 3,
            mm_h=4,
            um_h=5,

            N = 0,

            N_S=0,

            Second = 0,
            min = 1,
            
            Hz=0,

            C=0,
            C_min=1,
        }

        public enum cmdType
        {
            Write = 0,
            Read = 1,
        }

        public enum Return_Action
        {
            s_halt=0,//停于位置
            return_le = 1,//初始状态
            return_p0=2,//预负荷
            f_halt=3,//停于负荷
            e_halt=4,//停于变形
            drive_off=5,//关断驱动
        }

        public enum EndMode
        {
            above=0,
            below=1,
            delta_of_max=2,
            rate=3,
        }
        
    }
}
