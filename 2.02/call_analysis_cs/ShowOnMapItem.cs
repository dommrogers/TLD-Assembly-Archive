using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ShowOnMapItem : MonoBehaviour
{
	public string m_MapLocID;

	public string m_MapIconSpriteName;

	public bool m_BigIconOnMap;

	[CalledBy(Type = typeof(CarryableBody), Member = "Dropped")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AddToMap(Vector3 worldPosition)
	{
	}

	[CalledBy(Type = typeof(CarryableBody), Member = "OnPickedUp")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveFromMap(Vector3 worldPosition)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ShowOnMapItem()
	{
	}
}
