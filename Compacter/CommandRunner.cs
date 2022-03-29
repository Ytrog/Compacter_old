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
                // TODO report errors
                throw;
            }
        }

        private static async Task RunCommand(CompactOptions command)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "compact.exe",
                Arguments = command.Arguments
            };

            await Task.Run(() => Process.Start(processStartInfo));
        }
    }
}
