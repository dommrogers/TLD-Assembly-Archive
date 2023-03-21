using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDragResize : MonoBehaviour
{
	public UIWidget target;

	public UIWidget.Pivot pivot;

	public int minWidth;

	public int minHeight;

	public int maxWidth;

	public int maxHeight;

	private Plane mPlane;

	private Vector3 mRayPos;

	private Vector3 mLocalPos;

	private int mWidth;

	private int mHeight;

	private bool mDragging;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UICamera), Member = "get_currentRay")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	private void OnDragStart()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[Calls(Type = typeof(UICamera), Member = "get_currentRay")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(NGUIMath), Member = "ResizeWidget")]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	private void OnDragEnd()
	{
	}

	[CallerCount(Count = 0)]
	public UIDragResize()
	{
	}
}
