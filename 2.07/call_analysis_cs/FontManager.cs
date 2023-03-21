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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lang")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[Calls(Type = typeof(FontManager), Member = "ResetFontsForCharacterSet")]
	[Calls(Type = typeof(UIFont), Member = "set_replacement")]
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
	[CallerCount(Count = 0)]
	public void ResetCurrentFonts()
	{
	}

	[CalledBy(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetTables")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearAtlasTextures")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
	public void ResetFontsForCharacterSet(CharacterSet characterSet)
	{
	}

	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearAtlasTextures")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetTables")]
	[CallerCount(Count = 0)]
	private void ResetTMPFont(TMP_FontAsset font)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FontManager()
	{
	}
}
