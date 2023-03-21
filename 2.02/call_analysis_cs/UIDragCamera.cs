using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDragCamera : MonoBehaviour
{
	public UIDraggableCamera draggableCamera;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDraggableCamera), Member = "Press")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	private void OnPress(bool isPressed)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDraggableCamera), Member = "Drag")]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UIDraggableCamera), Member = "Scroll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void OnScroll(float delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public UIDragCamera()
	{
	}
}
