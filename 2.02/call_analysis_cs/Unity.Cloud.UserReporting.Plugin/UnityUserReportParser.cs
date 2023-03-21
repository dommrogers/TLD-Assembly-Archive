using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud.UserReporting.Plugin;

public static class UnityUserReportParser
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static UserReport ParseUserReport(string json)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static UserReportList ParseUserReportList(string json)
	{
		return null;
	}
}
