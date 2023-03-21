using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIProgressBar : UIWidgetContainer
{
	public enum FillDirection
	{
		LeftToRight,
		RightToLeft,
		BottomToTop,
		TopToBottom
	}

	public delegate void OnDragFinished();

	public static UIProgressBar current;

	public OnDragFinished onDragFinished;

	public Transform thumb;

	public float thumbOffset;

	public Vector2 thumbLimits;

	protected UIWidget mBG;

	protected UIWidget mFG;

	protected float mValue;

	protected FillDirection mFill;

	protected Transform mTrans;

	protected bool mIsDirty;

	protected Camera mCam;

	protected float mOffset;

	public int numberOfSteps;

	public List<EventDelegate> onChange;

	public Transform cachedTransform
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Camera cachedCamera
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
		[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	public UIWidget foregroundWidget
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public UIWidget backgroundWidget
	{
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public FillDirection fillDirection
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(FillDirection);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public float value
	{
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 27)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 143)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
		[Calls(Type = typeof(EventDelegate), Member = "Execute")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(NGUITools), Member = "GetActive")]
		set
		{
		}
	}

	public float alpha
	{
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[CallsDeduplicatedMethods(Count = 25)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[CalledBy(Type = typeof(UIScrollView), Member = "CheckScrollbars")]
		[CalledBy(Type = typeof(UIScrollView), Member = "CheckScrollbars")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		set
		{
		}
	}

	protected bool isHorizontal
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	protected bool isInverted
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetRawValue()
	{
		return default(float);
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	protected void Start()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected virtual void Upgrade()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected virtual void OnStart()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	protected void OnValidate()
	{
	}

	[CalledBy(Type = typeof(UISlider), Member = "OnPressBackground")]
	[CalledBy(Type = typeof(UISlider), Member = "OnDragBackground")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_cachedCamera")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(UISlider), Member = "OnPressForeground")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(UISlider), Member = "OnDragForeground")]
	protected float ScreenToValue(Vector2 screenPos)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(UIScrollBar), Member = "LocalToValue")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	protected virtual float LocalToValue(Vector2 localPos)
	{
		return default(float);
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIProgressBar), Member = "SetThumbPosition")]
	[CalledBy(Type = typeof(UIScrollBar), Member = "ForceUpdate")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public virtual void ForceUpdate()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(ScrollbarThumbResizer), Member = "SetThumbPositionFromValue")]
	[CalledBy(Type = typeof(UIScrollBar), Member = "ForceUpdate")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
	public void SetThumbPosition(Vector3 worldPos)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private Vector3 LerpWithoutClamp(Vector3 A, Vector3 B, float t)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UISlider), Member = ".ctor")]
	[CalledBy(Type = typeof(UIScrollBar), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public UIProgressBar()
	{
	}
}
