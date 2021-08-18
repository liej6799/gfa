using System.Diagnostics;

namespace gfa_worker_common
{
    public class ProcessHelper
    {
        private Process process;
        public ProcessHelper(string processName, string args)
        {
            process = new Process 
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = CommonHelper.rootPath + processName,
                    Arguments = args,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
        }

        public string Run()
        {
            process.Start();
            return process.StandardOutput.ReadToEnd();
        }
    }
}