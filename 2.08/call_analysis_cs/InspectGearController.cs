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
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(Cursor), Member = "set_visible")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UICamera), Member = "get_isOverUI")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[CallsUnknownMethods(Count = 11)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 40)]
	public void SetGearItem(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InspectGearController()
	{
	}
}
