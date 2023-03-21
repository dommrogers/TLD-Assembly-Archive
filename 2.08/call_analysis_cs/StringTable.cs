using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StringTable : StringTableData
{
	private const string LEGACY_CYRILLIC_OVERRIDE_KEY = "UseCyrillicFont";

	public const string CHARACTER_SET_KEY = "CharacterSet";

	private const string CHARACTER_SET_LATIN = "Latin";

	private const string CHARACTER_SET_CYRILLIC = "Cyrillic";

	private const string CHARACTER_SET_CJK = "CJK";

	private const string CHARACTER_SET_INUKTITUT = "Inuktitut";

	public const string NOTES_LANGUAGE = "NOTES";

	private List<string> m_Languages;

	private bool m_IsGeneratedByCode;

	private List<StringTableData> m_OverflowDataFiles;

	private string m_OverflowDataFolder;

	private const int ENTRY_LIMIT = 5000;

	private const string OVERFLOW_FILENAME_FORMAT = "{0}_OverflowData_{1}.asset";

	private List<StringTableData> m_DataFiles;

	private List<Entry> m_AllEntries;

	private Dictionary<string, Entry> m_EntriesMap;

	private StringTableData m_CurrentDataFile;

	private const int INVALID_LANGUAGE = -1;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsUsingLegacyCyrillicOverride(string language)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public CharacterSet GetCharacterSetForLanguage(int languageIndex)
	{
		return default(CharacterSet);
	}

	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllLanguagesWithCharacterSet")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	public CharacterSet GetCharacterSetForLanguage(string language)
	{
		return default(CharacterSet);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 27)]
	public List<string> GetLanguages()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsInitialized()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsGeneratedByCode()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetGeneratedByCode()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SteamRichPresenceProvider), Member = "ChangePresence")]
	[CalledBy(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
	[CalledBy(Type = typeof(StringTable), Member = "IsUsingLegacyCyrillicOverride")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "GetForFallbackLanguage")]
	[CalledBy(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
	[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
	[CalledBy(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
	public string GetStringForKeyAndLanguage(string key, string language)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetStringForKeyAndLanguage(string key, int languageIndex)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Localization), Member = "LoadStringTableForLanguage")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	public void AddNewLanguage(string language)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	public bool HasLanguage(string language)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(StringTable), Member = "HasLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
	[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "LoadStringTableForLanguage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	public int IndexOfLanguage(string language)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(StringTable), Member = "ParseLanguages")]
	[CalledBy(Type = typeof(StringTable), Member = "RemoveEntryForKey")]
	[CalledBy(Type = typeof(StringTable), Member = "GetKeyForEntry")]
	[CalledBy(Type = typeof(StringTable), Member = "GetKeyForEntry")]
	[CalledBy(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[CalledBy(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[CalledBy(Type = typeof(StringTable), Member = "DoesKeyExist")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(StringTable), Member = "AddNewLanguage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(StringTable), Member = "GetNumEntries")]
	private void InitializeData(bool forceInit = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumEntries()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[CalledBy(Type = typeof(Localization), Member = "Exists")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	public bool DoesKeyExist(string key)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(StringTable), Member = "DoesKeyExist")]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[CalledBy(Type = typeof(StringTable), Member = "AddOrUpdateTableEntry")]
	[CallsUnknownMethods(Count = 8)]
	private Entry AddEntryForKey(string key)
	{
		return null;
	}

	[CalledBy(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[CalledBy(Type = typeof(StringTable), Member = "AddOrUpdateTableEntry")]
	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[CalledBy(Type = typeof(StringTable), Member = "RemoveEntryForKey")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[CallsDeduplicatedMethods(Count = 1)]
	private Entry GetEntryFromKey(string key)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetKeyForEntry(int index)
	{
		return null;
	}

	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CallsUnknownMethods(Count = 8)]
	private void RemoveEntryForKey(string key)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldImportLanguage(string language, List<string> importLanguages)
	{
		return default(bool);
	}

	[Calls(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Localization), Member = "LoadWorkshopLocalization")]
	[Calls(Type = typeof(ByteReader), Member = "ReadCSV")]
	[Calls(Type = typeof(StringTable), Member = "ParseLanguages")]
	[Calls(Type = typeof(ByteReader), Member = "ReadCSV")]
	[Calls(Type = typeof(File), Member = "ReadAllText")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public List<string> ImportCsv(string path, List<string> filterLanguages)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[CallsUnknownMethods(Count = 9)]
	private int[] ParseLanguages(BetterList<string> languages, List<string> filterLanguages)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[Calls(Type = typeof(StringTable), Member = "AddEntryForKey")]
	private void AddOrUpdateTableEntry(string key, BetterList<string> importEntryLanguages, int[] languageIndexes)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public StringTable()
	{
	}
}
