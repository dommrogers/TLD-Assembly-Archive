using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDragCamera : MonoBehaviour
{
	public UIDraggableCamera draggableCamera;

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateAbsoluteWidgetBounds")]
	[Calls(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void OnPress(bool isPressed)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UIDraggableCamera), Member = "Drag")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void OnScroll(float delta)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UIDragCamera()
	{
	}
}
