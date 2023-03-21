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

	[CalledBy(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsUsingLegacyCyrillicOverride(string language)
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public CharacterSet GetCharacterSetForLanguage(int languageIndex)
	{
		return default(CharacterSet);
	}

	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllLanguagesWithCharacterSet")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringTable), Member = "IsUsingLegacyCyrillicOverride")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	public CharacterSet GetCharacterSetForLanguage(string language)
	{
		return default(CharacterSet);
	}

	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[CalledBy(Type = typeof(StringTable), Member = "GetNumEntries")]
	[CalledBy(Type = typeof(StringTable), Member = "DoesKeyExist")]
	[CalledBy(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[CalledBy(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[CalledBy(Type = typeof(StringTable), Member = "GetKeyForEntry")]
	[CalledBy(Type = typeof(StringTable), Member = "RemoveEntryForKey")]
	[CalledBy(Type = typeof(StringTable), Member = "ParseLanguages")]
	[CalledBy(Type = typeof(StringTable), Member = "AddNewLanguage")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 34)]
	private void InitializeData(bool forceInit = false)
	{
	}

	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[CalledBy(Type = typeof(StringTable), Member = "GetKeyForEntry")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumEntries()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Localization), Member = "Exists")]
	[CalledBy(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool DoesKeyExist(string key)
	{
		return false;
	}

	[CalledBy(Type = typeof(StringTable), Member = "AddOrUpdateTableEntry")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(StringTable), Member = "DoesKeyExist")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 26)]
	private Entry AddEntryForKey(string key)
	{
		return null;
	}

	[CalledBy(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[CalledBy(Type = typeof(StringTable), Member = "RemoveEntryForKey")]
	[CalledBy(Type = typeof(StringTable), Member = "AddOrUpdateTableEntry")]
	[CalledBy(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[CalledBy(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Entry GetEntryFromKey(string key)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(StringTable), Member = "GetNumEntries")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string GetKeyForEntry(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void RemoveEntryForKey(string key)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldImportLanguage(string language, List<string> importLanguages)
	{
		return false;
	}

	[CalledBy(Type = typeof(Localization), Member = "LoadWorkshopLocalization")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(File), Member = "ReadAllText")]
	[Calls(Type = typeof(ByteReader), Member = "ReadCSV")]
	[Calls(Type = typeof(BetterList<>), Member = "RemoveAt")]
	[Calls(Type = typeof(StringTable), Member = "ParseLanguages")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(StringTable), Member = "AddOrUpdateTableEntry")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	public List<string> ImportCsv(string path, List<string> filterLanguages)
	{
		return null;
	}

	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	private int[] ParseLanguages(BetterList<string> languages, List<string> filterLanguages)
	{
		return null;
	}

	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[Calls(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
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
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsGeneratedByCode()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetGeneratedByCode()
	{
	}

	[CalledBy(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Localization), Member = "GetForFallbackLanguage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[CalledBy(Type = typeof(StringTable), Member = "IsUsingLegacyCyrillicOverride")]
	[CalledBy(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public string GetStringForKeyAndLanguage(string key, string language)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetStringForKeyAndLanguage(string key, int languageIndex)
	{
		return null;
	}

	[CalledBy(Type = typeof(Localization), Member = "LoadStringTableForLanguage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void AddNewLanguage(string language)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringTable), Member = "IndexOfLanguage")]
	public bool HasLanguage(string language)
	{
		return false;
	}

	[CalledBy(Type = typeof(Localization), Member = "LoadStringTableForLanguage")]
	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[CalledBy(Type = typeof(StringTable), Member = "HasLanguage")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public int IndexOfLanguage(string language)
	{
		return 0;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public StringTable()
	{
	}
}
