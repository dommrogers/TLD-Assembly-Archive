using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.AddressableAssets;
using TLD.Events;
using TLD.Logging;
using TLD.Serialization;
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

		[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CFindBlueprintsForGear_003Eb__0(BlueprintData bp)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public string craftedResultName;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass30_0()
		{
		}

		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 2)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Addressables), Member = "InitializeAsync")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 5)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BlueprintManager), Member = "MarkBlueprintUnlocked")]
	[CalledBy(Type = typeof(BlueprintManager), Member = "FindBlueprintsForGear")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprints")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
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

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BlueprintManager), Member = "ClearUnlockedBlueprints")]
	[Calls(Type = typeof(BlueprintManager), Member = "MarkBlueprintUnlocked")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Action_UnlockBlueprint), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_blueprint_unlock")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BlueprintManager), Member = "GetFilteredBlueprints")]
	public static List<BlueprintData> FindBlueprintsForGear(string gearName)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CalledBy(Type = typeof(BlueprintManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	public void ClearUnlockedBlueprints()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsBlueprintUnlocked(string name, bool isStoryMode = false)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_UnlockBlueprint), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void UnlockSilent(BlueprintData bp)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_blueprint_unlock")]
	[CalledBy(Type = typeof(Action_UnlockBlueprint), Member = "OnExecute")]
	public void UnlockWithNotification(BlueprintData bp)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void LoadAllUserBlueprints()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UserBlueprintData), Member = "CreateFromJson")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public bool LoadUserBlueprint(string jsonText)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(BlueprintManager), Member = "Deserialize")]
	[Calls(Type = typeof(BlueprintManager), Member = "GetFilteredBlueprints")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void MarkBlueprintUnlocked(string craftedResultName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Addressables), Member = "InitializeAsync")]
	[CallsUnknownMethods(Count = 7)]
	private void LoadAddressableBlueprintsAsync()
	{
	}

	[Calls(Type = typeof(AssetHelper), Member = "FindAllAssetLocations")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnAddressablesInitialized(AsyncOperationHandle<IResourceLocator> obj)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public BlueprintManager()
	{
	}
}
