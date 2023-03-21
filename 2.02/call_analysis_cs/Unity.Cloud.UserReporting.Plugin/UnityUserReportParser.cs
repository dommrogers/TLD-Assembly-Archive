using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting.Plugin.SimpleJson;

namespace Unity.Cloud.UserReporting.Plugin;

public static class UnityUserReportParser
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Cloud.UserReporting.Plugin.SimpleJson.SimpleJson), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static UserReport ParseUserReport(string json)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Cloud.UserReporting.Plugin.SimpleJson.SimpleJson), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static UserReportList ParseUserReportList(string json)
	{
		return null;
	}
}
