using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using Steamworks;

public class SteamRichPresenceProvider : RichPresenceLocalizedProviderBase
{
	private const string SteamDisplayKeyName = "steam_display";

	private const string StatusKeyName = "#Status";

	private const string StatusVariableName = "status_value";

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(SteamUser), Member = "BLoggedOn")]
	protected override bool IsUserSignedOn()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
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
