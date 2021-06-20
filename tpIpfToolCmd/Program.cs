using System;
using System.Linq;
using tpIpfTool;

namespace tpIpfToolCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                Console.WriteLine("Need more arguments.");
                return;
            }
            IpfPack pck = new IpfPack((string s) =>
            {
                Console.WriteLine(s);
            });
            pck.ExtIpf(args.Skip(0).ToArray());
        }
    }
}