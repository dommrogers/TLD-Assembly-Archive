using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting.Client;
using Unity.Cloud.UserReporting.Plugin.SimpleJson;
using Unity.Screenshots;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Networking;
using UnityEngine.Profiling;
using UnityEngine.SceneManagement;

namespace Unity.Cloud.UserReporting.Plugin.Version2018_3;

public class AsyncUnityUserReportingPlatform : IUserReportingPlatform
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
			[CallerCount(Count = 101)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			set
			{
			}
		}

		public Action<float, float> ProgressCallback
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CallerCount(Count = 71)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			set
			{
			}
		}

		public UnityWebRequest WebRequest
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

	private List<LogMessage> logMessages;

	private List<PostOperation> postOperations;

	private List<ProfilerSampler> profilerSamplers;

	private ScreenshotManager screenshotManager;

	private List<PostOperation> taskOperations;

	[Calls(Type = typeof(Application), Member = "add_logMessageReceivedThreaded")]
	[Calls(Type = typeof(Recorder), Member = "set_enabled")]
	[Calls(Type = typeof(Sampler), Member = "GetRecorder")]
	[Calls(Type = typeof(Sampler), Member = "get_isValid")]
	[CallsUnknownMethods(Count = 51)]
	[Calls(Type = typeof(ScreenshotManager), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sampler), Member = "Get")]
	public AsyncUnityUserReportingPlatform()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public T DeserializeJson<T>(string json)
	{
		return (T)null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScreenshotManager), Member = "OnEndOfFrame")]
	[CallsUnknownMethods(Count = 1)]
	public void OnEndOfFrame(UserReportingClient client)
	{
	}

	[Calls(Type = typeof(UnityWebRequest), Member = "set_downloadHandler")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
	[Calls(Type = typeof(UnityWebRequest), Member = "set_uploadHandler")]
	[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader")]
	[Calls(Type = typeof(UnityWebRequest), Member = ".ctor")]
	[Calls(Type = typeof(UploadHandlerRaw), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Unity.Cloud.UserReporting.Plugin.SimpleJson.SimpleJson), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	public string SerializeJson(object instance)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScreenshotManager), Member = "GetScreenshotOperation")]
	[CallsUnknownMethods(Count = 1)]
	public void TakeScreenshot(int frameNumber, int maximumWidth, int maximumHeight, object source, Action<int, byte[]> callback)
	{
	}

	[Calls(Type = typeof(UnityWebRequest), Member = "get_responseCode")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_responseCode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_downloadProgress")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_uploadProgress")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	[Calls(Type = typeof(Recorder), Member = "get_isValid")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UserReportingClient), Member = "LogEvent")]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public void Update(UserReportingClient client)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public virtual IDictionary<string, string> GetDeviceMetadata()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public virtual Dictionary<string, string> GetSamplerNames()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	public virtual void ModifyUserReport(UserReport userReport)
	{
	}

	[Calls(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	[Calls(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	[CallsUnknownMethods(Count = 7)]
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
