using Cpp2ILInjected.CallAnalysis;
using Steamworks;

public class SteamRichPresenceProvider : RichPresenceLocalizedProviderBase
{
	private const string SteamDisplayKeyName = "steam_display";

	private const string StatusKeyName = "#Status";

	private const string StatusVariableName = "status_value";

	[Calls(Type = typeof(SteamUser), Member = "BLoggedOn")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	protected override bool IsUserSignedOn()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SteamFriends), Member = "SetRichPresence")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(Localization), Member = "GetForFallbackLanguage")]
	[Calls(Type = typeof(SteamFriends), Member = "SetRichPresence")]
	[CallsUnknownMethods(Count = 1)]
	protected override void ChangePresence()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SteamRichPresenceProvider()
	{
	}
}
