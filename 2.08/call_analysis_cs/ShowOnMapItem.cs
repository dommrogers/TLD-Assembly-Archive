using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class ShowOnMapItem : MonoBehaviour
{
	private PanelReference<Panel_Map> m_Map;

	public string m_MapLocID;

	public string m_MapIconSpriteName;

	public bool m_BigIconOnMap;

	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CarryableBody), Member = "Dropped")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	public void AddToMap(Vector3 worldPosition)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CarryableBody), Member = "OnPickedUp")]
	public void RemoveFromMap(Vector3 worldPosition)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ShowOnMapItem()
	{
	}
}
