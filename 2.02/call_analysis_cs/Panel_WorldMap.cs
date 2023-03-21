using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_WorldMap : Panel_Base
{
	private ButtonLegendContainer m_ButtonLegendContainer;

	private Transform m_MapElementsTransform;

	private MapCrosshair m_Crosshair;

	private float m_GamepadMoveSpeed;

	private float m_MaxMouseClickDistance;

	private Vector3 m_MapElementsOrigPos;

	private UIWidget m_CrosshairWidget;

	private WorldMapRegion[] m_Regions;

	private WorldMapRegion m_HoverRegion;

	private Vector3 m_MouseDownPosition;

	private WorldMapDetail[] m_Details;

	private WorldMapState m_State;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 18)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "DoMouseControls")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "DoGamepadControls")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "MaybeFollowMouseWithCrosshair")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "CheckForHoverState")]
	[Calls(Type = typeof(MapCrosshair), Member = "SetState")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "SelectRegionMap")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "EnableWorldMapDetail")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "EnableWorldMapDetail")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddMapDetailToMap(MapDetail md)
	{
	}

	[CalledBy(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void RemoveMapDetailFromMap(MapDetail md)
	{
	}

	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "SelectRegionMap")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "ResetToNormal")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void Enable(WorldMapState state)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_WorldMap), Member = "SelectRegionMap")]
	public void OnBackToRegionMap()
	{
	}

	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "OnBackToRegionMap")]
	[CalledBy(Type = typeof(WorldMapRegion), Member = "OnSelect")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "Enable")]
	[Calls(Type = typeof(Panel_Map), Member = "SetRegion")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectRegionMap(string regionName)
	{
	}

	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Quaternion), Member = "Inverse")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UIWidget), Member = "get_localCenter")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 17)]
	private void CheckForHoverState()
	{
	}

	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WorldMapRegion), Member = "OnSelect")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DoGamepadControls()
	{
	}

	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WorldMapRegion), Member = "OnSelect")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void DoMouseControls()
	{
	}

	[CalledBy(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "AddMapDetailToMap")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void EnableWorldMapDetail(string guid)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void DisableWorldMapDetail(string guid)
	{
	}

	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 33)]
	private void MaybeFollowMouseWithCrosshair()
	{
	}

	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MapCrosshair), Member = "ResetToNormal")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void ResetToNormal()
	{
	}

	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(ButtonLegend), Member = "RemoveButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapCrosshair), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateCrosshairState()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Panel_WorldMap()
	{
	}
}
