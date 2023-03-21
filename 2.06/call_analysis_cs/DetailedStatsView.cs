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

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DetailedStatsView), Member = "Populate")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildStatsView")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(DetailedStatsView), Member = "RefreshScrollBarPosition")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void Start(MonoBehaviour ownerContext, string currentSandboxName = null)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "ScrollUp")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "ScrollDown")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void RefreshScrollBarPosition()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsChange")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollBarPositionChanged()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsUp")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DetailedStatsView), Member = "RefreshScrollBarPosition")]
	public void ScrollUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsDown")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Update")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DetailedStatsView), Member = "RefreshScrollBarPosition")]
	public void ScrollDown()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnResetAllTimeStats")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	public void OnResetAllTimeStats()
	{
	}

	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStats")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DetailedStatsView), Member = "Populate")]
	public void OnResetAllTimeStatsConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	public DetailedStatsView()
	{
	}
}
