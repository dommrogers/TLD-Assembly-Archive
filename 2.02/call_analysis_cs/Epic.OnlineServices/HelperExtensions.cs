using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

public static class HelperExtensions
{
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "IsOperationComplete")]
	[CallerCount(Count = 0)]
	public static bool IsOperationComplete(this Result result)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "ToHexString")]
	public static string ToHexString(this byte[] byteArray)
	{
		return null;
	}
}
