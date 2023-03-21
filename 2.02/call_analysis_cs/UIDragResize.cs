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

	[Calls(Type = typeof(Plane), Member = ".ctor")]
	[Calls(Type = typeof(UICamera), Member = "get_currentRay")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[Calls(Type = typeof(Ray), Member = "GetPoint")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	private void OnDragStart()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Quaternion), Member = "Inverse")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(NGUIMath), Member = "ResizeWidget")]
	[Calls(Type = typeof(UICamera), Member = "get_currentRay")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Ray), Member = "GetPoint")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	private void OnDragEnd()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public UIDragResize()
	{
	}
}
