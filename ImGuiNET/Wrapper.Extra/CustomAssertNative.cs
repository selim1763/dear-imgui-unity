using System.Runtime.InteropServices;

namespace ImGuiNET
{
    static unsafe partial class CustomAssertNative
    {
        #if UNITY_IOS
        private const string dll_name = "__Internal";
        #else
        private const string dll_name = "cimgui";
        #endif
        
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PluginLogAssert(byte* condition, byte* file, int line);

        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void PluginDebugBreak();
    }
}
