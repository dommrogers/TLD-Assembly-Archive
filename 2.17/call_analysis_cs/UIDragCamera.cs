using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDragCamera : MonoBehaviour
{
	public UIDraggableCamera draggableCamera;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIDraggableCamera), Member = "Press")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIDraggableCamera), Member = "Drag")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
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
