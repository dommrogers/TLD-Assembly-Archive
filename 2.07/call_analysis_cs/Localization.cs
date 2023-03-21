using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
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
		[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
		[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
		[CalledBy(Type = typeof(SteamRichPresenceProvider), Member = "ChangePresence")]
		[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
		[CalledBy(Type = typeof(Localization), Member = "Get")]
		[CalledBy(Type = typeof(LanguageSelection), Member = "Refresh")]
		[Calls(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(Localization), Member = "Exists")]
		[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
		[CalledBy(Type = typeof(LanguageSelection._003C_003Ec), Member = "<Start>b__2_0")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
		[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
		[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lang")]
		[CallerCount(Count = 4)]
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

	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[CalledBy(Type = typeof(Localization), Member = "GetLanguages")]
	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetLangIDFromName")]
	[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lang")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LanguageSelection), Member = "Refresh")]
	[Calls(Type = typeof(Localization), Member = "LoadWorkshopLocalization")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	private static void MaybeLoadLanguageTables()
	{
	}

	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[CalledBy(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "LoadStringTableForLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
	[CalledBy(Type = typeof(Localization), Member = "Exists")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(SteamRichPresenceProvider), Member = "ChangePresence")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	private static void MaybeLoadStringTable(string language)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GC), Member = "Collect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Localization), Member = "ShouldDestroyCurrentStringTable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StringTable), Member = "AddNewLanguage")]
	[CallerCount(Count = 1)]
	private static void LoadStringTableForLanguage(AssetBundleRef assetBundle, string language)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Localization), Member = "LoadStringTableForLanguage")]
	[CallsUnknownMethods(Count = 1)]
	private static bool ShouldDestroyCurrentStringTable()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Localization), Member = "set_Language")]
	[CalledBy(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(Localization), Member = "SelectLanguage")]
	private static void LoadAndSelectLanguage(string language)
	{
	}

	[Calls(Type = typeof(Directory), Member = "GetFiles")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Workshop), Member = "GetContentRootPath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(StringTable), Member = "ImportCsv")]
	[CallsUnknownMethods(Count = 7)]
	private static void LoadWorkshopLocalization()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[Calls(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(UIRoot), Member = "Broadcast")]
	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
	[Calls(Type = typeof(Localization), Member = "SelectLanguage")]
	private static void SelectLanguage(string language)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetForFallbackLanguage")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[CallerCount(Count = 1326)]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	public static string Get(string key)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetLangIDFromName")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[Calls(Type = typeof(Localization), Member = "GetForFallbackLanguage")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	public static string GetForLang(string key, string lang)
	{
		return null;
	}

	[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
	[CalledBy(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(SteamRichPresenceProvider), Member = "ChangePresence")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[CallsUnknownMethods(Count = 1)]
	private static string GetForFallbackLanguage(string key)
	{
		return null;
	}

	[Calls(Type = typeof(StringTable), Member = "DoesKeyExist")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[CallerCount(Count = 20)]
	[CallsUnknownMethods(Count = 1)]
	public static bool Exists(string key)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static CharacterSet GetCharacterSet()
	{
		return default(CharacterSet);
	}
}
