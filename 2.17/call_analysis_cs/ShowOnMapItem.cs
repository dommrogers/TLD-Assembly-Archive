using Cpp2ILInjected.CallAnalysis;
using TLD.BigCarry;
using TLD.UI.Generics;
using UnityEngine;

public class ShowOnMapItem : MonoBehaviour
{
	private PanelReference<Panel_Map> m_Map;

	public string m_MapLocID;

	public string m_MapIconSpriteName;

	public bool m_BigIconOnMap;

	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CalledBy(Type = typeof(BodyBigCarryItem), Member = "OnDropped")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallsUnknownMethods(Count = 1)]
	public void AddToMap(Vector3 worldPosition)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(BodyBigCarryItem), Member = "OnCarried")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveFromMap(Vector3 worldPosition)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ShowOnMapItem()
	{
	}
}
