using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_EpisodeContinue : Panel_Base
{
	public ButtonLegendContainer m_ButtonLegendContainer;

	public UILabel m_NameLabel;

	public UITexture m_Episode2Card;

	public UITexture m_Episode3Card;

	public UITexture m_Episode4Card;

	public UITexture m_Episode5Card;

	public GameObject m_MouseContinueEpisodeButton;

	public GameObject m_MouseQuitToMainMenuButton;

	private UILabel m_Label_ButtonContinueToEpisode;

	private UILabel m_Label_ButtonQuitToMainMenu;

	private bool m_WasContinuePressedWhenEnabled;

	private bool m_WasEscapePressedWhenEnabled;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_EpisodeContinue), Member = "GetContinueToEpisodeButtonText")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "Enable")]
	[Calls(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_EpisodeContinue), Member = "UpdateNextEpisodeCards")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_EpisodeContinue), Member = "GetEpisodeTitleText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_EpisodeContinue), Member = "GetContinueToEpisodeButtonText")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Panel_EpisodeContinue), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	public void OnClickContinueToNextEpisode()
	{
	}

	[Calls(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnClickQuitToMainMenu()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_EpisodeContinue), Member = "GetContinueToEpisodeButtonText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "Update")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "Update")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetEpisodeGenericNameLocId")]
	private string GetContinueToEpisodeButtonText()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "Update")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private string GetEpisodeTitleText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void UpdateNextEpisodeCards()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Panel_EpisodeContinue()
	{
	}
}
