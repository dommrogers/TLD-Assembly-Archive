using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DishEffectInfo : MonoBehaviour
{
	private DishEffectInfoUI m_DishEffectInfoUI;

	private List<DishEffectInfoIcon> m_DishEffectIcons;

	private UIGrid m_DishEffectGrid;

	private List<IFoodEffect> m_FoodEffectCache;

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateCookableItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(DishEffectInfoIcon), Member = "ShowDishEffect")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	public bool ShowDishBenefits(GameObject dish)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DishEffectInfo()
	{
	}
}
