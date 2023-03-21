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
	[CallerCount(Count = 269)]
	public CategoryButton(UIButton button)
	{
	}

	[CalledBy(Type = typeof(CraftingCategoryNavigation), Member = "SetCurrentIndex")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableRockCacheStateFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMissionsStory")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromObjective")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNavigationButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonColors")]
	[CallsUnknownMethods(Count = 1)]
	public void SetButtonState(ButtonState state, bool instant = true)
	{
	}

	[CalledBy(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void SetButtonColors(Color defaultColor, Color hoverColor, Color disabledColor, bool instant)
	{
	}
}
