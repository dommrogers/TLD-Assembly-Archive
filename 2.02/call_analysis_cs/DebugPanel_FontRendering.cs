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
		[CallerCount(Count = 7)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetTestName")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(char), Member = "IsLetter")]
	[Calls(Type = typeof(char), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetUnicodeRangeInfoString")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersForFontTest")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 45)]
	private void PrepareFontTests()
	{
	}

	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private string GetTestName(FontTest fontTest)
	{
		return null;
	}

	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string GetUnicodeRangeInfoString(List<char> chars, int start, int end)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetHolsterPressed")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "SwitchFontRenderer")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnPrevPage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnNextPage()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "Update")]
	[CallerCount(Count = 1)]
	public void SwitchFontRenderer()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "Enable")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "Update")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "OnPrevPage")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "OnNextPage")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FontManager), Member = "ResetFontsForCharacterSet")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(TMP_Text), Member = "set_font")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	private void RenderFontTest(FontTest fontTest)
	{
	}

	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "PrepareFontTests")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetAllLanguagesWithCharacterSet")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersInLanguage")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 34)]
	private List<char> GetAllCharactersForFontTest(FontTest fontTest)
	{
		return null;
	}

	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersForFontTest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(StringTable), Member = "GetCharacterSetForLanguage")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private List<string> GetAllLanguagesWithCharacterSet(CharacterSet characterSet)
	{
		return null;
	}

	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "GetAllCharactersForFontTest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringTable), Member = "GetNumEntries")]
	[Calls(Type = typeof(StringTable), Member = "InitializeData")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(StringTable), Member = "GetStringForKeyAndLanguage")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 26)]
	private List<char> GetAllCharactersInLanguage(string lang)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public DebugPanel_FontRendering()
	{
	}
}
