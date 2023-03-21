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

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(MapCrosshair), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_WorldMap), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "SelectRegionMap")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "CheckForHoverState")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "DoGamepadControls")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "MaybeFollowMouseWithCrosshair")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "DoMouseControls")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 23)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_WorldMap), Member = "EnableWorldMapDetail")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 9)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_WorldMap), Member = "EnableWorldMapDetail")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public void AddMapDetailToMap(MapDetail md)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CallsUnknownMethods(Count = 7)]
	public void RemoveMapDetailFromMap(MapDetail md)
	{
	}

	[CalledBy(Type = typeof(Panel_WorldMap), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "SelectRegionMap")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "ResetToNormal")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	public void Enable(WorldMapState state)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "Enable")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_WorldMap), Member = "SelectRegionMap")]
	public void OnBackToRegionMap()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WorldMapRegion), Member = "OnSelect")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "OnBackToRegionMap")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[Calls(Type = typeof(Panel_Map), Member = "SetRegion")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_WorldMap), Member = "Enable")]
	public void SelectRegionMap(string regionName)
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(UIWidget), Member = "get_localCenter")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Quaternion), Member = "Inverse")]
	private void CheckForHoverState()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WorldMapRegion), Member = "OnSelect")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void DoGamepadControls()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[Calls(Type = typeof(WorldMapRegion), Member = "OnSelect")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void DoMouseControls()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "AddMapDetailToMap")]
	[CallsUnknownMethods(Count = 3)]
	private void EnableWorldMapDetail(string guid)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void DisableWorldMapDetail(string guid)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[CallsUnknownMethods(Count = 33)]
	private void MaybeFollowMouseWithCrosshair()
	{
	}

	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Enable")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MapCrosshair), Member = "ResetToNormal")]
	private void ResetToNormal()
	{
	}

	[CalledBy(Type = typeof(Panel_WorldMap), Member = "Update")]
	[Calls(Type = typeof(ButtonLegend), Member = "RemoveButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(MapCrosshair), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void UpdateCrosshairState()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public Panel_WorldMap()
	{
	}
}
