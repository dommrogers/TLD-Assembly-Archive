using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_MarkerList : Panel_List<MarkerListDisplayItem, MapElementSaveData>
{
	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_Map> m_Map;

	public GameObject m_RootObject;

	public GameObject m_DeleteAllGroup;

	private int m_ClusterCellX;

	private int m_ClusterCellY;

	private bool m_IsClusterSet;

	private int m_IndexToRemove;

	private int m_LastClusterCellX;

	private int m_LastClusterCellY;

	private bool m_LastClusterSet;

	private bool m_CanDeleteAll;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetCluster(ClusterCell clusterCell)
	{
	}

	[CallerCount(Count = 0)]
	public void ResetLastCluster()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsLastCluster(ClusterCell clusterCell)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsClusterSet(ClusterCell clusterCell)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForSceneDone")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "FindCluster")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapIconFromMapElement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 9)]
	public void UpdatePosition()
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void OnClickedDeleteAll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CallsUnknownMethods(Count = 1)]
	protected override void Enable_Internal(bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	protected override void Awake_Internal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[CallsUnknownMethods(Count = 1)]
	protected override void Update_Internal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "FindCluster")]
	[CallsUnknownMethods(Count = 1)]
	protected override List<MapElementSaveData> GatherItems()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
	protected override void ConfigureDisplay(MarkerListDisplayItem display, int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MarkerListDisplayItem), Member = "RefreshButtons")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void SetSelected(MarkerListDisplayItem display, bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MarkerListDisplayItem), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	protected override void ClearDisplay(MarkerListDisplayItem display)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MarkerListDisplayItem), Member = "Setup")]
	[CallsUnknownMethods(Count = 1)]
	protected override void SetupDisplay(MarkerListDisplayItem display, MapElementSaveData item)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	protected override void OnDeleteItemRequested(int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[CallsUnknownMethods(Count = 3)]
	private bool CanDeleteAll()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	private void OnConfirmCanceled(bool hasCanceled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	private void OnSprayPaintMarkerRemoveConfirm()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDeleteAllMarkerRemoveConfirm()
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnSprayPaintMarkerRemoveConfirm")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteAllMarkerRemoveConfirm")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "DeleteAllDeleteableItems")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapIconFromMapElement")]
	[Calls(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DoDeleteItem(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void DeleteAllDeleteableItems()
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnClickedDeleteAll")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteItemRequested")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnConfirmCanceled")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnSprayPaintMarkerRemoveConfirm")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteAllMarkerRemoveConfirm")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	private void Hide(bool isHidden)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateDeleteAllGroup()
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "Update_Internal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_List<, >), Member = "GetItemIndex")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(InputManager), Member = "GetEquipPressed")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "OnClickedDeleteAll")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "OpenRockCache")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateGamePad()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "OpenRockCache")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisplayClickedOpen(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDisplayClickedOpen")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OpenRockCache(MapElementSaveData me)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_List<, >), Member = ".ctor")]
	public Panel_MarkerList()
	{
		((Panel_List<, >)(object)this)._002Ector();
	}
}
