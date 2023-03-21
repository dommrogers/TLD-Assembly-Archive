using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIScrollView : MonoBehaviour
{
	public enum Movement
	{
		Horizontal,
		Vertical,
		Unrestricted,
		Custom
	}

	public enum DragEffect
	{
		None,
		Momentum,
		MomentumAndSpring
	}

	public enum ShowCondition
	{
		Always,
		OnlyIfNeeded,
		WhenDragging
	}

	public delegate void OnDragNotification();

	public static BetterList<UIScrollView> list;

	public Movement movement;

	public DragEffect dragEffect;

	public bool restrictWithinPanel;

	public bool disableDragIfFits;

	public bool smoothDragStart;

	public bool iOSDragEmulation;

	public float scrollWheelFactor;

	public float momentumAmount;

	public float dampenStrength;

	public bool doNotChangeScrollbarAlpha;

	public UIProgressBar horizontalScrollBar;

	public UIProgressBar verticalScrollBar;

	public ShowCondition showScrollBars;

	public Vector2 customMovement;

	public UIWidget.Pivot contentPivot;

	public OnDragNotification onDragStarted;

	public OnDragNotification onDragFinished;

	public OnDragNotification onMomentumMove;

	public OnDragNotification onStoppedMoving;

	private Vector3 scale;

	private Vector2 relativePositionOnReset;

	protected Transform mTrans;

	protected UIPanel mPanel;

	protected Plane mPlane;

	protected Vector3 mLastPos;

	protected bool mPressed;

	protected Vector3 mMomentum;

	protected float mScroll;

	protected Bounds mBounds;

	protected bool mCalculatedBounds;

	protected bool mShouldMove;

	protected bool mIgnoreCallbacks;

	protected int mDragID;

	protected Vector2 mDragStartOffset;

	protected bool mDragStarted;

	[NonSerialized]
	private bool mStarted;

	public UICenterOnChild centerOnChild;

	public UIPanel panel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public bool isDragging
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public virtual Bounds bounds
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(Bounds);
		}
	}

	public bool canMoveHorizontally
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool canMoveVertically
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public virtual bool shouldMoveHorizontally
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public virtual bool shouldMoveVertically
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	protected virtual bool shouldMove
	{
		[CallsUnknownMethods(Count = 3)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
		get
		{
			return default(bool);
		}
	}

	public Vector3 currentMomentum
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

	[Calls(Type = typeof(NGUIMath), Member = "GetPivot")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnEnable()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_alpha")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_alpha")]
	private void CheckScrollbars()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	[CallerCount(Count = 0)]
	public bool RestrictWithinBounds(bool instant)
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(SpringPanel), Member = "Begin")]
	[CalledBy(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	[CalledBy(Type = typeof(UIScrollView), Member = "Press")]
	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIScrollView), Member = "Drag")]
	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	public bool RestrictWithinBounds(bool instant, bool horizontal, bool vertical)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UIScrollView), Member = "SetDragAmount")]
	[CalledBy(Type = typeof(UIScrollView), Member = "Scroll")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIScrollView), Member = "Press")]
	public void DisableSpring()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdateScrollbars()
	{
	}

	[Calls(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	public virtual void UpdateScrollbars(bool recalculateBounds)
	{
	}

	[CalledBy(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
	[CalledBy(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
	[Calls(Type = typeof(UIScrollBar), Member = "set_barSize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	protected void UpdateScrollbars(UIProgressBar slider, float contentMin, float contentMax, float contentSize, float viewSize, bool inverted)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UIScrollView), Member = "DisableSpring")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	public virtual void SetDragAmount(float x, float y, bool updateScrollbars)
	{
	}

	[CallerCount(Count = 0)]
	public void InvalidateBounds()
	{
	}

	[ContextMenu("Reset Clipping Position")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	public void ResetPosition()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIPanel), Member = "set_baseClipRegion")]
	[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
	[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
	[CalledBy(Type = typeof(TypewriterEffect), Member = "Finish")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	public void UpdatePosition()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollBar()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	public virtual void MoveRelative(Vector3 relative)
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UIScrollView), Member = "Drag")]
	[CalledBy(Type = typeof(UIScrollView), Member = "Drag")]
	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void MoveAbsolute(Vector3 absolute)
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[Calls(Type = typeof(Plane), Member = ".ctor")]
	[Calls(Type = typeof(UIScrollView), Member = "DisableSpring")]
	[Calls(Type = typeof(UICenterOnChild), Member = "Recenter")]
	[Calls(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CalledBy(Type = typeof(UIDragScrollView), Member = "OnPress")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void Press(bool pressed)
	{
	}

	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay")]
	[Calls(Type = typeof(UIScrollView), Member = "MoveAbsolute")]
	[Calls(Type = typeof(UIScrollView), Member = "MoveAbsolute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	[CalledBy(Type = typeof(UIDragScrollView), Member = "OnDrag")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[CallsUnknownMethods(Count = 6)]
	public void Drag()
	{
	}

	[CalledBy(Type = typeof(UIDragScrollView), Member = "OnScroll")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Update")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Scroll")]
	[Calls(Type = typeof(UIScrollView), Member = "DisableSpring")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "ScrollToBottom")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "ScrollToTop")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowCollectibleNote")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCollectibleNote")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Scroll(float delta)
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "get_alpha")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_alpha")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_alpha")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	[Calls(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	[Calls(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIScrollView), Member = "MoveAbsolute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICenterOnChild), Member = "Recenter")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_alpha")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_alpha")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_alpha")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public UIScrollView()
	{
	}
}
