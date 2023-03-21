using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIButtonKeys : UIKeyNavigation
{
	public UIButtonKeys selectOnClick;

	public UIButtonKeys selectOnUp;

	public UIButtonKeys selectOnDown;

	public UIButtonKeys selectOnLeft;

	public UIButtonKeys selectOnRight;

	[Calls(Type = typeof(UIButtonKeys), Member = "Upgrade")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "OnEnable")]
	[CallerCount(Count = 0)]
	protected override void OnEnable()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UIButtonKeys), Member = "OnEnable")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public void Upgrade()
	{
	}

	[CallerCount(Count = 0)]
	public UIButtonKeys()
	{
	}
}
