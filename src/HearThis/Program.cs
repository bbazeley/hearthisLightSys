using System;
using System.Windows.Forms;
using HearThis.Properties;
using HearThis.UI;
using Palaso.Reporting;
using Paratext;

namespace HearThis
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//bring in settings from any previous version
			if (Settings.Default.NeedUpgrade)
			{
				//see http://stackoverflow.com/questions/3498561/net-applicationsettingsbase-should-i-call-upgrade-every-time-i-load
				Settings.Default.Upgrade();
				Settings.Default.NeedUpgrade = false;
				Settings.Default.Save();
			}

			SetUpErrorHandling();
			SetUpReporting();

			if (args.Length == 1 && args[0].Trim() == "-afterInstall")
			{
				using (var dlg = new ReleaseNotesWindow())
				{
					dlg.ShowDialog();
				}
			}
			try
			{
				ScrTextCollection.Initialize();
			}
			catch (Exception error)
			{
				Palaso.Reporting.ErrorReport.NotifyUserOfProblem(
					"It looks like perhaps Paratext is not installed on this computer, or there is some other problem connecting to it. We'll set you up with a sample so you can play with HearThis, but you'll have to install Paratext to get any real work done here.");

				Settings.Default.Project = "Sample";
			}

			Application.Run(new Form1());
		}


		/// ------------------------------------------------------------------------------------
		private static void SetUpErrorHandling()
		{
			ErrorReport.EmailAddress = "replace@gmail.com".Replace("replace", "hattonjohn");
			ErrorReport.AddStandardProperties();
			ExceptionHandler.Init();
		}

		/// ------------------------------------------------------------------------------------
		private static void SetUpReporting()
		{
			if (Settings.Default.Reporting == null)
			{
				Settings.Default.Reporting = new ReportingSettings();
				Settings.Default.Save();
			}

			UsageReporter.Init(Settings.Default.Reporting, "hearthis.palaso.org", "UA-22170471-7",
#if DEBUG
							   true
#else
				false
#endif
				);
		}
	}
}
