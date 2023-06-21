using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gear;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Cooking;

public struct CookableItem
{
	public enum Cookablility
	{
		Cookable = 0,
		SkillTooLow = 1,
		WrongPot = 2,
		MissingIngredients = 4,
		InternalError = 0x10000
	}

	public readonly GearItem m_GearItem;

	public readonly RecipeData m_Recipe;

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public CookableItem(GearItem cookable)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public CookableItem(RecipeData recipe)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookableItem), Member = "GetDisplayName")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static int CompareCookableByName(CookableItem x, CookableItem y)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookableItem), Member = "GetCookTimeInMinutes")]
	[CallsUnknownMethods(Count = 2)]
	internal static int CompareByCookTime(CookableItem x, CookableItem y)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookableItem), Member = "GetCaloricContent")]
	[CallsUnknownMethods(Count = 2)]
	internal static int CompareByCaloricContent(CookableItem x, CookableItem y)
	{
		return 0;
	}

	[CalledBy(Type = typeof(CookableItem), Member = "CompareCookableByName")]
	[CalledBy(Type = typeof(CookableListItem), Member = "SetCookable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetDisplayName()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateCookableItem")]
	[CalledBy(Type = typeof(CookableItem), Member = "CompareByCookTime")]
	[CalledBy(Type = typeof(CookableItem), Member = "GetCookTimeInMinutes")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "GetCookTimeMinutesForCaloriesRemaining")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public float GetCookTimeInMinutes()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookableItem), Member = "GetCookTimeInMinutes")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalCookMultiplier")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetCookTimeInMinutes(CookingPotItem pot)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CookableItem), Member = "CompareByCaloricContent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CookableItem), Member = "GetFinalFoodItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetCaloricContent()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CookableListItem), Member = "SetCookable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Texture2D GetInventoryIcon()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CalledBy(Type = typeof(CookableListItem), Member = "CanCookItem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookableItem), Member = "GetCookableItemCookability")]
	[Calls(Type = typeof(CookableItem), Member = "GetRecipeCookability")]
	public bool CanCookItem(CookingPotItem cookingPot, Inventory inventory)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateRecipeWarning")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookableItem), Member = "GetCookableItemCookability")]
	[Calls(Type = typeof(CookableItem), Member = "GetRecipeCookability")]
	public Cookablility GetCookability(CookingPotItem cookingPot, Inventory inventory)
	{
		return default(Cookablility);
	}

	[CalledBy(Type = typeof(CookingToolPanelFilterButton), Member = "PassesFilter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookableItem), Member = "GetCookableItemPotCookability")]
	[Calls(Type = typeof(CookableItem), Member = "GetRecipePotCookability")]
	public Cookablility GetPotCookability(CookingPotItem cookingPot)
	{
		return default(Cookablility);
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(CookableItem), Member = "CanCookItem")]
	[CalledBy(Type = typeof(CookableItem), Member = "GetCookability")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookableItem), Member = "GetCookableItemPotCookability")]
	[Calls(Type = typeof(CookableItem), Member = "HasRequiredWater")]
	[CallsUnknownMethods(Count = 1)]
	private Cookablility GetCookableItemCookability(CookingPotItem cookingPot, Inventory inventory)
	{
		return default(Cookablility);
	}

	[CalledBy(Type = typeof(CookableItem), Member = "GetPotCookability")]
	[CalledBy(Type = typeof(CookableItem), Member = "GetCookableItemCookability")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "CanCookItem")]
	[CallsUnknownMethods(Count = 1)]
	private Cookablility GetCookableItemPotCookability(CookingPotItem cookingPot)
	{
		return default(Cookablility);
	}

	[CalledBy(Type = typeof(CookableItem), Member = "GetCookableItemCookability")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private static bool HasRequiredWater(Inventory inventory, Cookable cookable)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(CookableItem), Member = "CanCookItem")]
	[CalledBy(Type = typeof(CookableItem), Member = "GetCookability")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookableItem), Member = "GetRecipePotCookability")]
	[Calls(Type = typeof(RecipeData), Member = "CanBeMadeWithPot")]
	[Calls(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[Calls(Type = typeof(BlueprintData), Member = "HasRequiredTool")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private Cookablility GetRecipeCookability(CookingPotItem cookingPot, Inventory inventory)
	{
		return default(Cookablility);
	}

	[CalledBy(Type = typeof(CookableItem), Member = "GetPotCookability")]
	[CalledBy(Type = typeof(CookableItem), Member = "GetRecipeCookability")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RecipeData), Member = "CanBeMadeWithPot")]
	[CallsUnknownMethods(Count = 1)]
	private Cookablility GetRecipePotCookability(CookingPotItem cookingPot)
	{
		return default(Cookablility);
	}

	[CalledBy(Type = typeof(CookableItem), Member = "GetCaloricContent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private FoodItem GetFinalFoodItem()
	{
		return null;
	}
}
