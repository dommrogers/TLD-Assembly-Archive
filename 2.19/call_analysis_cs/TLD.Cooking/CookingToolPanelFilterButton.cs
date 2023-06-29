using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gear;
using UnityEngine;

namespace TLD.Cooking;

public class CookingToolPanelFilterButton : MonoBehaviour
{
	private List<AssetReferenceCookingPot> m_ValidTools;

	private LocalizedString m_FilterName;

	private List<CookingPotItem> m_CookingPotItems;

	private List<GearItemData> m_GearItemData;

	public string FilterName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Initialize")]
	[CalledBy(Type = typeof(CookingToolPanelFilterButton), Member = "PassesFilter")]
	[CalledBy(Type = typeof(CookingToolPanelFilterButton), Member = "IsValidFilter")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AssetReferenceWithComponent<>), Member = "GetOrLoadTypedAsset")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateFilterIndex")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public CookingPotItem GetCookingPotItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetCookingPotItemName()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "SetFilterBasedOnCookingPot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsGearItemInFilter(GearItemData gearItemData)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookingToolPanelFilterButton), Member = "Initialize")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CookableItem), Member = "GetPotCookability")]
	[CallsUnknownMethods(Count = 2)]
	public bool PassesFilter(CookableItem cookableItem)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingToolPanelFilterButton), Member = "Initialize")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsValidFilter()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CookingToolPanelFilterButton()
	{
	}
}
