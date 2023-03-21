using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_MarkerList : Panel_List<MarkerListDisplayItem, MapElementSaveData>
{
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

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForSceneDone")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapIconFromMapElement")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Map), Member = "FindCluster")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public void UpdatePosition()
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsUnknownMethods(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	public void OnClickedDeleteAll()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CallsUnknownMethods(Count = 2)]
	protected override void Enable_Internal(bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	protected override void Awake_Internal()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	protected override void Update_Internal()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "FindCluster")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override List<MapElementSaveData> GatherItems()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 25)]
	protected override void ConfigureDisplay(MarkerListDisplayItem display, int index)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(MarkerListDisplayItem), Member = "RefreshButtons")]
	protected override void SetSelected(MarkerListDisplayItem display, bool selected)
	{
	}

	[Calls(Type = typeof(MarkerListDisplayItem), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 16)]
	protected override void OnDeleteItemRequested(int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MarkerListDisplayItem), Member = "CanDelete")]
	[CallsUnknownMethods(Count = 2)]
	private bool CanDeleteAll()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "Hide")]
	[Calls(Type = typeof(MarkerListDisplayItem), Member = "CanDelete")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDeleteAllMarkerRemoveConfirm()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "DeleteAllDeleteableItems")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteAllMarkerRemoveConfirm")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnSprayPaintMarkerRemoveConfirm")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapIconFromMapElement")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	private void DoDeleteItem(int index)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MarkerListDisplayItem), Member = "CanDelete")]
	private void DeleteAllDeleteableItems()
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnClickedDeleteAll")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteItemRequested")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnConfirmCanceled")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnSprayPaintMarkerRemoveConfirm")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteAllMarkerRemoveConfirm")]
	private void Hide(bool isHidden)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateDeleteAllGroup()
	{
	}

	[Calls(Type = typeof(Panel_MarkerList), Member = "OnClickedDeleteAll")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "Update_Internal")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "OpenRockCache")]
	[Calls(Type = typeof(InputManager), Member = "GetEquipPressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	private void UpdateGamePad()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "OpenRockCache")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisplayClickedOpen(int index)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDisplayClickedOpen")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	private void OpenRockCache(MapElementSaveData me)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Panel_MarkerList()
	{
		((Panel_List<, >)(object)this)._002Ector();
	}
}
