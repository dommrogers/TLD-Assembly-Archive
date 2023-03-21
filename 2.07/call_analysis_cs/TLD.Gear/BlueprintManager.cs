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
			return false;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CMarkBlueprintUnlocked_003Eb__0(BlueprintData bp)
		{
			return false;
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
		[CallsUnknownMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(Addressables), Member = "InitializeAsync")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprints")]
	[CalledBy(Type = typeof(BlueprintManager), Member = "FindBlueprintsForGear")]
	[CalledBy(Type = typeof(BlueprintManager), Member = "MarkBlueprintUnlocked")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
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
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(BlueprintManager), Member = "MarkBlueprintUnlocked")]
	[Calls(Type = typeof(BlueprintManager), Member = "ClearUnlockedBlueprints")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_blueprint_unlock")]
	[CalledBy(Type = typeof(Action_UnlockBlueprint), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BlueprintManager), Member = "GetFilteredBlueprints")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static List<BlueprintData> FindBlueprintsForGear(string gearName)
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CalledBy(Type = typeof(BlueprintManager), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	public void ClearUnlockedBlueprints()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsBlueprintUnlocked(string name, bool isStoryMode = false)
	{
		return false;
	}

	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[CalledBy(Type = typeof(Action_UnlockBlueprint), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UnlockSilent(BlueprintData bp)
	{
	}

	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_blueprint_unlock")]
	[CalledBy(Type = typeof(Action_UnlockBlueprint), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void UnlockWithNotification(BlueprintData bp)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Workshop), Member = "GetContentRootPath")]
	[Calls(Type = typeof(BlueprintManager), Member = "RemoveUserBlueprints")]
	[Calls(Type = typeof(Directory), Member = "GetFiles")]
	[Calls(Type = typeof(File), Member = "ReadAllText")]
	[Calls(Type = typeof(BlueprintManager), Member = "LoadUserBlueprint")]
	[CallsUnknownMethods(Count = 2)]
	public void LoadAllUserBlueprints()
	{
	}

	[CalledBy(Type = typeof(BlueprintManager), Member = "LoadAllUserBlueprints")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserBlueprintData), Member = "CreateFromJson")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public bool LoadUserBlueprint(string jsonText)
	{
		return false;
	}

	[CalledBy(Type = typeof(BlueprintManager), Member = "LoadAllUserBlueprints")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void RemoveUserBlueprints()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private static bool PerformUserBlueprintSanityChecks(BlueprintData blueprint)
	{
		return false;
	}

	[CalledBy(Type = typeof(BlueprintManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BlueprintManager), Member = "GetFilteredBlueprints")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MarkBlueprintUnlocked(string craftedResultName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(Addressables), Member = "InitializeAsync")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[CallsUnknownMethods(Count = 1)]
	private void LoadAddressableBlueprintsAsync()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(AssetHelper), Member = "FindAllAssetLocations")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public BlueprintManager()
	{
	}
}
