using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Cooking;

public class RecipeBook : MonoBehaviour
{
	private const string ERROR_MULTIPLE_INSTANCES = "Multiple RecipeBook instances detected!";

	private AssetLabelReference m_RecipeLabel;

	private readonly RecipeBookGameState m_GameState;

	private AsyncOperationHandle<IList<RecipeData>> m_RecipeLoadOperation;

	private static RecipeBook _003CInstance_003Ek__BackingField;

	private List<RecipeData> _003CAllRecipes_003Ek__BackingField;

	public static RecipeBook Instance
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public List<RecipeData> AllRecipes
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 26)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetsAsync")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Status")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnRecipesLoaded(AsyncOperationHandle<IList<RecipeData>> obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_recipe_unlock")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_recipe_unlock_all")]
	[CalledBy(Type = typeof(RecipeItem), Member = "Unlock")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool UnlockRecipe(RecipeData recipe)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsRecipeUnlocked(RecipeData recipe)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsRecipeSpecial(RecipeData recipe)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsRecipeSpecialAndUnlocked(RecipeData recipe)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateCollectionSelectScreenDummyData")]
	[CalledBy(Type = typeof(RecipeBook), Member = "GetAllUnlockedRecipes")]
	[CalledBy(Type = typeof(RecipeBook), Member = "GetAllSpecialRecipes")]
	[CalledBy(Type = typeof(RecipeBook), Member = "GetAllSpecialAndUnlockedRecipes")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_IsDone")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void GetFilteredRecipes(Predicate<RecipeData> filter, List<RecipeData> result)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_IsDone")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[CallsUnknownMethods(Count = 1)]
	public bool HasAnyRecipes()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CalledBy(Type = typeof(Panel_RecipeBook), Member = "CanShowMiniTopNav")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RecipeBook), Member = "GetFilteredRecipes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void GetAllUnlockedRecipes(List<RecipeData> result)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RecipeBook), Member = "GetFilteredRecipes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void GetAllSpecialRecipes(List<RecipeData> result)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RecipeBook), Member = "GetFilteredRecipes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void GetAllSpecialAndUnlockedRecipes(List<RecipeData> result)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 25)]
	public RecipeBookGameState Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(RecipeBookGameState savedState)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public RecipeBook()
	{
	}
}
