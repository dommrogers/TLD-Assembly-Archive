using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.AddressableAssets;
using TLD.Events;
using TLD.Logging;
using TLD.Serialization;
using TLD.UserGeneratedContent;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Gear;

public class BlueprintManager : ScriptableObject
{
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public string gearName;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CFindBlueprintsForGear_003Eb__0(BlueprintData bp)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public string craftedResultName;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass30_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		internal bool _003CMarkBlueprintUnlocked_003Eb__0(BlueprintData bp)
		{
			return default(bool);
		}
	}

	private static readonly LogFilter s_LogFilter;

	private static BlueprintManager s_Instance;

	private List<BlueprintData> m_StaticBlueprints;

	private bool m_LoadAddressableBlueprints;

	private GameEvent m_UniumLoaded;

	private List<string> m_UnlockedBlueprints;

	private AsyncOperationHandle<IList<BlueprintData>> m_AddressableBlueprintOperation;

	private List<BlueprintData> m_UserBlueprints;

	private List<BlueprintData> m_AllBlueprints;

	public static BlueprintManager Instance
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public event Action<BlueprintData> BlueprintUnlocked
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Addressables), Member = "InitializeAsync")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 5)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(BlueprintManager), Member = "FindBlueprintsForGear")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BlueprintManager), Member = "MarkBlueprintUnlocked")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprints")]
	public void GetFilteredBlueprints(List<BlueprintData> blueprints, Predicate<BlueprintData> predicate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public static string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(BlueprintManager), Member = "ClearUnlockedBlueprints")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BlueprintManager), Member = "MarkBlueprintUnlocked")]
	public static void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Action_UnlockBlueprint), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_blueprint_unlock")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[Calls(Type = typeof(BlueprintManager), Member = "GetFilteredBlueprints")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public static List<BlueprintData> FindBlueprintsForGear(string gearName)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CalledBy(Type = typeof(BlueprintManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	public void ClearUnlockedBlueprints()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsBlueprintUnlocked(string name, bool isStoryMode = false)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[CalledBy(Type = typeof(Action_UnlockBlueprint), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	public void UnlockSilent(BlueprintData bp)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_blueprint_unlock")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_UnlockBlueprint), Member = "OnExecute")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public void UnlockWithNotification(BlueprintData bp)
	{
	}

	[Calls(Type = typeof(BlueprintManager), Member = "LoadUserBlueprint")]
	[Calls(Type = typeof(File), Member = "ReadAllText")]
	[Calls(Type = typeof(Directory), Member = "GetFiles")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Workshop), Member = "GetContentRootPath")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlueprintManager), Member = "RemoveUserBlueprints")]
	public void LoadAllUserBlueprints()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserBlueprintData), Member = "CreateFromJson")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BlueprintManager), Member = "LoadAllUserBlueprints")]
	[CallsUnknownMethods(Count = 4)]
	public bool LoadUserBlueprint(string jsonText)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BlueprintManager), Member = "LoadAllUserBlueprints")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void RemoveUserBlueprints()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private static bool PerformUserBlueprintSanityChecks(BlueprintData blueprint)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BlueprintManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BlueprintManager), Member = "GetFilteredBlueprints")]
	private void MarkBlueprintUnlocked(string craftedResultName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Addressables), Member = "InitializeAsync")]
	[CallsUnknownMethods(Count = 2)]
	private void LoadAddressableBlueprintsAsync()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(AssetHelper), Member = "FindAllAssetLocations")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnAddressablesInitialized(AsyncOperationHandle<IResourceLocator> obj)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnAddressableBlueprintLoaded(BlueprintData blueprint)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void MaybeRegisterUniumNodes()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void MaybeUnregisterUniumNodes()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public BlueprintManager()
	{
	}
}
