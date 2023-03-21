using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting.Plugin.Version2018_3;

namespace Unity.Screenshots;

public class ScreenshotManager
{
	private class ScreenshotOperation
	{
		private Action<int, byte[]> _003CCallback_003Ek__BackingField;

		private byte[] _003CData_003Ek__BackingField;

		private int _003CFrameNumber_003Ek__BackingField;

		private bool _003CIsAwaiting_003Ek__BackingField;

		private bool _003CIsComplete_003Ek__BackingField;

		private bool _003CIsInUse_003Ek__BackingField;

		private int _003CMaximumHeight_003Ek__BackingField;

		private int _003CMaximumWidth_003Ek__BackingField;

		private object _003CSource_003Ek__BackingField;

		public Action<int, byte[]> Callback
		{
			[CallerCount(Count = 52)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
			[CallerCount(Count = 101)]
			[DeduplicatedMethod]
			[CompilerGenerated]
			set
			{
			}
		}

		public byte[] Data
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 71)]
			set
			{
			}
		}

		public int FrameNumber
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 1)]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public bool IsAwaiting
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[CompilerGenerated]
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

		public bool IsComplete
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

		public bool IsInUse
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return default(bool);
			}
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			set
			{
			}
		}

		public int MaximumHeight
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public int MaximumWidth
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return default(int);
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			set
			{
			}
		}

		public object Source
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 15)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 20)]
			set
			{
			}
		}

		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(ScreenshotManager), Member = "GetScreenshotOperation")]
		[CalledBy(Type = typeof(ScreenshotManager), Member = "GetScreenshotOperation")]
		public void Use()
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public ScreenshotOperation()
		{
		}
	}

	private Action<byte[], object> screenshotCallbackDelegate;

	private List<ScreenshotOperation> screenshotOperations;

	private ScreenshotRecorder screenshotRecorder;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScreenshotRecorder), Member = ".ctor")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = ".ctor")]
	[CallsUnknownMethods(Count = 21)]
	public ScreenshotManager()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(ScreenshotManager), Member = "TakeScreenshot")]
	[Calls(Type = typeof(ScreenshotOperation), Member = "Use")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "TakeScreenshot")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScreenshotOperation), Member = "Use")]
	private ScreenshotOperation GetScreenshotOperation()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ScreenshotManager), Member = "ScreenshotCallback")]
	[Calls(Type = typeof(ScreenshotRecorder), Member = "ScreenshotInternal")]
	[Calls(Type = typeof(ScreenshotRecorder), Member = "ScreenshotInternal")]
	[Calls(Type = typeof(ScreenshotRecorder), Member = "Screenshot")]
	[Calls(Type = typeof(ScreenshotRecorder), Member = "Screenshot")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "OnEndOfFrame")]
	public void OnEndOfFrame()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ScreenshotManager), Member = "OnEndOfFrame")]
	[CallerCount(Count = 1)]
	private void ScreenshotCallback(byte[] data, object state)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScreenshotManager), Member = "GetScreenshotOperation")]
	public void TakeScreenshot(object source, int frameNumber, int maximumWidth, int maximumHeight, Action<int, byte[]> callback)
	{
	}
}
