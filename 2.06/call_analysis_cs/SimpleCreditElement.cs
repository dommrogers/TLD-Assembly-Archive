using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SimpleCreditElement : CreditElement
{
	private UILabel m_Label;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public override void Populate(string[] content, Panel_Credits panel)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SimpleCreditElement()
	{
	}
}
