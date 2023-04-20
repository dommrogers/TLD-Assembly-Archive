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
			return 0f;
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	protected override void Upgrade()
	{
	}

	[CalledBy(Type = typeof(UIScrollBar), Member = "OnStart")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIEventListener), Member = "Get")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	protected override void OnStart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnPressBackground(GameObject go, bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	protected void OnDragBackground(GameObject go, Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	protected void OnPressForeground(GameObject go, bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	protected void OnDragForeground(GameObject go, Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnKey(KeyCode key)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public UISlider()
	{
	}
}
