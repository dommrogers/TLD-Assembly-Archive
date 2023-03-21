using Cpp2ILInjected.CallAnalysis;
using TLD.Logging;

public static class PlayerRichPresenceManager
{
	public static readonly LogFilter s_LogFilter;

	private static IRichPresenceProvider s_RichPresenceProvider;

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateOnlineSystems")]
	public static void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 6)]
	private static IRichPresenceProvider AllocatePresenceProvider()
	{
		return null;
	}
}
