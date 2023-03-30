using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.AddressableAssets;
using TLD.Scenes.ObjectReferences;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace InteractiveObjects;

public class TrackableItemsManager : MonoBehaviour
{
	private class ManagerSaveDataProxyGlobal
	{
		public Dictionary<string, TrackableItemSaveData> m_ListDataProxyGlobal;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public ManagerSaveDataProxyGlobal()
		{
		}
	}

	private sealed class _003CWaitForResearchSet_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TrackableItemsManager _003C_003E4__this;

		private IBlackboard _003Cbb_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CWaitForResearchSet_003Ed__18(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(TrackableItemsManager), Member = "FilterActiveItemsByResearchSet")]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private const string ResearchSetVariableName = "ResearchSet";

	private const int ExpectedCapacity = 100;

	private static TrackableItemsManager _003CInstance_003Ek__BackingField;

	private AssetLabelReference m_TrackableItemLabel;

	private readonly Dictionary<string, TrackableItemSaveData> m_SaveData;

	private readonly List<TrackableItemData> m_AllItems;

	private readonly List<TrackableItemData> m_ActiveItems;

	private readonly List<ITrackable> m_ItemReferences;

	private Variable<int> m_ResearchSetVariable;

	public static TrackableItemsManager Instance
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

	public static event Action OnDeserializeCompleted
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAssets")]
	[Calls(Type = typeof(SceneObjectReference), Member = "add_OnAvailable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TrackableItemsManager), Member = "AddAvailableItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForResearchSet_003Ed__18))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator WaitForResearchSet()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnResearchSetChanged(string variableName, object variableValue)
	{
	}

	[CalledBy(Type = typeof(_003CWaitForResearchSet_003Ed__18), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(TrackableItemData), Member = "IsActiveDueToResearchSet")]
	[CallsUnknownMethods(Count = 4)]
	private void FilterActiveItemsByResearchSet(string researchSet)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAssets")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TrackableItemsManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TrackableItemsManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public static void DeserializeAll(string json)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(TrackableItemsManager), Member = "SerializeAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(TrackableItemsManager), Member = "DeserializeAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(TrackableItem), Member = "GetRuntimeState")]
	[CalledBy(Type = typeof(FakeTrackableItem), Member = "GetRuntimeState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	public TrackableItemSaveData GetTrackableItemSavedData(TrackableItemData key)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateTrackableItemSavedData(TrackableItemData key, TrackableItemSaveData saveGameData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsInActiveList(TrackableItemData trackableItem)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 18)]
	public List<ITrackable> GetItemReferences()
	{
		return null;
	}

	[CalledBy(Type = typeof(TrackableItemsManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void AddAvailableItem(SceneObjectReference sender, GameObject owner)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public TrackableItemsManager()
	{
	}
}
