using System;
using System.Runtime.InteropServices;

namespace StressTest
{
   public static class NativeInterface
    {
        [DllImport("TestDLL")]
        public static extern int AddMoney();
        [DllImport("TestDLL")]
        public static extern int GetValueRef(ref int param);
        [DllImport("TestDLL")]
        public static extern int SetArray(byte[] arr, int length);
        [DllImport("TestDLL")]
        public static extern IntPtr GetArray();

        public static int[] GetIntArrayByPtr(IntPtr ptr,int len) 
        {
            int[] ret = new int[len];
            Marshal.Copy(ptr, ret, 0, len);
            return ret;
        }
        public static byte[] GetByteArrayByPtr(IntPtr ptr, int len)
        {
            byte[] ret = new byte[len];
            Marshal.Copy(ptr, ret, 0, len);
            return ret;
        }
    }
}
