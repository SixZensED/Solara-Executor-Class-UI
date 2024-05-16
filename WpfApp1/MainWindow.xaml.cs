using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Shapes;
using Microsoft.Web.WebView2.Wpf;
using Wpf.Ui.Controls;

namespace WpfApp1
{
	// Token: 0x02000004 RID: 4
	public partial class MainWindow : FluentWindow
	{
		// Token: 0x06000005 RID: 5
		[DllImport("XcHvYYrNa.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		public static extern int isAttached();

		// Token: 0x06000006 RID: 6
		[DllImport("XcHvYYrNa.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		public static extern bool inject();

		// Token: 0x06000007 RID: 7
		[DllImport("XcHvYYrNa.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void executeScript([MarshalAs(UnmanagedType.LPStr)] string source);

		// Token: 0x06000008 RID: 8 RVA: 0x000020C4 File Offset: 0x000002C4
		public MainWindow()
		{
			this.InitializeComponent();
			this.InitializeWebView();
			this.startWatcher();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020E4 File Offset: 0x000002E4
		[DebuggerStepThrough]
		private void startWatcher()
		{
			MainWindow.<startWatcher>d__6 <startWatcher>d__ = new MainWindow.<startWatcher>d__6();
			<startWatcher>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<startWatcher>d__.<>4__this = this;
			<startWatcher>d__.<>1__state = -1;
			<startWatcher>d__.<>t__builder.Start<MainWindow.<startWatcher>d__6>(ref <startWatcher>d__);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002120 File Offset: 0x00000320
		[DebuggerStepThrough]
		private void InitializeWebView()
		{
			MainWindow.<InitializeWebView>d__7 <InitializeWebView>d__ = new MainWindow.<InitializeWebView>d__7();
			<InitializeWebView>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<InitializeWebView>d__.<>4__this = this;
			<InitializeWebView>d__.<>1__state = -1;
			<InitializeWebView>d__.<>t__builder.Start<MainWindow.<InitializeWebView>d__7>(ref <InitializeWebView>d__);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002159 File Offset: 0x00000359
		private void fluentWindow_Loaded(object sender, RoutedEventArgs e)
		{
			this.CodeEditor.Source = new Uri(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Monaco\\index.html"));
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002184 File Offset: 0x00000384
		[DebuggerStepThrough]
		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			MainWindow.<ClearButton_Click>d__9 <ClearButton_Click>d__ = new MainWindow.<ClearButton_Click>d__9();
			<ClearButton_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ClearButton_Click>d__.<>4__this = this;
			<ClearButton_Click>d__.sender = sender;
			<ClearButton_Click>d__.e = e;
			<ClearButton_Click>d__.<>1__state = -1;
			<ClearButton_Click>d__.<>t__builder.Start<MainWindow.<ClearButton_Click>d__9>(ref <ClearButton_Click>d__);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021CC File Offset: 0x000003CC
		private void InjectButton_MouseClick1(object sender, RoutedEventArgs e)
		{
			try
			{
				bool flag = MainWindow.inject();
			}
			catch (Exception ex)
			{
				System.Windows.MessageBox.Show("Exception: " + ex.Message, "Error", System.Windows.MessageBoxButton.OK, MessageBoxImage.Hand);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002218 File Offset: 0x00000418
		[DebuggerStepThrough]
		private void ExecuteClicked(object sender, RoutedEventArgs e)
		{
			MainWindow.<ExecuteClicked>d__11 <ExecuteClicked>d__ = new MainWindow.<ExecuteClicked>d__11();
			<ExecuteClicked>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ExecuteClicked>d__.<>4__this = this;
			<ExecuteClicked>d__.sender = sender;
			<ExecuteClicked>d__.e = e;
			<ExecuteClicked>d__.<>1__state = -1;
			<ExecuteClicked>d__.<>t__builder.Start<MainWindow.<ExecuteClicked>d__11>(ref <ExecuteClicked>d__);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002260 File Offset: 0x00000460
		private static string ReplaceSpecialCharactersWithUnicode(string input)
		{
			string pattern = "[^\\u0000-\\u007F]";
			return Regex.Replace(input, pattern, (Match m) => "\\u{" + MainWindow.GetUnicodeEscape((int)m.Value[0]) + "}");
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022A0 File Offset: 0x000004A0
		private static string GetUnicodeEscape(int codePoint)
		{
			return string.Format("{0:x4}", codePoint);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022C2 File Offset: 0x000004C2
		private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://discord.com/invite/VnWVvAMCBC");
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000022D0 File Offset: 0x000004D0
		[DebuggerStepThrough]
		private void OpenFile(object sender, RoutedEventArgs e)
		{
			MainWindow.<OpenFile>d__15 <OpenFile>d__ = new MainWindow.<OpenFile>d__15();
			<OpenFile>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OpenFile>d__.<>4__this = this;
			<OpenFile>d__.sender = sender;
			<OpenFile>d__.e = e;
			<OpenFile>d__.<>1__state = -1;
			<OpenFile>d__.<>t__builder.Start<MainWindow.<OpenFile>d__15>(ref <OpenFile>d__);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002318 File Offset: 0x00000518
		[DebuggerStepThrough]
		private void SaveFile(object sender, RoutedEventArgs e)
		{
			MainWindow.<SaveFile>d__16 <SaveFile>d__ = new MainWindow.<SaveFile>d__16();
			<SaveFile>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveFile>d__.<>4__this = this;
			<SaveFile>d__.sender = sender;
			<SaveFile>d__.e = e;
			<SaveFile>d__.<>1__state = -1;
			<SaveFile>d__.<>t__builder.Start<MainWindow.<SaveFile>d__16>(ref <SaveFile>d__);
		}

		// Token: 0x04000002 RID: 2
		public const string DllName = "XcHvYYrNa.dll";

		// Token: 0x04000003 RID: 3
		private CancellationTokenSource cancellationTokenSource;
	}
}
