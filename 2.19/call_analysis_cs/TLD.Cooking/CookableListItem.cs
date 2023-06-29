using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Cooking;

public class CookableListItem : MonoBehaviour
{
	private static readonly string[] s_SkillLevelLabelText;

	private UIWidget m_Root;

	private UITexture m_ItemIcon;

	private UITexture m_SpecialIcon;

	private UILabel m_ItemName;

	private UILabel m_SkillLevelNumber;

	private UISprite m_Background;

	private UISprite m_AvailableIcon;

	private UISprite m_UnavailableIcon;

	private UIButton m_Button;

	private Color m_Disabled;

	private Color m_Normal;

	private Color m_Selected;

	private CookableItem m_Cookable;

	private CookingPotItem m_CookingPot;

	private bool _003CIsSelected_003Ek__BackingField;

	public bool IsSelected
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void OnButtonClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "SetSelectedFoodIndex")]
	[CalledBy(Type = typeof(CookableListItem), Member = "SetCookable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookableListItem), Member = "CanCookItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSelected(bool selected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CookableItem GetCookableItem()
	{
		return default(CookableItem);
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookableItem), Member = "GetInventoryIcon")]
	[Calls(Type = typeof(CookableItem), Member = "GetDisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(CookableListItem), Member = "CanCookItem")]
	[Calls(Type = typeof(CookableListItem), Member = "SetAvailability")]
	[Calls(Type = typeof(CookableListItem), Member = "SetSelected")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	public void SetCookable(CookableItem cookable, CookingPotItem cookingPot)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void SetCookingPot(CookingPotItem cookingPot)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateCookingPotOnFoodItems")]
	[CalledBy(Type = typeof(CookableListItem), Member = "SetCookable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetAvailability(bool canCook)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateCookingPotOnFoodItems")]
	[CalledBy(Type = typeof(CookableListItem), Member = "SetSelected")]
	[CalledBy(Type = typeof(CookableListItem), Member = "SetCookable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CookableItem), Member = "CanCookItem")]
	private bool CanCookItem()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CookableListItem()
	{
	}
}
