using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InspectGearController : MonoBehaviour
{
	private GearItem m_GearItem;

	private bool m_MouseDownPreviousFrame;

	private bool m_DragActive;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "get_isOverUI")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Cursor), Member = "set_visible")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Utils), Member = "GetInspectModePivot")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 30)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 77)]
	public void SetGearItem(GearItem gi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public InspectGearController()
	{
	}
}
