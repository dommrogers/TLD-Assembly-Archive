using Cpp2ILInjected.CallAnalysis;

namespace Marketplace;

public class MarketplaceManager
{
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void Create()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool AmFullyInitialized()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public MarketplaceManager()
	{
	}
}
