using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GenericClothingSlotSpawner : MonoBehaviour
{
	public GameObject m_Prefab;

	public string m_EmptySlotSpriteName;

	public ClothingRegion m_ClothingRegion;

	public ClothingLayer m_ClothingLayer;

	public int m_LayoutColumnIndex;

	public int m_LayoutRowIndex;

	public bool m_HasAltLayoutIndex;

	public int m_AltLayoutColumnIndex;

	public int m_AltLayoutRowIndex;

	public UITexture[] m_PaperDollSlots;

	public string m_LayerLocID;

	public GameObject m_SpawnedObject;

	public ClothingSlot m_ClothingSlot;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GenericClothingSlotSpawner), Member = "AssignValuesToSpawnedObject")]
	public void Awake()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(GenericClothingSlotSpawner), Member = "Awake")]
	[Calls(Type = typeof(ClothingSlot), Member = "DoSetup")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CalledBy(Type = typeof(GenericClothingSlotSpawner), Member = "InstantiateObjectIfNoneExists")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallerCount(Count = 2)]
	public void AssignValuesToSpawnedObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GenericClothingSlotSpawner), Member = "AssignValuesToSpawnedObject")]
	public void InstantiateObjectIfNoneExists()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public GenericClothingSlotSpawner()
	{
	}
}
