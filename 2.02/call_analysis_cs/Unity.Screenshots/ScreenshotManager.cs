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
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 59)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 103)]
			set
			{
			}
		}

		public byte[] Data
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 77)]
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
				return 0;
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
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return false;
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
				return false;
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
				return false;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public int MaximumHeight
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			get
			{
				return 0;
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
				return 0;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public object Source
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 17)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 23)]
			set
			{
			}
		}

		[CalledBy(Type = typeof(ScreenshotManager), Member = "GetScreenshotOperation")]
		[CallerCount(Count = 2)]
		public void Use()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ScreenshotOperation()
		{
		}
	}

	private Action<byte[], object> screenshotCallbackDelegate;

	private List<ScreenshotOperation> screenshotOperations;

	private ScreenshotRecorder screenshotRecorder;

	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScreenshotRecorder), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public ScreenshotManager()
	{
	}

	[CalledBy(Type = typeof(ScreenshotManager), Member = "TakeScreenshot")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "TakeScreenshot")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ScreenshotOperation), Member = "Use")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private ScreenshotOperation GetScreenshotOperation()
	{
		return null;
	}

	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "OnEndOfFrame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ScreenshotManager), Member = "ScreenshotCallback")]
	[Calls(Type = typeof(ScreenshotRecorder), Member = "ScreenshotInternal")]
	[Calls(Type = typeof(ScreenshotRecorder), Member = "Screenshot")]
	[Calls(Type = typeof(ScreenshotRecorder), Member = "Screenshot")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void OnEndOfFrame()
	{
	}

	[CalledBy(Type = typeof(ScreenshotManager), Member = "OnEndOfFrame")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ScreenshotCallback(byte[] data, object state)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScreenshotManager), Member = "GetScreenshotOperation")]
	[CallsUnknownMethods(Count = 1)]
	public void TakeScreenshot(object source, int frameNumber, int maximumWidth, int maximumHeight, Action<int, byte[]> callback)
	{
	}
}
