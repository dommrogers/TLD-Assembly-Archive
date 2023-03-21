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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_EpisodeContinue), Member = "GetContinueToEpisodeButtonText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_EpisodeContinue), Member = "GetEpisodeTitleText")]
	[Calls(Type = typeof(Panel_EpisodeContinue), Member = "UpdateNextEpisodeCards")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(Panel_EpisodeContinue), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnClickContinueToNextEpisode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickQuitToMainMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_EpisodeContinue), Member = "GetContinueToEpisodeButtonText")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "Update")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetEpisodeGenericNameLocId")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string GetContinueToEpisodeButtonText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private string GetEpisodeTitleText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 16)]
	private void UpdateNextEpisodeCards()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Panel_EpisodeContinue()
	{
	}
}
