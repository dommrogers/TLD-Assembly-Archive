using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class Placeable : MonoBehaviour
{
	private const string SPAWNED_NAME_SUFFICE = "(PLACED)";

	[NonSerialized]
	public string m_Guid;

	private CarryableBody m_CarryableBody;

	public string m_PrefabName;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[Calls(Type = typeof(PlaceableManager), Member = "Add")]
	[CallsUnknownMethods(Count = 3)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(PlaceableManager), Member = "SerializeAll")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Placeable), Member = "FindOrCreateAndDeserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private void Deserialize(string guid, PlaceableSaveData data)
	{
	}

	[Calls(Type = typeof(PlaceableManager), Member = "Remove")]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Placeable), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlaceableManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(PlaceableManager), Member = "FindOrCreateCategoryRoot")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public static Placeable FindOrCreateAndDeserialize(string guid, string serialized)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Placeable()
	{
	}
}
