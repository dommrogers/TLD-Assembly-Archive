using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Stats;
using UnityEngine;

[Serializable]
public class DetailedStatsView : StatsView
{
	public GameObject m_GameObject;

	public ScrollList m_ScrollList;

	public GameObject m_ScrollBarObject;

	public UISprite m_Sprite_CurrentExperienceMode;

	public UILabel m_CurrentSandboxName;

	public int m_FooterEmptyColumnCount;

	private StatID[] m_StatsOrderToShow;

	private UISlider m_ScrollBar;

	private MonoBehaviour m_OwnerContext;

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(DetailedStatsView), Member = "Populate")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(DetailedStatsView), Member = "RefreshScrollBarPosition")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[CallsUnknownMethods(Count = 3)]
	public void Start(MonoBehaviour ownerContext, string currentSandboxName = null)
	{
	}

	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	private void Populate()
	{
	}

	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollDown")]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollUp")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	public void Update()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "ScrollUp")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "ScrollDown")]
	[CallsUnknownMethods(Count = 1)]
	public void RefreshScrollBarPosition()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsChange")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollBarPositionChanged()
	{
	}

	[CalledBy(Type = typeof(DetailedStatsView), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsUp")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DetailedStatsView), Member = "RefreshScrollBarPosition")]
	public void ScrollUp()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsDown")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Update")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DetailedStatsView), Member = "RefreshScrollBarPosition")]
	public void ScrollDown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsUnknownMethods(Count = 1)]
	public void OnResetAllTimeStats()
	{
	}

	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStats")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnResetAllTimeStats")]
	[Calls(Type = typeof(DetailedStatsView), Member = "Populate")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CallsDeduplicatedMethods(Count = 4)]
	public void OnResetAllTimeStatsConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	public DetailedStatsView()
	{
	}
}
