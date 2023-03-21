using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.UserGeneratedContent;
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
		[CalledBy(Type = typeof(LanguageSelection), Member = "Refresh")]
		[CalledBy(Type = typeof(Localization), Member = "Get")]
		[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
		[CalledBy(Type = typeof(Localization), Member = "Exists")]
		[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
		[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
		[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(TypeFullName = "LanguageSelection.<>c", Member = "<Start>b__2_0")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
		[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
		[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lang")]
		[CallerCount(Count = 4)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[Calls(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	public static List<string> GetLanguages()
	{
		return null;
	}

	[CalledBy(Type = typeof(LanguageSelection), Member = "Refresh")]
	[CalledBy(Type = typeof(Localization), Member = "GetLanguages")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetLangIDFromName")]
	[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lang")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[Calls(Type = typeof(Localization), Member = "LoadWorkshopLocalization")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void MaybeLoadLanguageTables()
	{
	}

	[CalledBy(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
	[CalledBy(Type = typeof(Localization), Member = "Exists")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[Calls(Type = typeof(Localization), Member = "LoadStringTableForLanguage")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void MaybeLoadStringTable(string language)
	{
	}

	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GC), Member = "Collect")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
	[Calls(Type = typeof(StringTable), Member = "AddNewLanguage")]
	[CallsUnknownMethods(Count = 2)]
	private static void LoadStringTableForLanguage(AssetBundleRef assetBundle, string language)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private static bool ShouldDestroyCurrentStringTable()
	{
		return false;
	}

	[CalledBy(Type = typeof(Localization), Member = "get_Language")]
	[CalledBy(Type = typeof(Localization), Member = "set_Language")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(Localization), Member = "SelectLanguage")]
	[CallsUnknownMethods(Count = 1)]
	private static void LoadAndSelectLanguage(string language)
	{
	}

	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
	[Calls(Type = typeof(Workshop), Member = "GetContentRootPath")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "GetFiles")]
	[Calls(Type = typeof(StringTable), Member = "ImportCsv")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private static void LoadWorkshopLocalization()
	{
	}

	[CalledBy(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[Calls(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(UIRoot), Member = "Broadcast")]
	[Calls(Type = typeof(Localization), Member = "SelectLanguage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void SelectLanguage(string language)
	{
	}

	[CallerCount(Count = 1318)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(Localization), Member = "GetForFallbackLanguage")]
	[CallsUnknownMethods(Count = 1)]
	public static string Get(string key)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetLangIDFromName")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(Localization), Member = "GetForFallbackLanguage")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetForLang(string key, string lang)
	{
		return null;
	}

	[CalledBy(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[CallsUnknownMethods(Count = 1)]
	private static string GetForFallbackLanguage(string key)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeAutoAssignDialogueAnimationAndAudio")]
	[CalledBy(Type = typeof(Harvestable), Member = "ShowItemMessage")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateWhatIKnowPage")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMarkerFromLocation")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "FormatSubtitleText")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "LocIdFromEvent")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CalledBy(Type = typeof(LoadScene), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CalledBy(Type = typeof(VoiceOverItem), Member = "GetLocString")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeShowInitialSubtitle")]
	[CalledBy(Type = typeof(Utils), Member = "GetTitleString")]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CalledBy(Type = typeof(ConditionTable), Member = "GetDisplayNameWithCondition")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(StringTable), Member = "DoesKeyExist")]
	[CallsUnknownMethods(Count = 1)]
	public static bool Exists(string key)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static CharacterSet GetCharacterSet()
	{
		return default(CharacterSet);
	}
}
