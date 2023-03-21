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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Camera cachedCamera
	{
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
		[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	public UIWidget foregroundWidget
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public UIWidget backgroundWidget
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
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
		[CallerCount(Count = 30)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(EventDelegate), Member = "Execute")]
		[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
		[Calls(Type = typeof(NGUITools), Member = "GetActive")]
		[CallerCount(Count = 143)]
		set
		{
		}
	}

	public float alpha
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 25)]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[CalledBy(Type = typeof(UIScrollView), Member = "CheckScrollbars")]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[CalledBy(Type = typeof(UIScrollView), Member = "CheckScrollbars")]
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

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float GetRawValue()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	protected void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void Upgrade()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnStart()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected void Update()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected void OnValidate()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UISlider), Member = "OnDragForeground")]
	[CalledBy(Type = typeof(UISlider), Member = "OnPressForeground")]
	[CalledBy(Type = typeof(UISlider), Member = "OnDragBackground")]
	[CalledBy(Type = typeof(UISlider), Member = "OnPressBackground")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_cachedCamera")]
	protected float ScreenToValue(Vector2 screenPos)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(UIScrollBar), Member = "LocalToValue")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual float LocalToValue(Vector2 localPos)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CalledBy(Type = typeof(UIScrollBar), Member = "ForceUpdate")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UIProgressBar), Member = "SetThumbPosition")]
	[CallerCount(Count = 1)]
	public virtual void ForceUpdate()
	{
	}

	[CalledBy(Type = typeof(UIScrollBar), Member = "ForceUpdate")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(ScrollbarThumbResizer), Member = "SetThumbPositionFromValue")]
	public void SetThumbPosition(Vector3 worldPos)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private Vector3 LerpWithoutClamp(Vector3 A, Vector3 B, float t)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UIProgressBar()
	{
	}
}
