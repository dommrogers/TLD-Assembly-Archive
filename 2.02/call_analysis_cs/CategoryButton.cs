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
	[CallerCount(Count = 101)]
	public CategoryButton(UIButton button)
	{
	}

	[Calls(Type = typeof(CategoryButton), Member = "SetButtonColors")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 6)]
	public void SetButtonState(ButtonState state, bool instant = true)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(CategoryButton), Member = "SetButtonState")]
	private void SetButtonColors(Color defaultColor, Color hoverColor, Color disabledColor, bool instant)
	{
	}
}
