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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallsUnknownMethods(Count = 12)]
	public void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "OnNavigationChanged")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "OnNavigateDown")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "Initialize")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "OnNavigateUp")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	private void SetCurrentIndex(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public CraftingCategoryNavigation()
	{
	}
}
