using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

public class StringTable : StringTableData
{
	private const string LEGACY_CYRILLIC_OVERRIDE_KEY = "UseCyrillicFont";

	public const string CHARACTER_SET_KEY = "CharacterSet";

	private const string CHARACTER_SET_LATIN = "Latin";

	private const string CHARACTER_SET_CYRILLIC = "Cyrillic";

	private const string CHARACTER_SET_CJK = "CJK";

	private const string CHARACTER_SET_INUKTITUT = "Inuktitut";

	private const int ENTRY_LIMIT = 5000;

	private const string OVERFLOW_FILENAME_FORMAT = "{0}_OverflowData_{1}.asset";

	private List<StringTableData> m_DataFiles;

	private List<Entry> m_AllEntries;

	private Dictionary<string, Entry> m_EntriesMap;

	private StringTableData m_CurrentDataFile;

	private const int INVALID_LANGUAGE = -1;

	public const string NOTES_LANGUAGE = "NOTES";

	private List<string> m_Languages;

	private bool m_IsGeneratedByCode;

	private List<StringTableData> m_OverflowDataFiles;

	private string m_OverflowDataFolder;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CalledBy(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "IsUsingLegacyCyrillicOverride")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllLanguagesWithCharacterSet")]
	public CharacterSet GetCharacterSetForLanguage(string language)
	{
		return default(CharacterSet);
	}

	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(StringTable), Member = "AddNewLanguage")]
	[CalledBy(Type = typeof(StringTable), Member = "ParseLanguages")]
	[CalledBy(Type = typeof(StringTable), Member = "RemoveEntryForKey")]
	[CalledBy(Type = typeof(StringTable), Member = "GetKeyForEntry")]
	[CalledBy(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[CalledBy(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(StringTable), Member = "GetNumEntries")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(StringTable), Member = "DoesKeyExist")]
	private void InitializeData(bool forceInit = false)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StringTable), Member = "GetKeyForEntry")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	public int GetNumEntries()
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CalledBy(Type = typeof(Localization), Member = "Exists")]
	[CalledBy(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[CallsUnknownMethods(Count = 1)]
	public bool DoesKeyExist(string key)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(StringTable), Member = "AddOrUpdateTableEntry")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(StringTable), Member = "DoesKeyExist")]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private Entry AddEntryForKey(string key)
	{
		return null;
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CalledBy(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[CalledBy(Type = typeof(StringTable), Member = "RemoveEntryForKey")]
	[CalledBy(Type = typeof(StringTable), Member = "AddOrUpdateTableEntry")]
	[CalledBy(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[CalledBy(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[CallsUnknownMethods(Count = 1)]
	private Entry GetEntryFromKey(string key)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(StringTable), Member = "GetNumEntries")]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string GetKeyForEntry(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[CallsUnknownMethods(Count = 9)]
	private void RemoveEntryForKey(string key)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool ShouldImportLanguage(string language, List<string> importLanguages)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Localization), Member = "LoadWorkshopLocalization")]
	[Calls(Type = typeof(StringTable), Member = "AddOrUpdateTableEntry")]
	[Calls(Type = typeof(ByteReader), Member = "ReadCSV")]
	[Calls(Type = typeof(ByteReader), Member = "ReadCSV")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(File), Member = "ReadAllText")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "ParseLanguages")]
	public List<string> ImportCsv(string path, List<string> filterLanguages)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[CallsUnknownMethods(Count = 17)]
	private int[] ParseLanguages(BetterList<string> languages, List<string> filterLanguages)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	private void AddOrUpdateTableEntry(string key, BetterList<string> importEntryLanguages, int[] languageIndexes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetGeneratedByCode()
	{
	}

	[CalledBy(Type = typeof(StringTable), Member = "IsUsingLegacyCyrillicOverride")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "GetForFallbackLanguage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	public string GetStringForKeyAndLanguage(string key, string language)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	public string GetStringForKeyAndLanguage(string key, int languageIndex)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CalledBy(Type = typeof(Localization), Member = "LoadStringTableForLanguage")]
	[CallsUnknownMethods(Count = 9)]
	public void AddNewLanguage(string language)
	{
	}

	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	[CallerCount(Count = 0)]
	public bool HasLanguage(string language)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Localization), Member = "LoadStringTableForLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[CalledBy(Type = typeof(StringTable), Member = "HasLanguage")]
	[CallsUnknownMethods(Count = 5)]
	public int IndexOfLanguage(string language)
	{
		return default(int);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public StringTable()
	{
	}
}
