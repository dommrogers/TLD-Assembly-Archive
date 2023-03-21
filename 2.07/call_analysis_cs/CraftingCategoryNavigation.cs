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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	public void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void OnNavigationChanged(UIButton button)
	{
	}

	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnNavigateDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[CallsUnknownMethods(Count = 1)]
	public void OnNavigateUp()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	public void SetSelected(bool selected)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "OnNavigateUp")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "OnNavigateDown")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "OnNavigationChanged")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "Initialize")]
	[CallsUnknownMethods(Count = 6)]
	private void SetCurrentIndex(int index)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public CraftingCategoryNavigation()
	{
	}
}
