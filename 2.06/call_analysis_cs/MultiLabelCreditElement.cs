using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MultiLabelCreditElement : CreditElement
{
	private UILabel[] m_Labels;

	[CallerCount(Count = 0)]
	public override bool IsContentValid(string[] content, Panel_Credits panel)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public override void Populate(string[] content, Panel_Credits panel)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public MultiLabelCreditElement()
	{
	}
}
