using Cpp2ILInjected.CallAnalysis;
using TLD.Cooking;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine.Pool;

public class Panel_RecipeBook : Panel_AutoReferenced, IMiniTopNav
{
	private PanelReference<Panel_Cooking> m_Cooking;

	public MiniTopNav m_MiniTopNav;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(RecipeBook), Member = "GetAllUnlockedRecipes")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanShowMiniTopNav()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool OnMiniTopNavButtonClick(Panel_Base owner)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(MiniTopNav), Member = "Hide")]
	[Calls(Type = typeof(MiniTopNav), Member = "Show")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(MiniTopNav), Member = "Hide")]
	[CallsUnknownMethods(Count = 1)]
	public void DisableFromCooking()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MiniTopNav), Member = "Hide")]
	[Calls(Type = typeof(MiniTopNav), Member = "Show")]
	[CallsUnknownMethods(Count = 1)]
	public void EnableNavigationTabs(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Panel_RecipeBook()
	{
	}
}
