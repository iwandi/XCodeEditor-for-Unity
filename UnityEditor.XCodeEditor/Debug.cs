using System;

namespace UnityEditor.XCodeEditor
{
    public static class Debug
    {
        public static event System.Action<string> OnLog;
        public static event System.Action<string> OnLogError;
        public static event System.Action<string> OnLogWarning;


        public static void Log(string message)
        {
            if (OnLog != null)
            {
                OnLog(message);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(message);
            }
        }

        public static void LogError(string error)
        {
            if (OnLog != null)
            {
                OnLogError(error);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Error:"+error);
            }
        }

        public static void LogWarning(string warning)
        {
            if (OnLog != null)
            {
                OnLogWarning(warning);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Warning"+warning);
            }
        }
    }
}
