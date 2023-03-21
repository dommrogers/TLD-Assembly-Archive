using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_BedRollSelect : Panel_AutoReferenced
{
	public ButtonLegendContainer m_ButtonLegendContainer;

	public UIButton m_ButtonUseBedRoll;

	public UIButton m_ButtonUseBearSkin;

	public Color m_GreyoutColor;

	private PanelReference<Panel_Actions> m_Actions;

	private List<UIButton> m_Buttons;

	private int m_SelectedButtonIndex;

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_BedRollSelect), Member = "UpdateNavigation")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_BedRollSelect), Member = "UpdateButtonState")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Panel_BedRollSelect), Member = "UpdateButtonState")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsUnknownMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	public void OnUseBedRoll()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	public void OnUseBearSkin()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "Enable")]
	private void UpdateButtonState()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void SetButtonColors(UIButton button, bool greyout)
	{
	}

	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	private void UpdateNavigation()
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_BedRollSelect()
	{
	}
}
