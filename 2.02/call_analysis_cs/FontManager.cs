using Cpp2ILInjected.CallAnalysis;
using TMPro;
using UnityEngine;

public class FontManager : MonoBehaviour
{
	public UIFont[] m_DummyUIFonts;

	public UIFont m_LatinUIFont;

	public UIFont m_CyrillicUIFont;

	public UIFont m_InuktitutUIFont;

	public UIFont m_DummyDialogueFont;

	public UIFont m_LatinDialogueFont;

	public UIFont m_CyrillicDialogueFont;

	public UIFont m_InuktitutDialogueFont;

	public TMP_FontAsset m_LatinTMPFont;

	public TMP_FontAsset m_CJKTMPFont;

	public TMP_FontAsset m_CyrillicTMPFont;

	public TMP_FontAsset m_InuktitutTMPFont;

	private static CharacterSet m_CurrentCharacterSet;

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lang")]
	[Calls(Type = typeof(UIFont), Member = "set_replacement")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(FontManager), Member = "ResetFontsForCharacterSet")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIFont), Member = "set_replacement")]
	public void UpdateDummyFonts()
	{
	}

	[CallerCount(Count = 0)]
	public UIFont GetUIFontForCharacterSet(CharacterSet characterSet)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public UIFont GetDialogueFontForCharacterSet(CharacterSet characterSet)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public TMP_FontAsset GetTMPFontForCharacterSet(CharacterSet characterSet)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	public void ResetCurrentFonts()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearAtlasTextures")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetTables")]
	public void ResetFontsForCharacterSet(CharacterSet characterSet)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearAtlasTextures")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetTables")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void ResetTMPFont(TMP_FontAsset font)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FontManager()
	{
	}
}
