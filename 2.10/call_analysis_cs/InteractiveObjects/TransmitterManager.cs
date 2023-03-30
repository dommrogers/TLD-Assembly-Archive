using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Conditions;
using TLD.AddressableAssets;
using TLD.Serialization;
using TLD.Transmitters.UI;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace InteractiveObjects;

public class TransmitterManager : MonoBehaviour
{
	private AssetLabelReference m_TransmitterAssetLabel;

	private static TransmitterManager _003CInstance_003Ek__BackingField;

	private readonly List<TransmitterData> m_TransmitterList;

	private readonly Dictionary<string, TransmitterRuntimeState> m_TransmitterSaveData;

	public static bool s_ShowDebug;

	public static TransmitterManager Instance
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

	public List<TransmitterData> AllTransmitters
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAssets")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(TransmitterRuntimeState), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(TransmitterRuntimeState), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(TransmitterRuntimeState), Member = "GetRepairableStateForGuid")]
	[Calls(Type = typeof(TransmitterManager), Member = "GetTransmitterDataByGuid")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(Transmitter), Member = "UpdateRuntimeState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	public static string GetDebugText()
	{
		return null;
	}

	[CalledBy(Type = typeof(TrackableItem), Member = "IsUnlocked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CountDiscoveredTransmitters")]
	[CalledBy(Type = typeof(Condition_TransmitterCheckBase), Member = "get_info")]
	[CalledBy(Type = typeof(Condition_TransmitterCheckBase), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_TransmitterCheckBase), Member = "GetState")]
	[CalledBy(Type = typeof(FakeTrackableItem), Member = "IsUnlocked")]
	[CalledBy(Type = typeof(Transmitter), Member = "UpdateRuntimeState")]
	[CalledBy(Type = typeof(TransmitterSiteListItem), Member = "SetTransmitter")]
	[CalledBy(Type = typeof(TransmitterSiteListItem), Member = "Compare")]
	[CalledBy(Type = typeof(TransmitterSiteMapItem), Member = "SetTransmitter")]
	[CalledBy(Type = typeof(TransmitterSiteUIController), Member = "SortListItems")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	public TransmitterRuntimeState GetTransmitterState(TransmitterData transmitterData)
	{
		return null;
	}

	[CalledBy(Type = typeof(TransmitterManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	private TransmitterData GetTransmitterDataByGuid(string transmitterId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public TransmitterManager()
	{
	}
}
