using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TMPro;
using UnityEngine;

public class DebugPanel_FontRendering : Panel_Base
{
	[Serializable]
	public class FontTest
	{
		public string m_TestName;

		public string m_UnicodeRangeInfo;

		public CharacterSet m_CharacterSet;

		public List<string> m_Languages;

		public string m_TestString;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public FontTest()
		{
		}
	}

	private const string IGNORE_RANGE_CHARACTERS = "ªº";

	private const int CHARACTERS_PER_LINE = 30;

	private const int LINES_PER_PAGE = 10;

	private const int CHARACTERS_PER_PAGE = 300;

	public StringTable m_LocalizationStringTable;

	public UILabel m_CharacterSetLabel;

	public UILabel m_FontLabel;

	public UILabel m_UnicodeRangeLabel;

	public UILabel m_FontRendering;

	public TMP_Text m_TMPFontRendering;

	public UILabel m_FontRendererInfo;

	public List<FontTest> m_FontTests;

	private List<FontTest> m_BakedFontTests;

	private int m_CurrentIndex;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetUnicodeRangeInfoString")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetTestName")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersForFontTest")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetUnicodeRangeInfoString")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetTestName")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[ContextMenu("Bake Font Tests")]
	private void PrepareFontTests()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	private string GetTestName(FontTest fontTest)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[CallsUnknownMethods(Count = 2)]
	private string GetUnicodeRangeInfoString(List<char> chars, int start, int end)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	[CallsUnknownMethods(Count = 2)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Update()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	public void OnPrevPage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnNextPage()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void SwitchFontRenderer()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "OnNextPage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "OnPrevPage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FontManager), Member = "ResetFontsForCharacterSet")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(TMP_Text), Member = "set_font")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void RenderFontTest(FontTest fontTest)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetAllLanguagesWithCharacterSet")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[CallsUnknownMethods(Count = 25)]
	private List<char> GetAllCharactersForFontTest(FontTest fontTest)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersForFontTest")]
	[Calls(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private List<string> GetAllLanguagesWithCharacterSet(CharacterSet characterSet)
	{
		return null;
	}

	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersForFontTest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CallsDeduplicatedMethods(Count = 2)]
	private List<char> GetAllCharactersInLanguage(string lang)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public DebugPanel_FontRendering()
	{
	}
}
