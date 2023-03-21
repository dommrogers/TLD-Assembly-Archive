using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CraftingCategoryNavigation : MonoBehaviour
{
	public delegate void CategoryChangedDelegate(int category);

	public CategoryChangedDelegate m_OnCategoryChanged;

	public GameObject m_NavigationArrowPrompt;

	public List<UIButton> m_NavigationButtons;

	public List<GameObject> m_NotificationFlags;

	public UISprite m_SelectedHighlight;

	private List<CategoryButton> m_CategoryButtons;

	private int m_CurrentIndex;

	private bool m_Selected;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	public void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void OnNavigationChanged(UIButton button)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[CallerCount(Count = 0)]
	public void OnNavigateDown()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	public void OnNavigateUp()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetSelected(bool selected)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "OnNavigateUp")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "OnNavigateDown")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "Initialize")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void SetCurrentIndex(int index)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public CraftingCategoryNavigation()
	{
	}
}
