using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDragObject : MonoBehaviour
{
	public enum DragEffect
	{
		None,
		Momentum,
		MomentumAndSpring
	}

	public Transform target;

	public UIPanel panelRegion;

	public Vector3 scrollMomentum;

	public bool restrictWithinPanel;

	public UIRect contentRect;

	public DragEffect dragEffect;

	public float momentumAmount;

	protected Vector3 scale;

	private float scrollWheelFactor;

	private Plane mPlane;

	private Vector3 mTargetPos;

	private Vector3 mLastPos;

	private Vector3 mMomentum;

	private Vector3 mScroll;

	private Bounds mBounds;

	private int mTouchID;

	private bool mStarted;

	private bool mPressed;

	public Vector3 dragMovement
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[CallsUnknownMethods(Count = 3)]
	private void FindPanel()
	{
	}

	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	private void UpdateBounds()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIDragObject), Member = "CancelMovement")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelMovement")]
	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Plane), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelSpring")]
	[Calls(Type = typeof(UIDragObject), Member = "UpdateBounds")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UIDragObject), Member = "FindPanel")]
	private void OnPress(bool pressed)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(UIDragObject), Member = "Move")]
	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelMovement")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallerCount(Count = 0)]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnDrag")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
	private void Move(Vector3 worldDelta)
	{
	}

	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(UIDragObject), Member = "Move")]
	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIDragObject), Member = "UpdateBounds")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelSpring")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelMovement")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelMovement")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(UIDragObject), Member = "FindPanel")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	private void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnDrag")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void CancelMovement()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	public void CancelSpring()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsUnknownMethods(Count = 2)]
	private void OnScroll(float delta)
	{
	}

	[CallerCount(Count = 0)]
	public UIDragObject()
	{
	}
}
