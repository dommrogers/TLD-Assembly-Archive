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
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(FontManager), Member = "ResetFontsForCharacterSet")]
	[Calls(Type = typeof(UIFont), Member = "set_replacement")]
	[CallerCount(Count = 2)]
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
	[CallerCount(Count = 0)]
	public void ResetCurrentFonts()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CalledBy(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearAtlasTextures")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetTables")]
	[CallerCount(Count = 3)]
	public void ResetFontsForCharacterSet(CharacterSet characterSet)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetTables")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearAtlasTextures")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition")]
	private void ResetTMPFont(TMP_FontAsset font)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FontManager()
	{
	}
}
