using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CategoryButton
{
	public enum ButtonState
	{
		Selected,
		NotSelected,
		NotSelectedAndEmpty
	}

	private UIButton m_Button;

	[DeduplicatedMethod]
	[CallerCount(Count = 279)]
	public CategoryButton(UIButton button)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNavigationButtons")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonColors")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetButtonState(ButtonState state, bool instant = true)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CalledBy(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[CallsUnknownMethods(Count = 1)]
	private void SetButtonColors(Color defaultColor, Color hoverColor, Color disabledColor, bool instant)
	{
	}
}
