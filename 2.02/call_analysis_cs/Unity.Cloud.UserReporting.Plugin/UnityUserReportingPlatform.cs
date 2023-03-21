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
			[CallerCount(Count = 52)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 101)]
			set
			{
			}
		}

		public Action<float, float> ProgressCallback
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

		public UnityWebRequest WebRequest
		{
			[CallerCount(Count = 5)]
			[CompilerGenerated]
			[DeduplicatedMethod]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
			return default(double);
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
			[CallerCount(Count = 52)]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 101)]
			[CompilerGenerated]
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
				return default(int);
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
				return default(int);
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			set
			{
			}
		}

		public int MaximumWidth
		{
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[CompilerGenerated]
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
			[CallerCount(Count = 20)]
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
			[CallerCount(Count = 20)]
			[DeduplicatedMethod]
			[CompilerGenerated]
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
			[CallerCount(Count = 41)]
			set
			{
			}
		}

		public Texture2D TextureResized
		{
			[CallerCount(Count = 3)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 17)]
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
				return default(int);
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
			[CallerCount(Count = 3)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
	[CallsUnknownMethods(Count = 58)]
	[Calls(Type = typeof(Application), Member = "add_logMessageReceivedThreaded")]
	[Calls(Type = typeof(Recorder), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Sampler), Member = "get_isValid")]
	[Calls(Type = typeof(Sampler), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Sampler), Member = "GetRecorder")]
	public UnityUserReportingPlatform()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public T DeserializeJson<T>(string json)
	{
		return (T)null;
	}

	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleClientMetric")]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(ImageConversion), Member = "EncodeToPNG")]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleClientMetric")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 65)]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleClientMetric")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Camera), Member = "Render")]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleClientMetric")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	public void OnEndOfFrame(UserReportingClient client)
	{
	}

	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler")]
	[Calls(Type = typeof(UploadHandlerRaw), Member = ".ctor")]
	[Calls(Type = typeof(UnityWebRequest), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler")]
	public void Post(string endpoint, string contentType, byte[] content, Action<float, float> progressCallback, Action<bool, byte[]> callback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void RunTask(Func<object> task, Action<object> callback)
	{
	}

	[Calls(Type = typeof(Analytics), Member = "CustomEvent")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SendAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Unity.Cloud.UserReporting.Plugin.SimpleJson.SimpleJson), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	public string SerializeJson(object instance)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public void TakeScreenshot(int frameNumber, int maximumWidth, int maximumHeight, object source, Action<int, byte[]> callback)
	{
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_responseCode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_responseCode")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_downloadProgress")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
	[Calls(Type = typeof(Recorder), Member = "get_isValid")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_uploadProgress")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Update(UserReportingClient client)
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 46)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsDeduplicatedMethods(Count = 68)]
	[CallerCount(Count = 0)]
	public virtual IDictionary<string, string> GetDeviceMetadata()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 22)]
	public virtual Dictionary<string, string> GetSamplerNames()
	{
		return null;
	}

	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	public virtual void ModifyUserReport(UserReport userReport)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	public virtual void SampleAutomaticMetrics(UserReportingClient client)
	{
	}
}
