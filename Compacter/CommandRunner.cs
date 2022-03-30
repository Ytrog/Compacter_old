using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Compacter
{
    static class CommandRunner
    {

        public static async Task Run(IEnumerable<CompactOptions> commands)
        {
            List<Task> commandTasks = new List<Task>();
            foreach (CompactOptions command in commands)
            {
                commandTasks.Add(RunCommand(command));
            }

            Task all = Task.WhenAll(commandTasks);
            try
            {
                await all;
            }
            catch (AggregateException e)
            {
                ErrorReport errorReport = new ErrorReport();
                errorReport.ShowExceptions(e.InnerExceptions); // this also makes a dialog
            }
            catch (ProcessException e)
            {
                ErrorReport errorReport = new ErrorReport();
                errorReport.ShowExceptions(new ProcessException[] { e });
            }
        }

        private static async Task RunCommand(CompactOptions command)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "compact.exe",
                Arguments = command.Arguments,
                RedirectStandardError = true,
                UseShellExecute = false
            };

            Process process = new Process
            {
                StartInfo = processStartInfo,
                EnableRaisingEvents = true
            };

           

            StringBuilder sb = new StringBuilder();

            // TODO apparently compact doesn't use the error stream :(
            process.ErrorDataReceived += ((sender, e) => {
                sb.Append(e.Data);
            });

            process.Start();

            await Task.Run(() => process.WaitForExit());

            string errors = sb.ToString();

            if (!string.IsNullOrWhiteSpace(errors))
            {
               throw new ProcessException(errors);
            }
        }

        
    }
}
