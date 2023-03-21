using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIButtonKeys : UIKeyNavigation
{
	public UIButtonKeys selectOnClick;

	public UIButtonKeys selectOnUp;

	public UIButtonKeys selectOnDown;

	public UIButtonKeys selectOnLeft;

	public UIButtonKeys selectOnRight;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIButtonKeys), Member = "Upgrade")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "OnEnable")]
	protected override void OnEnable()
	{
	}

	[CalledBy(Type = typeof(UIButtonKeys), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void Upgrade()
	{
	}

	[CallerCount(Count = 0)]
	public UIButtonKeys()
	{
	}
}
