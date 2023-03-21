using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using UnityEngine;

public class Panel_TorchLight : Panel_AutoReferenced
{
	private const float MATCH_USE_COOLDOWN = 0.4f;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public float m_LightTorchDistanceXZ;

	public ScrollList m_ScrollList;

	public GameObject m_ButtonLeft;

	public GameObject m_ButtonRight;

	public TweenAlpha m_LabelTween;

	public UILabel m_UseLabel;

	public UILabel m_ToolNameLabel;

	public UIButton m_ButtonUseFireOnly;

	public GameObject m_AllButtonsObject;

	public GameObject m_FireOnlyObject;

	private List<GearItem> m_AvailableTools;

	private List<GearItemCoverflow> m_CoverflowItems;

	private GearItem m_WoodMatches;

	private GearItem m_CardboardMatches;

	private GearItem m_Flint;

	private GearItem m_Striker;

	private float m_LastUseTime;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_TorchLight), Member = "OnUseSelectedItem")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_TorchLight), Member = "RefreshVisuals")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	private void Update()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_TorchLight), Member = "StartTorchIgnite")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_TorchLight), Member = "OnUseFireStriker")]
	[Calls(Type = typeof(Panel_TorchLight), Member = "OnUseFlintAndSteel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnUseSelectedItem()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	public void NextTool()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void PrevTool()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	public void SelectToolByIndex(int index)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_TorchLight), Member = "StartTorchIgnite")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnUseMatches(GearItem matches, bool consumeResource)
	{
	}

	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseSelectedItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_TorchLight), Member = "StartTorchIgnite")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	private void OnUseFlintAndSteel(bool consumeResource)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseSelectedItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_TorchLight), Member = "StartTorchIgnite")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	private void OnUseFireStriker(bool consumeResource)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Inventory), Member = "GetBestMatches")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(Inventory), Member = "GetBestMatches")]
	private void SetupScrollList()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetSelected")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshVisuals()
	{
	}

	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseFireStriker")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseMatches")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseSelectedItem")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "IgniteDelayed")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseFlintAndSteel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void StartTorchIgnite(float delaySeconds, string igniteAudio, bool isFire)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public Panel_TorchLight()
	{
	}
}
