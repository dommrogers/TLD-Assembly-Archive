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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 30)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		[CalledBy(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
		[Calls(Type = typeof(EventDelegate), Member = "Execute")]
		[Calls(Type = typeof(NGUITools), Member = "GetActive")]
		[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UIEventListener), Member = "Get")]
	[Calls(Type = typeof(UISlider), Member = "OnStart")]
	protected override void OnStart()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "LocalToValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected override float LocalToValue(Vector2 localPos)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "SetThumbPosition")]
	[Calls(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
	[CallsUnknownMethods(Count = 3)]
	public override void ForceUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UIScrollBar()
	{
	}
}
