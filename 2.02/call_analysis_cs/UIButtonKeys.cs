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

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIButtonKeys), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public void Upgrade()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UIButtonKeys()
	{
	}
}
