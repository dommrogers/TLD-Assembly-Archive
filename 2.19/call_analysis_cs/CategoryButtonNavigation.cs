using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CategoryButtonNavigation : MonoBehaviour
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Initialize()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CategoryButtonNavigation), Member = "SetCurrentIndex")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void Initialize(List<UIButton> navigationButtons)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CategoryButtonNavigation), Member = "SetCurrentIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnNavigationChanged(UIButton button)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CategoryButtonNavigation), Member = "SetCurrentIndex")]
	[CallsUnknownMethods(Count = 1)]
	public void OnNavigateDown()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CategoryButtonNavigation), Member = "SetCurrentIndex")]
	[CallsUnknownMethods(Count = 1)]
	public void OnNavigateUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "SetNavigationArea")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void SetSelected(bool selected)
	{
	}

	[CalledBy(Type = typeof(CategoryButtonNavigation), Member = "Initialize")]
	[CalledBy(Type = typeof(CategoryButtonNavigation), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(CategoryButtonNavigation), Member = "OnNavigateDown")]
	[CalledBy(Type = typeof(CategoryButtonNavigation), Member = "OnNavigateUp")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "SetFilterBasedOnCookingPot")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void SetCurrentIndex(int index, bool forceUpdate = false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public CategoryButtonNavigation()
	{
	}
}
