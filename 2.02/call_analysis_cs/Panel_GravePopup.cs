using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_GravePopup : PopupBase
{
	public UILabel m_GraveName;

	public UILabel m_GraveQuote;

	public UILabel m_GraveNumber;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public Panel_GravePopup()
	{
	}
}
