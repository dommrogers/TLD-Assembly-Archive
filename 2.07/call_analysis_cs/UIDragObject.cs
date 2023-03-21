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
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void FindPanel()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void UpdateBounds()
	{
	}

	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[Calls(Type = typeof(UIDragObject), Member = "FindPanel")]
	[Calls(Type = typeof(UIDragObject), Member = "UpdateBounds")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelSpring")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Plane), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UIDragObject), Member = "CancelMovement")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelMovement")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void OnPress(bool pressed)
	{
	}

	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay")]
	[Calls(Type = typeof(UIDragObject), Member = "Move")]
	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelMovement")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnDrag")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 7)]
	private void Move(Vector3 worldDelta)
	{
	}

	[Calls(Type = typeof(UIDragObject), Member = "UpdateBounds")]
	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelSpring")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(UIDragObject), Member = "Move")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelMovement")]
	[Calls(Type = typeof(UIDragObject), Member = "CancelMovement")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(UIDragObject), Member = "FindPanel")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnDrag")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void CancelMovement()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	public void CancelSpring()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnScroll(float delta)
	{
	}

	[CallerCount(Count = 0)]
	public UIDragObject()
	{
	}
}
