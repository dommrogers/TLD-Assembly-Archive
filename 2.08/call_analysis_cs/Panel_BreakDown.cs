using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_BreakDown : Panel_AutoReferenced, IAccelerateTimeProvider
{
	public ButtonLegendContainer m_ButtonLegendContainer;

	public float m_SecondsToBreakDown;

	public UILabel m_BreakDownNameLabel;

	public UILabel m_ToolToUseLabel;

	public UILabel m_DurationLabel;

	public UILabel m_EstimatedCaloriesBurnedLabel;

	public UILabel m_CurrentCaloriesLabel;

	public UILabel m_CurrentCaloriesValLabel;

	public UITexture m_SelectedToolTexture;

	public UISprite m_ToolConditionSprite;

	public UILabel m_ToolConditionLabel;

	public GameObject m_PanelElements;

	public string m_NoToolSpriteName;

	public Color m_NoToolSpriteColor;

	public Vector3 m_NoToolSpriteSizeModifier;

	public HarvestRepairMaterial[] m_YieldObjects;

	public float m_YieldObjectCenteredX;

	public float m_YieldObjectSpacing;

	public GameObject m_BreakDownButton;

	public GameObject m_RequiresToolLabel;

	public BreakDown m_BreakDown;

	public GameObject m_ToolSelectObject;

	public GameObject m_ToolSelectButtons;

	public string m_IconAccelerateTime;

	private PanelReference<Panel_HUD> m_HUD;

	private float m_DurationHours;

	private int m_SelectedToolItemIndex;

	private List<GearItem> m_Tools;

	private bool m_IsBreakingDown;

	private float m_TimeSpentBreakingDown;

	private bool m_TimeIsAccelerated;

	private float m_StoredDayLengthScale;

	private int m_FramesInPanel;

	private uint m_BreakDownAudio;

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(TrustManager), Member = "MaybeHandleItemBreakdown")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "StopAudioAndRumbleEffects")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Enable")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "OnCancel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "StopAudioAndRumbleEffects")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "UpdateDurationLabel")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "UpdateCurrentCaloriesLabel")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "UpdateIcons")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "RefreshTools")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void Update()
	{
	}

	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "RefreshYield")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BreakDown), Member = "RefreshTools")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsTimeAccelerated()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsBreakingDown()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ExitInterface()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void OnNextTool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void OnPrevTool()
	{
	}

	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_BreakDown), Member = "StopAudioAndRumbleEffects")]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	public void OnBreakDown()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[Calls(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(TrustManager), Member = "MaybeHandleItemBreakdown")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_BreakDown), Member = "StopAudioAndRumbleEffects")]
	[CallerCount(Count = 0)]
	private void BreakDownFinished()
	{
	}

	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateDurationLabel()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateEstimatedCaloriesBurnedLabel()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateCurrentCaloriesLabel()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	private void UpdateToolLabel()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	private void UpdateIcons()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "DegradeToolUsed")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "UpdateIcons")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "UpdateToolLabel")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "UpdateToolLabel")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "UpdateDurationLabel")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "BreakDownFinished")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "UpdateIcons")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "UpdateDurationLabel")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	private GearItem GetSelectedTool()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[Calls(Type = typeof(Panel_BreakDown), Member = "ToolIsUsable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshTools()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void MakeDefaultSelections()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	private string GetSignedInt(int value)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	private string GetSignedPercentage(float value)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Enable")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "ShowItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(HarvestRepairMaterial), Member = "Hide")]
	private void RefreshYield()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "RefreshTools")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool ToolIsUsable(GameObject tool)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BreakDown), Member = "GetSelectedTool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CallsUnknownMethods(Count = 1)]
	private void DegradeToolUsed()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[CallsUnknownMethods(Count = 1)]
	private void StartAudioAndRumbleEffects()
	{
	}

	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "BreakDownFinished")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "StopEffect")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[CallerCount(Count = 4)]
	private void StopAudioAndRumbleEffects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAcceleratingTime()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetActionText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetSpriteName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UIPanel GetPanelToFade()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIWidget GetWidgetToFade()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Action GetCancelAction()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void StartAcceleratingTime()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void StopAcceleratingTime()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_BreakDown()
	{
	}
}
