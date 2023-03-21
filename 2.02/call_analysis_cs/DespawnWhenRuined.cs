using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DespawnWhenRuined : MonoBehaviour
{
	public bool m_AllowDespawnOnCamera;

	public bool m_AllowDespawnInInventory;

	public float m_MinDistanceToDespawnWhenDestroyed;

	private GearItem m_GearItem;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[Calls(Type = typeof(DespawnWhenRuined), Member = "MaybeDespawnWhenRuined")]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(DespawnWhenRuined), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	private void MaybeDespawnWhenRuined(bool ignorePosition)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DespawnWhenRuined()
	{
	}
}
