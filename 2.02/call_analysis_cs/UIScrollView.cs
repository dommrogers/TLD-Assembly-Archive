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
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Bounds), Member = "get_size")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(bool);
		}
	}

	public virtual bool shouldMoveVertically
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
		[Calls(Type = typeof(Bounds), Member = "get_size")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	protected virtual bool shouldMove
	{
		[Calls(Type = typeof(Bounds), Member = "get_max")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIPanel), Member = "get_finalClipRegion")]
		[Calls(Type = typeof(Bounds), Member = "get_min")]
		[Calls(Type = typeof(Bounds), Member = "get_min")]
		[Calls(Type = typeof(Bounds), Member = "get_max")]
		[CallsUnknownMethods(Count = 4)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 5)]
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

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivot")]
	[Calls(Type = typeof(Vector2), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_alpha")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_alpha")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void CheckScrollbars()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	public bool RestrictWithinBounds(bool instant)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UIScrollView), Member = "Press")]
	[CalledBy(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	[Calls(Type = typeof(SpringPanel), Member = "Begin")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UIScrollView), Member = "Drag")]
	[CallerCount(Count = 4)]
	public bool RestrictWithinBounds(bool instant, bool horizontal, bool vertical)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UIScrollView), Member = "Scroll")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIScrollView), Member = "Press")]
	[CalledBy(Type = typeof(UIScrollView), Member = "SetDragAmount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void DisableSpring()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void UpdateScrollbars()
	{
	}

	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
	[Calls(Type = typeof(UIPanel), Member = "get_finalClipRegion")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIPanel), Member = "get_finalClipRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public virtual void UpdateScrollbars(bool recalculateBounds)
	{
	}

	[CalledBy(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIScrollBar), Member = "set_barSize")]
	[CalledBy(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void UpdateScrollbars(UIProgressBar slider, float contentMin, float contentMax, float contentSize, float viewSize, bool inverted)
	{
	}

	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(UIPanel), Member = "get_finalClipRegion")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIScrollView), Member = "DisableSpring")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public virtual void SetDragAmount(float x, float y, bool updateScrollbars)
	{
	}

	[CallerCount(Count = 0)]
	public void InvalidateBounds()
	{
	}

	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	public void ResetPosition()
	{
	}

	[CalledBy(Type = typeof(TypewriterEffect), Member = "Finish")]
	[CalledBy(Type = typeof(UIPanel), Member = "set_baseClipRegion")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
	[CalledBy(Type = typeof(TypewriterEffect), Member = "Update")]
	public void UpdatePosition()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnScrollBar()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[CallsUnknownMethods(Count = 4)]
	public virtual void MoveRelative(Vector3 relative)
	{
	}

	[CalledBy(Type = typeof(UIScrollView), Member = "Drag")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(UIScrollView), Member = "Drag")]
	[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void MoveAbsolute(Vector3 absolute)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_back")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(UIScrollView), Member = "DisableSpring")]
	[Calls(Type = typeof(UICenterOnChild), Member = "Recenter")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Plane), Member = ".ctor")]
	[Calls(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CalledBy(Type = typeof(UIDragScrollView), Member = "OnPress")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Press(bool pressed)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	[Calls(Type = typeof(UIScrollView), Member = "MoveAbsolute")]
	[Calls(Type = typeof(UIScrollView), Member = "MoveAbsolute")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Ray), Member = "GetPoint")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(UIDragScrollView), Member = "OnDrag")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsUnknownMethods(Count = 15)]
	public void Drag()
	{
	}

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIScrollView), Member = "DisableSpring")]
	[CalledBy(Type = typeof(UIDragScrollView), Member = "OnScroll")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Update")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Scroll")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "ScrollToBottom")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCollectibleNote")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "ScrollToTop")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowCollectibleNote")]
	public void Scroll(float delta)
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "get_alpha")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_alpha")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_alpha")]
	[Calls(Type = typeof(UIScrollView), Member = "MoveAbsolute")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[Calls(Type = typeof(NGUIMath), Member = "SpringDampen")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIScrollView), Member = "RestrictWithinBounds")]
	[Calls(Type = typeof(UICenterOnChild), Member = "Recenter")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_alpha")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_alpha")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_alpha")]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UIScrollView()
	{
	}
}
