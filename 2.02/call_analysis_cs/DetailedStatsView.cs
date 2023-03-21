using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class DetailedStatsView
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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[Calls(Type = typeof(DetailedStatsView), Member = "RefreshScrollBarPosition")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DetailedStatsView), Member = "Populate")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void Start(MonoBehaviour ownerContext)
	{
	}

	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	public void Populate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollUp")]
	[Calls(Type = typeof(DetailedStatsView), Member = "ScrollDown")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "ScrollDown")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "ScrollUp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	public void RefreshScrollBarPosition()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsChange")]
	public void OnScrollBarPositionChanged()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsUp")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Update")]
	[Calls(Type = typeof(DetailedStatsView), Member = "RefreshScrollBarPosition")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ScrollUp()
	{
	}

	[CalledBy(Type = typeof(DetailedStatsView), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnScrollbarStatsDown")]
	[Calls(Type = typeof(DetailedStatsView), Member = "RefreshScrollBarPosition")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	public void ScrollDown()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnResetAllTimeStats")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnResetAllTimeStats()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(DetailedStatsView), Member = "Populate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(StatContainer), Member = "Reset")]
	[Calls(Type = typeof(StatContainer), Member = "Reset")]
	[Calls(Type = typeof(StatContainer), Member = "Reset")]
	[Calls(Type = typeof(StatContainer), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnResetAllTimeStatsConfirmed()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	public DetailedStatsView()
	{
	}
}
