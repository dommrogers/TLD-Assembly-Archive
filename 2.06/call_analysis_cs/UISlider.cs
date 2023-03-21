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
		[CallerCount(Count = 27)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected override void Upgrade()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIEventListener), Member = "Get")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CalledBy(Type = typeof(UIScrollBar), Member = "OnStart")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIEventListener), Member = "Get")]
	protected override void OnStart()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
	protected void OnPressForeground(GameObject go, bool isPressed)
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "ScreenToValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	protected void OnDragForeground(GameObject go, Vector2 delta)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnKey(KeyCode key)
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public UISlider()
	{
	}
}
