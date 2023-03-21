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
		[CallerCount(Count = 2)]
		public FontTest()
		{
		}
	}

	private const string IGNORE_RANGE_CHARACTERS = "ª";

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

	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetUnicodeRangeInfoString")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetTestName")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersForFontTest")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetTestName")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetUnicodeRangeInfoString")]
	private void PrepareFontTests()
	{
	}

	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	private string GetTestName(FontTest fontTest)
	{
		return null;
	}

	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	private string GetUnicodeRangeInfoString(List<char> chars, int start, int end)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "SwitchFontRenderer")]
	[Calls(Type = typeof(InputManager), Member = "GetHolsterPressed")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnPrevPage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnNextPage()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "Update")]
	public void SwitchFontRenderer()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void OnCancel()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "OnPrevPage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "Update")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "Enable")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "OnNextPage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TMP_Text), Member = "set_font")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(FontManager), Member = "ResetFontsForCharacterSet")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 4)]
	private void RenderFontTest(FontTest fontTest)
	{
	}

	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetAllLanguagesWithCharacterSet")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	private List<char> GetAllCharactersForFontTest(FontTest fontTest)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersForFontTest")]
	[CallsUnknownMethods(Count = 12)]
	private List<string> GetAllLanguagesWithCharacterSet(CharacterSet characterSet)
	{
		return null;
	}

	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersForFontTest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "GetNumEntries")]
	[Calls(Type = typeof(StringTable), Member = "GetNumEntries")]
	[CallsDeduplicatedMethods(Count = 5)]
	private List<char> GetAllCharactersInLanguage(string lang)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public DebugPanel_FontRendering()
	{
	}
}
