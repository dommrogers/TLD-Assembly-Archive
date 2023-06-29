using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GravePopupDefinition : PopupDefinition
{
	public LocalizedString m_GraveName;

	public LocalizedString m_GraveQuote;

	public LocalizedString m_GraveNumber;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
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
