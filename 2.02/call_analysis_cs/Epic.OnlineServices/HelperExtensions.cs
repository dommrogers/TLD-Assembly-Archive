using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

public static class HelperExtensions
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "IsOperationComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsOperationComplete(this Result result)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "ToHexString")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string ToHexString(this byte[] byteArray)
	{
		return null;
	}
}
