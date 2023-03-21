using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ShowOnMapItem : MonoBehaviour
{
	public string m_MapLocID;

	public string m_MapIconSpriteName;

	public bool m_BigIconOnMap;

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CarryableBody), Member = "Dropped")]
	public void AddToMap(Vector3 worldPosition)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(CarryableBody), Member = "OnPickedUp")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	public void RemoveFromMap(Vector3 worldPosition)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ShowOnMapItem()
	{
	}
}
