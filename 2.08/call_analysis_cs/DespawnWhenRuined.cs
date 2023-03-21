using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DespawnWhenRuined : MonoBehaviour
{
	public bool m_AllowDespawnOnCamera;

	public bool m_AllowDespawnInInventory;

	public float m_MinDistanceToDespawnWhenDestroyed;

	private GearItem m_GearItem;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DespawnWhenRuined), Member = "MaybeDespawnWhenRuined")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(DespawnWhenRuined), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeDespawnWhenRuined(bool ignorePosition)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DespawnWhenRuined()
	{
	}
}
