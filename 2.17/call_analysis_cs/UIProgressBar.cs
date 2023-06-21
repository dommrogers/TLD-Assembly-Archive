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
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Camera cachedCamera
	{
		[CalledBy(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	public UIWidget foregroundWidget
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
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

	public UIWidget backgroundWidget
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
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
			return 0f;
		}
		[CallerCount(Count = 148)]
		[Calls(Type = typeof(NGUITools), Member = "GetActive")]
		[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
		[Calls(Type = typeof(EventDelegate), Member = "Execute")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		set
		{
		}
	}

	public float alpha
	{
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
		[CalledBy(Type = typeof(UIScrollView), Member = "CheckScrollbars")]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	protected bool isHorizontal
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	protected bool isInverted
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetRawValue()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	protected void OnValidate()
	{
	}

	[CalledBy(Type = typeof(UISlider), Member = "OnPressBackground")]
	[CalledBy(Type = typeof(UISlider), Member = "OnDragBackground")]
	[CalledBy(Type = typeof(UISlider), Member = "OnPressForeground")]
	[CalledBy(Type = typeof(UISlider), Member = "OnDragForeground")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_cachedCamera")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	protected float ScreenToValue(Vector2 screenPos)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(UIScrollBar), Member = "LocalToValue")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual float LocalToValue(Vector2 localPos)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(UIScrollBar), Member = "ForceUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIProgressBar), Member = "SetThumbPosition")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 8)]
	public virtual void ForceUpdate()
	{
	}

	[CalledBy(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
	[CalledBy(Type = typeof(UIScrollBar), Member = "ForceUpdate")]
	[CalledBy(Type = typeof(ScrollbarThumbResizer), Member = "SetThumbPositionFromValue")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	public void SetThumbPosition(Vector3 worldPos)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private Vector3 LerpWithoutClamp(Vector3 A, Vector3 B, float t)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public UIProgressBar()
	{
	}
}
