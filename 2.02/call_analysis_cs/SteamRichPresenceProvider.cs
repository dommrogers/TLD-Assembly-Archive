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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SteamFriends), Member = "SetRichPresence")]
	[Calls(Type = typeof(SteamFriends), Member = "SetRichPresence")]
	[CallsUnknownMethods(Count = 1)]
	protected override void ChangePresence()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SteamRichPresenceProvider()
	{
	}
}
