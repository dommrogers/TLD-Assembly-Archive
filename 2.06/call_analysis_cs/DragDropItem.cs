using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DragDropItem : MonoBehaviour
{
	public GearItem m_GearItem;

	public bool m_ForceClickOnStartDrag;

	protected Transform mTrans;

	protected Transform mParent;

	protected Collider mCollider;

	protected UIButton mButton;

	protected UIRoot mRoot;

	protected UIGrid mGrid;

	protected UITable mTable;

	protected int mTouchID;

	protected float mPressTime;

	protected UIDragScrollView mDragScrollView;

	private Vector3 m_OriginalPosition;

	private bool m_IsDragging;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnPress(bool isPressed)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnDragStart()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDragEnd()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "MarkParentAsChanged")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(DragDropItem), Member = "MoveWidgetDepth")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	protected virtual void OnDragDropStart()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UICamera), Member = "get_mainCamera")]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void OnDragDropMove(Vector3 delta)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected virtual void OnDragDropRelease(GameObject surface)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsDragging()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void TryForceDrop(bool dropOnHovered)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CalledBy(Type = typeof(DragDropItem), Member = "OnDragDropStart")]
	[CallsUnknownMethods(Count = 2)]
	private void MoveWidgetDepth(int amountToMove)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnApplicationFocus(bool focusStatus)
	{
	}

	[CallerCount(Count = 0)]
	public DragDropItem()
	{
	}
}
