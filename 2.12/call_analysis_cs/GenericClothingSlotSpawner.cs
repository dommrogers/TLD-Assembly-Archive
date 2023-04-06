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
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(GenericClothingSlotSpawner), Member = "AssignValuesToSpawnedObject")]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(GenericClothingSlotSpawner), Member = "Awake")]
	[CalledBy(Type = typeof(GenericClothingSlotSpawner), Member = "InstantiateObjectIfNoneExists")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[Calls(Type = typeof(ClothingSlot), Member = "DoSetup")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public void AssignValuesToSpawnedObject()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
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
