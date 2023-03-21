using Cpp2ILInjected.CallAnalysis;

public static class PlayerRichPresenceManager
{
	private static IRichPresenceProvider s_RichPresenceProvider;

	[CalledBy(Type = typeof(GameManager), Member = "InstantiateOnlineSystems")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Shutdown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetLocalizationKeys(RichPresenceLocInfo[] locKeys)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static IRichPresenceProvider AllocatePresenceProvider()
	{
		return null;
	}
}
