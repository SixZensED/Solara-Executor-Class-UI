using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace XamlGeneratedNamespace
{
	// Token: 0x02000002 RID: 2
	public class GeneratedApplication : Application
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			bool contentLoaded = this._contentLoaded;
			if (!contentLoaded)
			{
				this._contentLoaded = true;
				base.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
				Uri resourceLocator = new Uri("/WpfApp1;component/app.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002090 File Offset: 0x00000290
		[STAThread]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public static void Main()
		{
			GeneratedApplication generatedApplication = new GeneratedApplication();
			generatedApplication.InitializeComponent();
			generatedApplication.Run();
		}

		// Token: 0x04000001 RID: 1
		private bool _contentLoaded;
	}
}
