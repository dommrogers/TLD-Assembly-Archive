using Cpp2ILInjected.CallAnalysis;
using TLD.Logging;

public static class PlayerRichPresenceManager
{
	public static readonly LogFilter s_LogFilter;

	private static IRichPresenceProvider s_RichPresenceProvider;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void Shutdown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetLocalizationKeys(RichPresenceLocInfo[] locKeys)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static IRichPresenceProvider AllocatePresenceProvider()
	{
		return null;
	}
}
