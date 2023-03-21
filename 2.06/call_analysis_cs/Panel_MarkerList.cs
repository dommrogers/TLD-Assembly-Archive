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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsClusterSet(ClusterCell clusterCell)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForSceneDone")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Panel_Map), Member = "FindCluster")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapIconFromMapElement")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void UpdatePosition()
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	public void OnClickedDeleteAll()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CallsUnknownMethods(Count = 1)]
	protected override void Enable_Internal(bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	protected override void Awake_Internal()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	protected override void Update_Internal()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "FindCluster")]
	[CallsUnknownMethods(Count = 1)]
	protected override List<MapElementSaveData> GatherItems()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected override void ConfigureDisplay(MarkerListDisplayItem display, int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MarkerListDisplayItem), Member = "RefreshButtons")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MarkerListDisplayItem), Member = "Setup")]
	protected override void SetupDisplay(MarkerListDisplayItem display, MapElementSaveData item)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	protected override void OnDeleteItemRequested(int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool CanDeleteAll()
	{
		return default(bool);
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

	[Calls(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	private void OnDeleteAllMarkerRemoveConfirm()
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnSprayPaintMarkerRemoveConfirm")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteAllMarkerRemoveConfirm")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "DeleteAllDeleteableItems")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapIconFromMapElement")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[CallsUnknownMethods(Count = 2)]
	private void DoDeleteItem(int index)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	private void DeleteAllDeleteableItems()
	{
	}

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnClickedDeleteAll")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteItemRequested")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnConfirmCanceled")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnSprayPaintMarkerRemoveConfirm")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteAllMarkerRemoveConfirm")]
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "Update_Internal")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "OnClickedDeleteAll")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetEquipPressed")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "OpenRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	private void UpdateGamePad()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "OpenRockCache")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisplayClickedOpen(int index)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDisplayClickedOpen")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[Calls(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OpenRockCache(MapElementSaveData me)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Panel_MarkerList()
	{
		((Panel_List<, >)(object)this)._002Ector();
	}
}
