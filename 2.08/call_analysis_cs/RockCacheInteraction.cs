using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.UI.Generics;

public class RockCacheInteraction : TimedHoldInteraction
{
	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	private RockCache m_RockCache;

	private Container m_Container;

	private List<ActionPickerItemData> m_ItemData;

	private ActionPickerItemData m_OpenActionData;

	private ActionPickerItemData m_LabelActionData;

	private ActionPickerItemData m_DismantleData;

	private ActionPickerItemData m_DismantleDisableData;

	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(RockCacheInteraction), Member = "GetHoverText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	public override void InitializeInteraction()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "PerformHold")]
	[Calls(Type = typeof(RockCacheInteraction), Member = "ShowActionPanel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[CallerCount(Count = 0)]
	public override bool PerformHold()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Container), Member = "ShowContainerContents")]
	[CallsUnknownMethods(Count = 1)]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "PerformHold")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	private void ShowActionPanel()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	private string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public RockCacheInteraction()
	{
	}
}
