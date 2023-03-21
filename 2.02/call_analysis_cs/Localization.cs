using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class Localization
{
	public const string kDefaultLanguage = "English";

	private static StringTable s_SettingsTable;

	private static StringTable s_CurrentLanguageStringTable;

	private static StringTable s_WorkshopStringTable;

	private static StringTable s_FallbackStringTable;

	private static string s_Language;

	private static int s_LanguageIndex;

	private static List<string> s_Languages;

	private static CharacterSet s_CharacterSet;

	public static string Language
	{
		[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
		[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
		[CalledBy(Type = typeof(Localization), Member = "Exists")]
		[CalledBy(Type = typeof(Localization), Member = "Get")]
		[CalledBy(Type = typeof(LanguageSelection), Member = "Refresh")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
		[CallerCount(Count = 6)]
		get
		{
			return null;
		}
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lang")]
		[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
		[CalledBy(Type = typeof(LanguageSelection._003C_003Ec), Member = "<Start>b__2_0")]
		[Calls(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetLangIDFromName")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lang")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[CalledBy(Type = typeof(LanguageSelection), Member = "Refresh")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static List<string> GetLanguages()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "LoadWorkshopLocalization")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[CalledBy(Type = typeof(Localization), Member = "GetLanguages")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static void MaybeLoadLanguageTables()
	{
	}

	[CalledBy(Type = typeof(Localization), Member = "Exists")]
	[CalledBy(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
	[Calls(Type = typeof(Localization), Member = "LoadStringTableForLanguage")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[CallerCount(Count = 3)]
	private static void MaybeLoadStringTable(string language)
	{
	}

	[Calls(Type = typeof(GC), Member = "Collect")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(StringTable), Member = "AddNewLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "ShouldDestroyCurrentStringTable")]
	private static void LoadStringTableForLanguage(AssetBundleRef assetBundle, string language)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Localization), Member = "LoadStringTableForLanguage")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private static bool ShouldDestroyCurrentStringTable()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Localization), Member = "set_Language")]
	[CalledBy(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(Localization), Member = "SelectLanguage")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void LoadAndSelectLanguage(string language)
	{
	}

	[Calls(Type = typeof(DirectoryInfo), Member = "get_Parent")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DirectoryInfo), Member = "get_Parent")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "GetFiles")]
	[Calls(Type = typeof(StringTable), Member = "ImportCsv")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Directory), Member = "GetParent")]
	private static void LoadWorkshopLocalization()
	{
	}

	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(UIRoot), Member = "Broadcast")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(Localization), Member = "SelectLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "GetLanguages")]
	private static void SelectLanguage(string language)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetForFallbackLanguage")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1164)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static string Get(string key)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetLangIDFromName")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[CallerCount(Count = 3)]
	public static string GetForLang(string key, string lang)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	private static string GetForFallbackLanguage(string key)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMarkerFromLocation")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "FormatSubtitleText")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "LocIdFromEvent")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeShowInitialSubtitle")]
	[CalledBy(Type = typeof(VoiceOverItem), Member = "GetLocString")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CalledBy(Type = typeof(ConditionTableManager), Member = "GetDisplayNameWithCondition")]
	[CalledBy(Type = typeof(LoadScene), Member = "GetHoverText")]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[Calls(Type = typeof(StringTable), Member = "DoesKeyExist")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 19)]
	[CalledBy(Type = typeof(Utils), Member = "GetTitleString")]
	[CalledBy(Type = typeof(Harvestable), Member = "ShowItemMessage")]
	public static bool Exists(string key)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static CharacterSet GetCharacterSet()
	{
		return default(CharacterSet);
	}
}
