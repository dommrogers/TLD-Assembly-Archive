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

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GenericClothingSlotSpawner), Member = "AssignValuesToSpawnedObject")]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(GenericClothingSlotSpawner), Member = "Awake")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GenericClothingSlotSpawner), Member = "InstantiateObjectIfNoneExists")]
	[Calls(Type = typeof(ClothingSlot), Member = "DoSetup")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GenericClothingSlotSpawner), Member = "AssignValuesToSpawnedObject")]
	public void InstantiateObjectIfNoneExists()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GenericClothingSlotSpawner()
	{
	}
}
