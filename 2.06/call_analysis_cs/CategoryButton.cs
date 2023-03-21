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

	[CallerCount(Count = 265)]
	[DeduplicatedMethod]
	public CategoryButton(UIButton button)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNavigationButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableRockCacheStateFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonColors")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 14)]
	public void SetButtonState(ButtonState state, bool instant = true)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void SetButtonColors(Color defaultColor, Color hoverColor, Color disabledColor, bool instant)
	{
	}
}
