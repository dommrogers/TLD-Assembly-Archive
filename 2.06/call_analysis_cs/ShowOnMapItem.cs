using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class ShowOnMapItem : MonoBehaviour
{
	private PanelReference<Panel_Map> m_Map;

	public string m_MapLocID;

	public string m_MapIconSpriteName;

	public bool m_BigIconOnMap;

	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(CarryableBody), Member = "Dropped")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallerCount(Count = 4)]
	public void AddToMap(Vector3 worldPosition)
	{
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ShowOnMapItem()
	{
	}
}
