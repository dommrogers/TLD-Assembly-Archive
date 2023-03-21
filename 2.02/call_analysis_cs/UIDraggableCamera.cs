using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDraggableCamera : MonoBehaviour
{
	public Transform rootForBounds;

	public Vector2 scale;

	public float scrollWheelFactor;

	public UIDragObject.DragEffect dragEffect;

	public bool smoothDragStart;

	public float momentumAmount;

	private Camera mCam;

	private Transform mTrans;

	private bool mPressed;

	private Vector2 mMomentum;

	private Bounds mBounds;

	private float mScroll;

	private UIRoot mRoot;

	private bool mDragStarted;

	public Vector2 currentMomentum
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "GetHierarchy")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void Start()
	{
	}

	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(NGUIMath), Member = "ConstrainRect")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	private Vector3 CalculateConstrainOffset()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Drag")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Press")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(SpringPosition), Member = "Begin")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UIDraggableCamera), Member = "CalculateConstrainOffset")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public bool ConstrainToBounds(bool immediate)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateAbsoluteWidgetBounds")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIDragCamera), Member = "OnPress")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Press(bool isPressed)
	{
	}

	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UIDragCamera), Member = "OnDrag")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[Calls(Type = typeof(Vector2), Member = "Lerp")]
	public void Drag(Vector2 delta)
	{
	}

	[CalledBy(Type = typeof(UIDragCamera), Member = "OnScroll")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Scroll(float delta)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateAbsoluteWidgetBounds")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_one")]
	public UIDraggableCamera()
	{
	}
}
