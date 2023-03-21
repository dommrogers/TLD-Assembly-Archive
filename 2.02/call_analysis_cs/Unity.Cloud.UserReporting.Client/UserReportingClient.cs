using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting.Plugin;
using Unity.Cloud.UserReporting.Plugin.Version2018_3;

namespace Unity.Cloud.UserReporting.Client;

public class UserReportingClient
{
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public UserReportingClient _003C_003E4__this;

		public Action<UserReport> callback;

		public Func<object> _003C_003E9__1;

		public Action<object> _003C_003E9__2;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass47_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 17)]
		internal void _003CCreateUserReport_003Eb__0()
		{
		}

		[Calls(Type = typeof(Stopwatch), Member = "Stop")]
		[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
		[Calls(Type = typeof(UserReport), Member = "Complete")]
		[CallsUnknownMethods(Count = 45)]
		[Calls(Type = typeof(UserReportingClient), Member = "SampleClientMetric")]
		[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
		[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
		[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
		[Calls(Type = typeof(UserReport), Member = ".ctor")]
		[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
		internal object _003CCreateUserReport_003Eb__1()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CCreateUserReport_003Eb__2(object result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public Action<float, float> progressCallback;

		public UserReportingClient _003C_003E4__this;

		public UserReport userReport;

		public Action<bool, UserReport> callback;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass57_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CSendUserReport_003Eb__0(float uploadProgress, float downloadProgress)
		{
		}

		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 17)]
		[CallerCount(Count = 0)]
		internal void _003CSendUserReport_003Eb__1(bool success, byte[] result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_1
	{
		public bool success;

		public byte[] result;

		public _003C_003Ec__DisplayClass57_0 CS_0024_003C_003E8__locals1;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass57_1()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 10)]
		[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
		[CallsUnknownMethods(Count = 39)]
		internal void _003CSendUserReport_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public UserReportingClient _003C_003E4__this;

		public Action<UserReportScreenshot> callback;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass59_0()
		{
		}

		[CallsUnknownMethods(Count = 17)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		internal void _003CTakeScreenshotFromSource_003Eb__0(int passedFrameNumber, byte[] data)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_1
	{
		public int passedFrameNumber;

		public byte[] data;

		public _003C_003Ec__DisplayClass59_0 CS_0024_003C_003E8__locals1;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass59_1()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
		[Calls(Type = typeof(Convert), Member = "ToBase64String")]
		[CallsUnknownMethods(Count = 18)]
		internal void _003CTakeScreenshotFromSource_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public UserReportingClient _003C_003E4__this;

		public int currentScreenshotsTaken;

		public Action callback;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass62_0()
		{
		}

		[Calls(Type = typeof(UserReportingClient), Member = "WaitForPerforation")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CWaitForPerforation_003Eb__0()
		{
		}
	}

	private Dictionary<string, UserReportMetric> clientMetrics;

	private Dictionary<string, string> currentMeasureMetadata;

	private Dictionary<string, UserReportMetric> currentMetrics;

	private List<Action> currentSynchronizedActions;

	private List<UserReportNamedValue> deviceMetadata;

	private CyclicalList<UserReportEvent> events;

	private int frameNumber;

	private bool isMeasureBoundary;

	private int measureFrames;

	private CyclicalList<UserReportMeasure> measures;

	private CyclicalList<UserReportScreenshot> screenshots;

	private int screenshotsSaved;

	private int screenshotsTaken;

	private List<Action> synchronizedActions;

	private Stopwatch updateStopwatch;

	private UserReportingClientConfiguration _003CConfiguration_003Ek__BackingField;

	private string _003CEndpoint_003Ek__BackingField;

	private bool _003CIsConnectedToLogger_003Ek__BackingField;

	private bool _003CIsSelfReporting_003Ek__BackingField;

	private IUserReportingPlatform _003CPlatform_003Ek__BackingField;

	private string _003CProjectIdentifier_003Ek__BackingField;

	private bool _003CSendEventsToAnalytics_003Ek__BackingField;

	public UserReportingClientConfiguration Configuration
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public string Endpoint
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		private set
		{
		}
	}

	public bool IsConnectedToLogger
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsSelfReporting
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public IUserReportingPlatform Platform
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private set
		{
		}
	}

	public string ProjectIdentifier
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		private set
		{
		}
	}

	public bool SendEventsToAnalytics
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UserReportingClient), Member = "AddDeviceMetadata")]
	[Calls(Type = typeof(UserReportingClient), Member = "AddDeviceMetadata")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallsUnknownMethods(Count = 107)]
	public UserReportingClient(string endpoint, string projectIdentifier, IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
	{
	}

	[CalledBy(Type = typeof(UserReportingClient), Member = ".ctor")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UserReportingClient), Member = ".ctor")]
	public void AddDeviceMetadata(string name, string value)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void AddMeasureMetadata(string name, string value)
	{
	}

	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ClearScreenshots()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[Calls(Type = typeof(UserReportingClient), Member = "WaitForPerforation")]
	[CalledBy(Type = typeof(InternalUserReport), Member = "Send")]
	[CalledBy(Type = typeof(UserReportingMonitor), Member = "Trigger")]
	[CalledBy(Type = typeof(UserReportingScript), Member = "CreateUserReport")]
	public void CreateUserReport(Action<UserReport> callback)
	{
	}

	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetEndpoint()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	public void LogEvent(UserReportEventLevel level, string message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	public void LogEvent(UserReportEventLevel level, string message, string stackTrace)
	{
	}

	[CalledBy(Type = typeof(UserReportingClient), Member = "SaveUserReportToDisk")]
	[CalledBy(Type = typeof(UserReportingClient), Member = "SendUserReport")]
	[CalledBy(Type = typeof(UserReportingClient), Member = "SendUserReport")]
	[CalledBy(Type = typeof(UserReportingClient), Member = "SendUserReport")]
	[CalledBy(Type = typeof(UserReportingClient), Member = "SendUserReport")]
	[CalledBy(Type = typeof(UserReportingClient), Member = "TakeScreenshotFromSource")]
	[CalledBy(Type = typeof(UserReportingClient), Member = "SendUserReport")]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass57_1), Member = "<SendUserReport>b__2")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass57_1), Member = "<SendUserReport>b__2")]
	[CalledBy(Type = typeof(UserReportingClient), Member = "SendUserReport")]
	[CalledBy(Type = typeof(UserReportingClient), Member = "LogException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[CalledBy(Type = typeof(UserReportingClient), Member = "CreateUserReport")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "Update")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "Update")]
	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "Update")]
	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "Update")]
	[Calls(Type = typeof(SerializableException), Member = ".ctor")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow")]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(UserReportingClient), Member = "LogEvent")]
	private void LogEvent(UserReportEventLevel level, string message, string stackTrace, Exception exception)
	{
	}

	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[CallerCount(Count = 0)]
	public void LogException(Exception exception)
	{
	}

	[CalledBy(Type = typeof(UserReportingClient), Member = "UpdateOnEndOfFrame")]
	[CalledBy(Type = typeof(UserReportingClient), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass47_0), Member = "<CreateUserReport>b__1")]
	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "OnEndOfFrame")]
	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "OnEndOfFrame")]
	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "OnEndOfFrame")]
	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "OnEndOfFrame")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	[Calls(Type = typeof(UserReportMetric), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 7)]
	public void SampleClientMetric(string name, double value)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UserReportingClient), Member = "SampleClientMetric")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "SampleAutomaticMetrics")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "SampleAutomaticMetrics")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "SampleAutomaticMetrics")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "SampleAutomaticMetrics")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "SampleAutomaticMetrics")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "SampleAutomaticMetrics")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "Update")]
	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "SampleAutomaticMetrics")]
	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "SampleAutomaticMetrics")]
	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "SampleAutomaticMetrics")]
	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "SampleAutomaticMetrics")]
	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "SampleAutomaticMetrics")]
	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "Update")]
	[Calls(Type = typeof(UserReportMetric), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "SampleAutomaticMetrics")]
	public void SampleMetric(string name, double value)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[Calls(Type = typeof(File), Member = "WriteAllText")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SaveUserReportToDisk(UserReport userReport)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserReportingClient), Member = "SendUserReport")]
	public void SendUserReport(UserReport userReport, Action<bool, UserReport> callback)
	{
	}

	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(UserReportingClient), Member = "SendUserReport")]
	[CalledBy(Type = typeof(UserReportingScript), Member = "SubmitUserReport")]
	[CalledBy(Type = typeof(UserReportingMonitor), Member = "<Trigger>b__7_2")]
	[CalledBy(Type = typeof(InternalUserReport), Member = "SubmitUserReport")]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	public void SendUserReport(UserReport userReport, Action<float, float> progressCallback, Action<bool, UserReport> callback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserReportingClient), Member = "TakeScreenshotFromSource")]
	public void TakeScreenshot(int maximumWidth, int maximumHeight, Action<UserReportScreenshot> callback)
	{
	}

	[CalledBy(Type = typeof(UserReportingScript), Member = "CreateUserReport")]
	[CalledBy(Type = typeof(UserReportingScript), Member = "CreateUserReport")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(UserReportingClient), Member = "TakeScreenshot")]
	[CalledBy(Type = typeof(UserReportingMonitor), Member = "Trigger")]
	[CalledBy(Type = typeof(UserReportingMonitor), Member = "Trigger")]
	[CalledBy(Type = typeof(InternalUserReport), Member = "Send")]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	public void TakeScreenshotFromSource(int maximumWidth, int maximumHeight, object source, Action<UserReportScreenshot> callback)
	{
	}

	[CallsUnknownMethods(Count = 80)]
	[CalledBy(Type = typeof(UnityUserReportingUpdater), Member = "MoveNext")]
	[CalledBy(Type = typeof(UserReportingScriptNoPanel.TLDUserReportingUpdater), Member = "MoveNext")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleClientMetric")]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(UnityUserReportingUpdater), Member = "MoveNext")]
	[CalledBy(Type = typeof(UserReportingScriptNoPanel.TLDUserReportingUpdater), Member = "MoveNext")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleClientMetric")]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	public void UpdateOnEndOfFrame()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(UserReportingClient), Member = "CreateUserReport")]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass62_0), Member = "<WaitForPerforation>b__0")]
	[CallsUnknownMethods(Count = 17)]
	private void WaitForPerforation(int currentScreenshotsTaken, Action callback)
	{
	}
}
