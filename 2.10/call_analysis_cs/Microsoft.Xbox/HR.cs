using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xbox;

internal class HR
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal static bool SUCCEEDED(int hr)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal static bool FAILED(int hr)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public HR()
	{
	}
}
