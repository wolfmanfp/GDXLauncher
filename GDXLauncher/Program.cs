using System;
using System.Diagnostics;
using System.IO;

namespace Wolfman.GDXLauncher
{
    class Program
    {

#if REDNECK
        public static String START_JAR = "RedneckGDX.jar";
#else
        public static String START_JAR = "BloodGDX.jar";
#endif

        static void Main(string[] args)
        {
            var JavaRuntimePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jre/bin/javaw.exe");
            var JPortableRuntimePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JavaPortableLauncher/JavaPortableLauncher.exe");

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = Directory.Exists("jre") ? JavaRuntimePath : "javaw",
                Arguments = $@"-jar {START_JAR} -Xmx1G"
            };

            ProcessStartInfo jPortableStartInfo = new ProcessStartInfo
            {
                FileName = JPortableRuntimePath,
                Arguments = $@"{START_JAR}"
            };

            Process.Start(Directory.Exists("JavaPortableLauncher") ? jPortableStartInfo : startInfo);
        }
    }
}
