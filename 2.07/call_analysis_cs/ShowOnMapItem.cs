using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class ShowOnMapItem : MonoBehaviour
{
	private PanelReference<Panel_Map> m_Map;

	public string m_MapLocID;

	public string m_MapIconSpriteName;

	public bool m_BigIconOnMap;

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CarryableBody), Member = "Dropped")]
	public void AddToMap(Vector3 worldPosition)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(CarryableBody), Member = "OnPickedUp")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	public void RemoveFromMap(Vector3 worldPosition)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ShowOnMapItem()
	{
	}
}
