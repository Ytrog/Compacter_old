using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compacter
{
    public enum CompactAction
    {
        List,
        Compress,
        Uncompress
    }

    public enum CompactMethod
    {
        NONE,
        NTFS,
        XPRESS4K,
        XPRESS8K,
        XPRESS16K,
        LZX
    }

    public class CompactOptions
    {
        public CompactOptions(CompactAction action, CompactMethod method, string path)
        {
            Action = action;
            Method = method;
            Path = path;
        }

        private string command;
        private string arguments;

        public CompactAction Action { get; }
        public CompactMethod Method { get; }
        public string Path { get; }
        public string Command {
            get
            {
                if (command == null)
                {
                    command = AsCommand();
                }

                return command;
            }
        }

        public string Arguments
        {
            get
            {
                if (arguments == null)
                {
                    arguments = BuildArguments();
                }

                return arguments;
            }
        }

        private string FormatPath()
        {
            if (Path.EndsWith("\\"))
            {
                return $"{Path}*.*";
            }
            else
            {
                return $"{Path}\\*.*";
            }
        }

        private string AsCommand()
        {
            return "compact " + Arguments;
        }

        private string BuildArguments()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{FormatPath()} ");
            // None is only in case of List
            if (Action == CompactAction.List || Method == CompactMethod.NONE)
            {
                sb.Append("/s ");
                return sb.ToString(); // Exit early
            }
            else if (Action == CompactAction.Compress)
            {
                sb.Append("/s /c ");
            }
            else if (Action == CompactAction.Uncompress)
            {
                sb.Append("/s /u ");
            }

            // Add method
            switch (Method)
            {
                case CompactMethod.NONE: // should never happen
                    break;
                case CompactMethod.NTFS: // add nothing as this is default method
                    break;
                case CompactMethod.XPRESS4K:
                    sb.Append("/EXE:XPRESS4K");
                    break;
                case CompactMethod.XPRESS8K:
                    sb.Append("/EXE:XPRESS8K");
                    break;
                case CompactMethod.XPRESS16K:
                    sb.Append("/EXE:XPRESS16K");
                    break;
                case CompactMethod.LZX:
                    sb.Append("/EXE:LZX");
                    break;
                default:
                    break;
            }

            return sb.ToString();
        }
    }
}
