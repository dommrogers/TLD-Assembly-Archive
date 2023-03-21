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

	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnNavigationChanged(UIButton button)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnNavigateDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnNavigateUp()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetSelected(bool selected)
	{
	}

	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "Initialize")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "OnNavigateDown")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "OnNavigateUp")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleVerticalNavigation")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private void SetCurrentIndex(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public CraftingCategoryNavigation()
	{
	}
}
