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
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(NGUITools), Member = "GetHierarchy")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(NGUIMath), Member = "ConstrainRect")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	private Vector3 CalculateConstrainOffset()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Drag")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Press")]
	[Calls(Type = typeof(SpringPosition), Member = "Begin")]
	[Calls(Type = typeof(UIDraggableCamera), Member = "CalculateConstrainOffset")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	public bool ConstrainToBounds(bool immediate)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateAbsoluteWidgetBounds")]
	[CalledBy(Type = typeof(UIDragCamera), Member = "OnPress")]
	public void Press(bool isPressed)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(UIDragCamera), Member = "OnDrag")]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	public void Drag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsUnknownMethods(Count = 2)]
	public void Scroll(float delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateAbsoluteWidgetBounds")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public UIDraggableCamera()
	{
	}
}
