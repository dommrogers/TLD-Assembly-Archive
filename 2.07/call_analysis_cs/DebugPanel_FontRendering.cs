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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetTestName")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetUnicodeRangeInfoString")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetUnicodeRangeInfoString")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersForFontTest")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetTestName")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[ContextMenu("Bake Font Tests")]
	private void PrepareFontTests()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 2)]
	private string GetTestName(FontTest fontTest)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[CallsUnknownMethods(Count = 2)]
	private string GetUnicodeRangeInfoString(List<char> chars, int start, int end)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnPrevPage()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "OnNextPage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "OnPrevPage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "Enable")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(TMP_Text), Member = "set_font")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(FontManager), Member = "ResetFontsForCharacterSet")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void RenderFontTest(FontTest fontTest)
	{
	}

	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetAllLanguagesWithCharacterSet")]
	private List<char> GetAllCharactersForFontTest(FontTest fontTest)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersForFontTest")]
	[CallsUnknownMethods(Count = 5)]
	private List<string> GetAllLanguagesWithCharacterSet(CharacterSet characterSet)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersForFontTest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private List<char> GetAllCharactersInLanguage(string lang)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DebugPanel_FontRendering()
	{
	}
}
