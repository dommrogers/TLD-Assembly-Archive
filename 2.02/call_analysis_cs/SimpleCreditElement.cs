using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SimpleCreditElement : CreditElement
{
	private UILabel m_Label;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsContentValid(string[] content, Panel_Credits panel)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public override void Populate(string[] content, Panel_Credits panel)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SimpleCreditElement()
	{
	}
}
