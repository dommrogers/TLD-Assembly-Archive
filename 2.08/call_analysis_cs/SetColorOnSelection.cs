using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SetColorOnSelection : MonoBehaviour
{
	private UIWidget mWidget;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	public void SetSpriteBySelection()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SetColorOnSelection()
	{
	}
}
