using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace Unity.Screenshots;

public class ScreenshotRecorder
{
	private class ScreenshotOperation
	{
		public WaitCallback EncodeCallbackDelegate;

		public Action<AsyncGPUReadbackRequest> ScreenshotCallbackDelegate;

		private Action<byte[], object> _003CCallback_003Ek__BackingField;

		private int _003CHeight_003Ek__BackingField;

		private int _003CIdentifier_003Ek__BackingField;

		private bool _003CIsInUse_003Ek__BackingField;

		private int _003CMaximumHeight_003Ek__BackingField;

		private int _003CMaximumWidth_003Ek__BackingField;

		private NativeArray<byte> _003CNativeData_003Ek__BackingField;

		private Texture _003CSource_003Ek__BackingField;

		private object _003CState_003Ek__BackingField;

		private ScreenshotType _003CType_003Ek__BackingField;

		private int _003CWidth_003Ek__BackingField;

		public Action<byte[], object> Callback
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 5)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 41)]
			set
			{
			}
		}

		public int Height
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

		public int Identifier
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
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

		public bool IsInUse
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

		public int MaximumHeight
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			get
			{
				return default(int);
			}
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
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
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public NativeArray<byte> NativeData
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return default(NativeArray<byte>);
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			set
			{
			}
		}

		public Texture Source
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 5)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 14)]
			set
			{
			}
		}

		public object State
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 10)]
			get
			{
				return null;
			}
			[CallerCount(Count = 15)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			set
			{
			}
		}

		public ScreenshotType Type
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			get
			{
				return default(ScreenshotType);
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public int Width
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

		[CalledBy(Type = typeof(ScreenshotRecorder), Member = "GetOperation")]
		[CallsUnknownMethods(Count = 14)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ScreenshotOperation()
		{
		}

		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(PngEncoder), Member = "Encode")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Downsampler), Member = "Downsample")]
		private void EncodeCallback(object state)
		{
		}

		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Directory), Member = "Exists")]
		[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(File), Member = "WriteAllBytes")]
		private void SavePngToDisk(byte[] byteData)
		{
		}

		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 4)]
		private void ScreenshotCallback(AsyncGPUReadbackRequest request)
		{
		}
	}

	private static int nextIdentifier;

	private List<ScreenshotOperation> operationPool;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ScreenshotManager), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public ScreenshotRecorder()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ScreenshotOperation), Member = ".ctor")]
	[CalledBy(Type = typeof(ScreenshotRecorder), Member = "ScreenshotInternal")]
	[CallsUnknownMethods(Count = 12)]
	private ScreenshotOperation GetOperation()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ScreenshotRecorder), Member = "ScreenshotInternal")]
	[CalledBy(Type = typeof(ScreenshotManager), Member = "OnEndOfFrame")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Screenshot(int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ScreenshotManager), Member = "OnEndOfFrame")]
	public void Screenshot(Camera source, int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
	{
	}

	[DeduplicatedMethod]
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Screenshot(RenderTexture source, int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
	{
	}

	[DeduplicatedMethod]
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Screenshot(Texture2D source, int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
	{
	}

	[CalledBy(Type = typeof(ScreenshotManager), Member = "OnEndOfFrame")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ScreenshotRecorder), Member = "Screenshot")]
	[Calls(Type = typeof(AsyncGPUReadback), Member = "Request")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ScreenshotRecorder), Member = "GetOperation")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(ScreenshotManager), Member = "OnEndOfFrame")]
	private void ScreenshotInternal(Texture source, int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
	{
	}
}
