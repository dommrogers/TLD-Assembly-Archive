using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UISlider : UIProgressBar
{
	private enum Direction
	{
		Horizontal,
		Vertical,
		Upgraded
	}

	private Transform foreground;

	private float rawValue;

	private Direction direction;

	protected bool mInverted;

	public float sliderValue
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 30)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
		set
		{
		}
	}

	public bool inverted
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void Upgrade()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIEventListener), Member = "Get")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(UIScrollBar), Member = "OnStart")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIEventListener), Member = "Get")]
	protected override void OnStart()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnPressBackground(GameObject go, bool isPressed)
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
	[CallerCount(Count = 0)]
	protected void OnDragBackground(GameObject go, Vector2 delta)
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected void OnPressForeground(GameObject go, bool isPressed)
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallerCount(Count = 0)]
	protected void OnDragForeground(GameObject go, Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	public void OnKey(KeyCode key)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UISlider()
	{
	}
}
