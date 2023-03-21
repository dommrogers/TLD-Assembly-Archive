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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void FindPanel()
	{
	}

	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateBounds()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelMovement")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIDragObject), Member = "FindPanel")]
	[Calls(Type = typeof(UIDragObject), Member = "UpdateBounds")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelSpring")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Plane), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void OnPress(bool pressed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(UIDragObject), Member = "Move")]
	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelMovement")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void OnDrag(Vector2 delta)
	{
	}

	[CalledBy(Type = typeof(UIDragObject), Member = "OnDrag")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void Move(Vector3 worldDelta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIDragObject), Member = "FindPanel")]
	[Calls(Type = typeof(UIDragObject), Member = "Move")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIDragObject), Member = "UpdateBounds")]
	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelSpring")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelMovement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnDrag")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void CancelMovement()
	{
	}

	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public void CancelSpring()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnScroll(float delta)
	{
	}

	[CallerCount(Count = 0)]
	public UIDragObject()
	{
	}
}
