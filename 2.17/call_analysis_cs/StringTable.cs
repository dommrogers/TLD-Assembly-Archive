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
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	public CharacterSet GetCharacterSetForLanguage(string language)
	{
		return default(CharacterSet);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 25)]
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
	[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
	[CalledBy(Type = typeof(Localization), Member = "GetForFallbackLanguage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(StringTable), Member = "IsUsingLegacyCyrillicOverride")]
	[CalledBy(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
	[CalledBy(Type = typeof(SteamRichPresenceProvider), Member = "ChangePresence")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string GetStringForKeyAndLanguage(string key, string language)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetStringForKeyAndLanguage(string key, int languageIndex)
	{
		return null;
	}

	[CalledBy(Type = typeof(Localization), Member = "LoadStringTableForLanguage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
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
	[CalledBy(Type = typeof(Localization), Member = "GetForLang")]
	[CalledBy(Type = typeof(StringTable), Member = "HasLanguage")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int IndexOfLanguage(string language)
	{
		return 0;
	}

	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[CalledBy(Type = typeof(StringTable), Member = "AddNewLanguage")]
	[CalledBy(Type = typeof(StringTable), Member = "GetNumEntries")]
	[CalledBy(Type = typeof(StringTable), Member = "DoesKeyExist")]
	[CalledBy(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[CalledBy(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[CalledBy(Type = typeof(StringTable), Member = "GetKeyForEntry")]
	[CalledBy(Type = typeof(StringTable), Member = "RemoveEntryForKey")]
	[CalledBy(Type = typeof(StringTable), Member = "ParseLanguages")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	private void InitializeData(bool forceInit = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumEntries()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Localization), Member = "Exists")]
	[CalledBy(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool DoesKeyExist(string key)
	{
		return false;
	}

	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[CalledBy(Type = typeof(StringTable), Member = "AddOrUpdateTableEntry")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(StringTable), Member = "DoesKeyExist")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private Entry AddEntryForKey(string key)
	{
		return null;
	}

	[CalledBy(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[CalledBy(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[CalledBy(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[CalledBy(Type = typeof(StringTable), Member = "RemoveEntryForKey")]
	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[CalledBy(Type = typeof(StringTable), Member = "AddOrUpdateTableEntry")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	private Entry GetEntryFromKey(string key)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void RemoveEntryForKey(string key)
	{
	}

	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[Calls(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public List<string> ImportCsv(string path, List<string> filterLanguages)
	{
		return null;
	}

	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private int[] ParseLanguages(BetterList<string> languages, List<string> filterLanguages)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringTable), Member = "GetEntryFromKey")]
	[Calls(Type = typeof(StringTable), Member = "AddEntryForKey")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void AddOrUpdateTableEntry(string key, BetterList<string> importEntryLanguages, int[] languageIndexes)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public StringTable()
	{
	}
}
