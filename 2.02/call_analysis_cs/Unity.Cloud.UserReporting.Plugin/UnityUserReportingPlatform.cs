using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting.Client;
using Unity.Cloud.UserReporting.Plugin.SimpleJson;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Networking;
using UnityEngine.Profiling;
using UnityEngine.SceneManagement;

namespace Unity.Cloud.UserReporting.Plugin;

public class UnityUserReportingPlatform : IUserReportingPlatform
{
	private struct LogMessage
	{
		public string LogString;

		public LogType LogType;

		public string StackTrace;
	}

	private class PostOperation
	{
		private Action<bool, byte[]> _003CCallback_003Ek__BackingField;

		private Action<float, float> _003CProgressCallback_003Ek__BackingField;

		private UnityWebRequest _003CWebRequest_003Ek__BackingField;

		public Action<bool, byte[]> Callback
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

		public Action<float, float> ProgressCallback
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

		public UnityWebRequest WebRequest
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

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public PostOperation()
		{
		}
	}

	private struct ProfilerSampler
	{
		public string Name;

		public Recorder Recorder;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Recorder), Member = "get_elapsedNanoseconds")]
		public double GetValue()
		{
			return 0.0;
		}
	}

	private class ScreenshotOperation
	{
		private Action<int, byte[]> _003CCallback_003Ek__BackingField;

		private int _003CFrameNumber_003Ek__BackingField;

		private int _003CMaximumHeight_003Ek__BackingField;

		private int _003CMaximumWidth_003Ek__BackingField;

		private byte[] _003CPngData_003Ek__BackingField;

		private object _003CSource_003Ek__BackingField;

		private ScreenshotStage _003CStage_003Ek__BackingField;

		private Texture2D _003CTexture_003Ek__BackingField;

		private Texture2D _003CTextureResized_003Ek__BackingField;

		private int _003CUnityFrame_003Ek__BackingField;

		private int _003CWaitFrames_003Ek__BackingField;

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

		public int FrameNumber
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 8)]
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

		public byte[] PngData
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 12)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 24)]
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

		public ScreenshotStage Stage
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return default(ScreenshotStage);
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public Texture2D Texture
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
			[CallerCount(Count = 46)]
			set
			{
			}
		}

		public Texture2D TextureResized
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 3)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 19)]
			set
			{
			}
		}

		public int UnityFrame
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 3)]
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

		public int WaitFrames
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 3)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ScreenshotOperation()
		{
		}
	}

	private enum ScreenshotStage
	{
		Render,
		ReadPixels,
		GetPixels,
		EncodeToPNG,
		Done
	}

	private List<LogMessage> logMessages;

	private List<PostOperation> postOperations;

	private List<ProfilerSampler> profilerSamplers;

	private List<ScreenshotOperation> screenshotOperations;

	private Stopwatch screenshotStopwatch;

	private List<PostOperation> taskOperations;

	[CalledBy(Type = typeof(UnityUserReporting), Member = "GetPlatform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Sampler), Member = "Get")]
	[Calls(Type = typeof(Sampler), Member = "get_isValid")]
	[Calls(Type = typeof(Sampler), Member = "GetRecorder")]
	[Calls(Type = typeof(Recorder), Member = "set_enabled")]
	[Calls(Type = typeof(Application), Member = "add_logMessageReceivedThreaded")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 58)]
	public UnityUserReportingPlatform()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public T DeserializeJson<T>(string json)
	{
		return default(T);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture")]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[Calls(Type = typeof(Camera), Member = "Render")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleClientMetric")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(ImageConversion), Member = "EncodeToPNG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 65)]
	public void OnEndOfFrame(UserReportingClient client)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityWebRequest), Member = ".ctor")]
	[Calls(Type = typeof(UploadHandlerRaw), Member = ".ctor")]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler")]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler")]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader")]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 32)]
	public void Post(string endpoint, string contentType, byte[] content, Action<float, float> progressCallback, Action<bool, byte[]> callback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void RunTask(Func<object> task, Action<object> callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Analytics), Member = "CustomEvent")]
	public void SendAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Cloud.UserReporting.Plugin.SimpleJson.SimpleJson), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string SerializeJson(object instance)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public void TakeScreenshot(int frameNumber, int maximumWidth, int maximumHeight, object source, Action<int, byte[]> callback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Recorder), Member = "get_isValid")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_uploadProgress")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_downloadProgress")]
	[Calls(Type = typeof(Action<, >), Member = "Invoke")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_responseCode")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 42)]
	public void Update(UserReportingClient client)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 68)]
	[CallsUnknownMethods(Count = 46)]
	public virtual IDictionary<string, string> GetDeviceMetadata()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 8)]
	public virtual Dictionary<string, string> GetSamplerNames()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 35)]
	public virtual void ModifyUserReport(UserReport userReport)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	public virtual void SampleAutomaticMetrics(UserReportingClient client)
	{
	}
}
