using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GravePopupDefinition : PopupDefinition
{
	public LocalizedString m_GraveName;

	public LocalizedString m_GraveQuote;

	public LocalizedString m_GraveNumber;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	protected override void ConfigurePopup(GameObject go)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public GravePopupDefinition()
	{
	}
}
