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

        public CompactAction Action { get; }
        public CompactMethod Method { get; }
        public string Path { get; }
    }
}
