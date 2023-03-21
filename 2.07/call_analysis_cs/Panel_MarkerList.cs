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

	[CalledBy(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "MaybeShowClusterListOnHover")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForSceneDone")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(Panel_Map), Member = "FindCluster")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapIconFromMapElement")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	public void UpdatePosition()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 7)]
	protected override void ConfigureDisplay(MarkerListDisplayItem display, int index)
	{
	}

	[Calls(Type = typeof(MarkerListDisplayItem), Member = "RefreshButtons")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void SetSelected(MarkerListDisplayItem display, bool selected)
	{
	}

	[Calls(Type = typeof(MarkerListDisplayItem), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected override void ClearDisplay(MarkerListDisplayItem display)
	{
	}

	[Calls(Type = typeof(MarkerListDisplayItem), Member = "Setup")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected override void SetupDisplay(MarkerListDisplayItem display, MapElementSaveData item)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected override void OnDeleteItemRequested(int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[CallsUnknownMethods(Count = 4)]
	private bool CanDeleteAll()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	private void OnConfirmCanceled(bool hasCanceled)
	{
	}

	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[CallerCount(Count = 0)]
	private void OnSprayPaintMarkerRemoveConfirm()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDeleteAllMarkerRemoveConfirm()
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteAllMarkerRemoveConfirm")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "DeleteAllDeleteableItems")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnSprayPaintMarkerRemoveConfirm")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapIconFromMapElement")]
	[Calls(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void DoDeleteItem(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void DeleteAllDeleteableItems()
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteAllMarkerRemoveConfirm")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnSprayPaintMarkerRemoveConfirm")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnConfirmCanceled")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnClickedDeleteAll")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteItemRequested")]
	private void Hide(bool isHidden)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateDeleteAllGroup()
	{
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "Update_Internal")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "OpenRockCache")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	[Calls(Type = typeof(InputManager), Member = "GetEquipPressed")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	private void UpdateGamePad()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "OpenRockCache")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisplayClickedOpen(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDisplayClickedOpen")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[Calls(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void OpenRockCache(MapElementSaveData me)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Panel_MarkerList()
	{
		((Panel_List<, >)(object)this)._002Ector();
	}
}
