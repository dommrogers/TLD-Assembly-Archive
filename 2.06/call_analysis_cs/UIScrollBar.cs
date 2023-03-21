using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIScrollBar : UISlider
{
	private enum Direction
	{
		Horizontal,
		Vertical,
		Upgraded
	}

	protected float mSize;

	private float mScroll;

	private Direction mDir;

	public float scrollValue
	{
		[CallerCount(Count = 27)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public float barSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		[CalledBy(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
		[Calls(Type = typeof(EventDelegate), Member = "Execute")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(NGUITools), Member = "GetActive")]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	protected override void Upgrade()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UIEventListener), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(UISlider), Member = "OnStart")]
	protected override void OnStart()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIProgressBar), Member = "LocalToValue")]
	[CallsUnknownMethods(Count = 2)]
	protected override float LocalToValue(Vector2 localPos)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIProgressBar), Member = "SetThumbPosition")]
	[CallsUnknownMethods(Count = 3)]
	public override void ForceUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = ".ctor")]
	public UIScrollBar()
	{
	}
}
