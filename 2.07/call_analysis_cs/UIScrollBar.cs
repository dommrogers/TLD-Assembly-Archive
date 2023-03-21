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
		[DeduplicatedMethod]
		[CallerCount(Count = 30)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
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
			return 0f;
		}
		[CalledBy(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(NGUITools), Member = "GetActive")]
		[Calls(Type = typeof(EventDelegate), Member = "Execute")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	protected override void Upgrade()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISlider), Member = "OnStart")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIEventListener), Member = "Get")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	protected override void OnStart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "LocalToValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected override float LocalToValue(Vector2 localPos)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIProgressBar), Member = "SetThumbPosition")]
	[Calls(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void ForceUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public UIScrollBar()
	{
	}
}
