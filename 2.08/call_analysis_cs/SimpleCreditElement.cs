using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SimpleCreditElement : CreditElement
{
	private UILabel m_Label;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool IsContentValid(string[] content, Panel_Credits panel)
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public override void Populate(string[] content, Panel_Credits panel)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SimpleCreditElement()
	{
	}
}
