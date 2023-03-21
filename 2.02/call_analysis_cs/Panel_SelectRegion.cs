using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_SelectRegion : Panel_Base
{
	public UIButton m_SelectButtonRandomRegion;

	public ScrollList m_RegionScrollList;

	public List<GameObject> m_RegionScrollListItems;

	public GameRegion[] m_RegionOrder;

	public GameObject[] m_RegionDescriptionsUnlocked;

	public GameObject[] m_RegionSelectButtons;

	public GameObject m_RegionSelect_NextButton;

	public GameObject m_RegionSelect_PreviousButton;

	public ButtonLegendContainer m_ButtonLegendContainer;

	[Calls(Type = typeof(ScrollList), Member = "CreateFromList")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_SelectRegion), Member = "ProcessMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_SelectRegion), Member = "SelectRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	public void OnClickBack()
	{
	}

	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(Panel_SelectRegion), Member = "SelectRegion")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnSelectRegionPrevious()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_SelectRegion), Member = "SelectRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallerCount(Count = 0)]
	public void OnSelectRegionNext()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	public void OnSelectRegionContinue()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(Panel_SelectRegion), Member = "SelectRegion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	public void OnSelectRegionByReference(GameObject obj)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion), Member = "Update")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	private void ProcessMenu()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion), Member = "OnSelectRegionPrevious")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Panel_SelectRegion), Member = "OnSelectRegionByReference")]
	[CalledBy(Type = typeof(Panel_SelectRegion), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectRegion), Member = "OnSelectRegionNext")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	public void SelectRegion(int index, bool animate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public Panel_SelectRegion()
	{
	}
}
