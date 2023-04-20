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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(NGUITools), Member = "GetHierarchy")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUIMath), Member = "ConstrainRect")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 12)]
	private Vector3 CalculateConstrainOffset()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Press")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Drag")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIDraggableCamera), Member = "CalculateConstrainOffset")]
	[Calls(Type = typeof(SpringPosition), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public bool ConstrainToBounds(bool immediate)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIDragCamera), Member = "OnPress")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateAbsoluteWidgetBounds")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Press(bool isPressed)
	{
	}

	[CalledBy(Type = typeof(UIDragCamera), Member = "OnDrag")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[Calls(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void Drag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Scroll(float delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateAbsoluteWidgetBounds")]
	[Calls(Type = typeof(UIDraggableCamera), Member = "ConstrainToBounds")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public UIDraggableCamera()
	{
	}
}
