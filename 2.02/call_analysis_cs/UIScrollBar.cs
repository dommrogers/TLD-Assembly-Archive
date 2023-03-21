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
		[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
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
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		[CalledBy(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
		[Calls(Type = typeof(EventDelegate), Member = "Execute")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(NGUITools), Member = "GetActive")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	protected override void Upgrade()
	{
	}

	[Calls(Type = typeof(UIEventListener), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UISlider), Member = "OnStart")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallerCount(Count = 0)]
	protected override void OnStart()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "LocalToValue")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	protected override float LocalToValue(Vector2 localPos)
	{
		return default(float);
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UIProgressBar), Member = "SetThumbPosition")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public override void ForceUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = ".ctor")]
	public UIScrollBar()
	{
	}
}
