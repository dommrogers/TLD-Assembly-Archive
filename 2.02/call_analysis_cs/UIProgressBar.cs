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
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public Camera cachedCamera
	{
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
		[CalledBy(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
		get
		{
			return null;
		}
	}

	public UIWidget foregroundWidget
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		set
		{
		}
	}

	public UIWidget backgroundWidget
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 164)]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(float);
		}
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(NGUITools), Member = "GetActive")]
		[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
		[Calls(Type = typeof(EventDelegate), Member = "Execute")]
		[CallerCount(Count = 149)]
		[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public float alpha
	{
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[Calls(Type = typeof(Collider), Member = "set_enabled")]
		[CalledBy(Type = typeof(UIScrollView), Member = "CheckScrollbars")]
		[CalledBy(Type = typeof(UIScrollView), Member = "CheckScrollbars")]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[CalledBy(Type = typeof(UIScrollView), Member = "LateUpdate")]
		[CallsUnknownMethods(Count = 22)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 26)]
		[CallerCount(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	protected void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void Upgrade()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void OnStart()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	protected void OnValidate()
	{
	}

	[Calls(Type = typeof(Ray), Member = "GetPoint")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CalledBy(Type = typeof(UISlider), Member = "OnPressBackground")]
	[CalledBy(Type = typeof(UISlider), Member = "OnDragBackground")]
	[CalledBy(Type = typeof(UISlider), Member = "OnPressForeground")]
	[CalledBy(Type = typeof(UISlider), Member = "OnDragForeground")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_cachedCamera")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Vector3), Member = "get_back")]
	protected float ScreenToValue(Vector2 screenPos)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UIScrollBar), Member = "LocalToValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected virtual float LocalToValue(Vector2 localPos)
	{
		return default(float);
	}

	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIProgressBar), Member = "SetThumbPosition")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 53)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CalledBy(Type = typeof(UIScrollBar), Member = "ForceUpdate")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public virtual void ForceUpdate()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(ScrollbarThumbResizer), Member = "SetThumbPositionFromValue")]
	[CalledBy(Type = typeof(UIScrollBar), Member = "ForceUpdate")]
	[CalledBy(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	public void SetThumbPosition(Vector3 worldPos)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private Vector3 LerpWithoutClamp(Vector3 A, Vector3 B, float t)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CalledBy(Type = typeof(UIScrollBar), Member = ".ctor")]
	[CalledBy(Type = typeof(UISlider), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public UIProgressBar()
	{
	}
}
