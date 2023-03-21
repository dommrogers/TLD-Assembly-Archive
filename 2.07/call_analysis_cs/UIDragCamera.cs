using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDragCamera : MonoBehaviour
{
	public UIDraggableCamera draggableCamera;

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIDraggableCamera), Member = "Press")]
	[CallsUnknownMethods(Count = 3)]
	private void OnPress(bool isPressed)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UIDraggableCamera), Member = "Drag")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnDrag(Vector2 delta)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private void OnScroll(float delta)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIDragCamera()
	{
	}
}
