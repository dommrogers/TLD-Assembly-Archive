using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud.UserReporting.Client;

public interface IUserReportingPlatform
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	T DeserializeJson<T>(string json);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	IDictionary<string, string> GetDeviceMetadata();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void ModifyUserReport(UserReport userReport);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void OnEndOfFrame(UserReportingClient client);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void Post(string endpoint, string contentType, byte[] content, Action<float, float> progressCallback, Action<bool, byte[]> callback);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void RunTask(Func<object> task, Action<object> callback);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SendAnalyticsEvent(string eventName, Dictionary<string, object> eventData);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	string SerializeJson(object instance);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void TakeScreenshot(int frameNumber, int maximumWidth, int maximumHeight, object source, Action<int, byte[]> callback);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Update(UserReportingClient client);
}
