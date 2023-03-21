using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud.UserReporting.Client;

public class NullUserReportingPlatform : IUserReportingPlatform
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public T DeserializeJson<T>(string json)
	{
		return (T)null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public IDictionary<string, string> GetDeviceMetadata()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void ModifyUserReport(UserReport userReport)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void OnEndOfFrame(UserReportingClient client)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Post(string endpoint, string contentType, byte[] content, Action<float, float> progressCallback, Action<bool, byte[]> callback)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void RunTask(Func<object> task, Action<object> callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SendAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string SerializeJson(object instance)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void TakeScreenshot(int frameNumber, int maximumWidth, int maximumHeight, object source, Action<int, byte[]> callback)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Update(UserReportingClient client)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public NullUserReportingPlatform()
	{
	}
}
