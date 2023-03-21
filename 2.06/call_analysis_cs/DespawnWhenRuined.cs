using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DespawnWhenRuined : MonoBehaviour
{
	public bool m_AllowDespawnOnCamera;

	public bool m_AllowDespawnInInventory;

	public float m_MinDistanceToDespawnWhenDestroyed;

	private GearItem m_GearItem;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DespawnWhenRuined), Member = "MaybeDespawnWhenRuined")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DespawnWhenRuined), Member = "Update")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void MaybeDespawnWhenRuined(bool ignorePosition)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public DespawnWhenRuined()
	{
	}
}
