using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DespawnWhenRuined : MonoBehaviour
{
	public bool m_AllowDespawnOnCamera;

	public bool m_AllowDespawnInInventory;

	public float m_MinDistanceToDespawnWhenDestroyed;

	private GearItem m_GearItem;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Start()
	{
	}

	[Calls(Type = typeof(DespawnWhenRuined), Member = "MaybeDespawnWhenRuined")]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(DespawnWhenRuined), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void MaybeDespawnWhenRuined(bool ignorePosition)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DespawnWhenRuined()
	{
	}
}
