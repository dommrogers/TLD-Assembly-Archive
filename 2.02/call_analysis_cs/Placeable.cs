using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Placeable : MonoBehaviour
{
	private const string SPAWNED_NAME_SUFFICE = "(PLACED)";

	[NonSerialized]
	public string m_Guid;

	private CarryableBody m_CarryableBody;

	private InteractionOverride m_InteractionOverride;

	public string m_PrefabName;

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlaceableManager), Member = "Add")]
	[Calls(Type = typeof(ObjectGuid), Member = "Generate")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	public void Awake()
	{
	}

	[Calls(Type = typeof(InteractionOverride), Member = "Serialize")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(PlaceableManager), Member = "SerializeAll")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CarryableBody), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(ObjectGuidManager), Member = "UnRegisterGuid")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "RegisterGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CalledBy(Type = typeof(Placeable), Member = "FindOrCreateAndDeserialize")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void Deserialize(string guid, PlaceableSaveData data)
	{
	}

	[Calls(Type = typeof(PlaceableManager), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CalledBy(Type = typeof(PlaceableManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(Placeable), Member = "Deserialize")]
	[Calls(Type = typeof(PlaceableManager), Member = "FindOrCreateCategoryRoot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static Placeable FindOrCreateAndDeserialize(string guid, string serialized)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Placeable()
	{
	}
}
