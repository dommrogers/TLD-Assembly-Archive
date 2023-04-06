using System;
using System.Collections.Generic;
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

	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(DetailedStatsView), Member = "Populate")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(DetailedStatsView), Member = "RefreshScrollBarPosition")]
	[CallsUnknownMethods(Count = 3)]
	public void Start(MonoBehaviour ownerContext, string currentSandboxName = null)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[CallerCount(Count = 2)]
	private void Populate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollUp")]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollDown")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "ScrollUp")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "ScrollDown")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	public void RefreshScrollBarPosition()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsChange")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollBarPositionChanged()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsUp")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(DetailedStatsView), Member = "RefreshScrollBarPosition")]
	[CallsUnknownMethods(Count = 1)]
	public void ScrollUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsDown")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(DetailedStatsView), Member = "RefreshScrollBarPosition")]
	[CallsUnknownMethods(Count = 1)]
	public void ScrollDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnResetAllTimeStats()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnResetAllTimeStats")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStats")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(DetailedStatsView), Member = "Populate")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnResetAllTimeStatsConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	public DetailedStatsView()
	{
	}
}
