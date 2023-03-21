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

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	protected virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDragStart()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDragEnd()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "MarkParentAsChanged")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(DragDropItem), Member = "MoveWidgetDepth")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	protected virtual void OnDragDropStart()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UICamera), Member = "get_mainCamera")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void TryForceDrop(bool dropOnHovered)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CalledBy(Type = typeof(DragDropItem), Member = "OnDragDropStart")]
	[CallsUnknownMethods(Count = 5)]
	private void MoveWidgetDepth(int amountToMove)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void OnApplicationFocus(bool focusStatus)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DragDropItem()
	{
	}
}
