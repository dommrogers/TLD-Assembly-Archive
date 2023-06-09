using Cpp2ILInjected.CallAnalysis;

namespace SpecialEvents;

public static class NowhereToHide
{
	public enum GlyphTypes
	{
		None,
		DispelFog,
		Lure,
		Ward
	}

	public const ExperienceModeType EVENT_XPMODE = ExperienceModeType.ChallengeNowhereToHide;

	public const ExperienceModeType BASE_XPMODE = ExperienceModeType.Voyageur;

	public const string MAINMENU_DESC_LOCID = "GAMEPLAY_NowhereToHideDesc";

	public const string MAINMENU_LABEL_LOCID = "GAMEPLAY_NowhereToHide";

	public const string SANDBOXMENU_DESC_SUFFIX = "DWDesc";

	private const int LAST_DW_EVENT_CHANGELIST = 69021;

	public static bool s_Debug;

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	public static bool IsCurrentExperienceMode()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool MatchesExperienceMode(ExperienceModeType xpMode)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[CallsUnknownMethods(Count = 1)]
	public static void PostEventDeleteSaveSlot(SaveSlotInfo ssi)
	{
	}
}
