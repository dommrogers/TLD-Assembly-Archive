using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class InspectGearController : MonoBehaviour
{
	private PanelReference<Panel_Log> m_Log;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private GearItem m_GearItem;

	private bool m_MouseDownPreviousFrame;

	private bool m_DragActive;

	[Calls(Type = typeof(Utils), Member = "GetInspectModePivot")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(Cursor), Member = "set_visible")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UICamera), Member = "get_isOverUI")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 36)]
	public void SetGearItem(GearItem gi)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public InspectGearController()
	{
	}
}
