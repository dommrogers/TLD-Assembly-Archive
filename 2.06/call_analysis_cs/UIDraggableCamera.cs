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

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "GetHierarchy")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[Calls(Type = typeof(NGUIMath), Member = "ConstrainRect")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private Vector3 CalculateConstrainOffset()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(SpringPosition), Member = "Begin")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(UIDragCamera), Member = "OnPress")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Press")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Drag")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIDraggableCamera), Member = "CalculateConstrainOffset")]
	public bool ConstrainToBounds(bool immediate)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateAbsoluteWidgetBounds")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public void Press(bool isPressed)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[CalledBy(Type = typeof(UIDragCamera), Member = "OnDrag")]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[CallsUnknownMethods(Count = 4)]
	public void Drag(Vector2 delta)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Scroll(float delta)
	{
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateAbsoluteWidgetBounds")]
	[Calls(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public UIDraggableCamera()
	{
	}
}
