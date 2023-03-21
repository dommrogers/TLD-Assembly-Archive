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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 13)]
	public override void Populate(string[] content, Panel_Credits panel)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MultiLabelCreditElement()
	{
	}
}
