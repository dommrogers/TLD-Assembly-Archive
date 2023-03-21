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

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public override void Populate(string[] content, Panel_Credits panel)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MultiLabelCreditElement()
	{
	}
}
