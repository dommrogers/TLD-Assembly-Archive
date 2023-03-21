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
	[CallerCount(Count = 103)]
	public CategoryButton(UIButton button)
	{
	}

	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonColors")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetButtonState(ButtonState state, bool instant = true)
	{
	}

	[CalledBy(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void SetButtonColors(Color defaultColor, Color hoverColor, Color disabledColor, bool instant)
	{
	}
}
