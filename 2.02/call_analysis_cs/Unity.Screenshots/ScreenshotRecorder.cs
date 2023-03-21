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
			[CallerCount(Count = 9)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			set
			{
			}
		}

		public int Height
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

		public int Identifier
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
			[CallerCount(Count = 1)]
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

		public NativeArray<byte> NativeData
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return default(NativeArray<byte>);
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public Texture Source
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 11)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 18)]
			set
			{
			}
		}

		public object State
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 11)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 16)]
			set
			{
			}
		}

		public ScreenshotType Type
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
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
				return 0;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		[CalledBy(Type = typeof(ScreenshotRecorder), Member = "GetOperation")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 14)]
		public ScreenshotOperation()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Downsampler), Member = "Downsample")]
		[Calls(Type = typeof(PngEncoder), Member = "Encode")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		private void EncodeCallback(object state)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Directory), Member = "Exists")]
		[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(File), Member = "WriteAllBytes")]
		[CallsDeduplicatedMethods(Count = 1)]
		private void SavePngToDisk(byte[] byteData)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncGPUReadbackRequest), Member = "GetData")]
		[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 4)]
		private void ScreenshotCallback(AsyncGPUReadbackRequest request)
		{
		}
	}

	private static int nextIdentifier;

	private List<ScreenshotOperation> operationPool;

	[CalledBy(Type = typeof(ScreenshotManager), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public ScreenshotRecorder()
	{
	}

	[CalledBy(Type = typeof(ScreenshotRecorder), Member = "ScreenshotInternal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ScreenshotOperation), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private ScreenshotOperation GetOperation()
	{
		return null;
	}

	[CalledBy(Type = typeof(ScreenshotManager), Member = "OnEndOfFrame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScreenshotRecorder), Member = "ScreenshotInternal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Screenshot(int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(ScreenshotManager), Member = "OnEndOfFrame")]
	[CallerCount(Count = 1)]
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
	[CalledBy(Type = typeof(ScreenshotRecorder), Member = "Screenshot")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScreenshotRecorder), Member = "GetOperation")]
	[Calls(Type = typeof(AsyncGPUReadback), Member = "Request")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void ScreenshotInternal(Texture source, int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
	{
	}
}
