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
		[CalledBy(Type = typeof(LanguageSelection), Member = "Refresh")]
		[CalledBy(Type = typeof(Localization), Member = "Get")]
		[CalledBy(Type = typeof(Localization), Member = "Exists")]
		[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
		[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
		[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
		[CallerCount(Count = 7)]
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
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		set
		{
		}
	}

	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CallerCount(Count = 0)]
	public static List<string> GetLanguages()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(LanguageSelection), Member = "Refresh")]
	[Calls(Type = typeof(Localization), Member = "LoadWorkshopLocalization")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Localization), Member = "GetLanguages")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lang")]
	[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetLangIDFromName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	private static void MaybeLoadLanguageTables()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[CalledBy(Type = typeof(Localization), Member = "Exists")]
	[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
	[CalledBy(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(Localization), Member = "LoadStringTableForLanguage")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private static void MaybeLoadStringTable(string language)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(StringTable), Member = "AddNewLanguage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GC), Member = "Collect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private static void LoadStringTableForLanguage(AssetBundleRef assetBundle, string language)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	private static bool ShouldDestroyCurrentStringTable()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "SelectLanguage")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Localization), Member = "set_Language")]
	[CalledBy(Type = typeof(Localization), Member = "get_Language")]
	[CallsUnknownMethods(Count = 1)]
	private static void LoadAndSelectLanguage(string language)
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Workshop), Member = "GetContentRootPath")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(StringTable), Member = "ImportCsv")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Directory), Member = "GetFiles")]
	private static void LoadWorkshopLocalization()
	{
	}

	[Calls(Type = typeof(UIRoot), Member = "Broadcast")]
	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "LoadAndSelectLanguage")]
	[Calls(Type = typeof(Localization), Member = "SelectLanguage")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void SelectLanguage(string language)
	{
	}

	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(Localization), Member = "GetForFallbackLanguage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1317)]
	public static string Get(string key)
	{
		return null;
	}

	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetLangIDFromName")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[Calls(Type = typeof(Localization), Member = "GetForFallbackLanguage")]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	public static string GetForLang(string key, string lang)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
	[CalledBy(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	private static string GetForFallbackLanguage(string key)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "DoesKeyExist")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
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
