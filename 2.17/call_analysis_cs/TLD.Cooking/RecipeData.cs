using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Cooking;

public class RecipeData : ScriptableObject
{
	public enum UnlockType
	{
		Unlocked,
		CodeUnlock
	}

	private LocalizedString m_RecipeName;

	private LocalizedString m_RecipeShortName;

	private LocalizedString m_RecipeDescription;

	private AssetReferenceTexture2D m_RecipeIcon;

	private UnlockType m_UnlockRule;

	private int m_RequiredSkillLevel;

	private GearItemData[] m_AllowedCookingPots;

	private BlueprintData m_DishBlueprint;

	public LocalizedString Name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	public LocalizedString ShortName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
	}

	public LocalizedString Description
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
	}

	public AssetReferenceTexture2D IconReference
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
	}

	public bool IsSpecial
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public UnlockType UnlockRule
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(UnlockType);
		}
	}

	public int RequiredSkillLevel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
	}

	public BlueprintData DishBlueprint
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public bool CanCauseAfflictions()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasCookingSkills()
	{
		return false;
	}

	[CalledBy(Type = typeof(CookableItem), Member = "GetRecipeCookability")]
	[CalledBy(Type = typeof(CookableItem), Member = "GetRecipePotCookability")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool CanBeMadeWithPot(CookingPotItem cookingPot)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public RecipeData()
	{
	}
}
