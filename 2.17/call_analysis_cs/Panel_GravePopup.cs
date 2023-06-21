using Cpp2ILInjected.CallAnalysis;

public class Panel_GravePopup : PopupBase
{
	public UILabel m_GraveName;

	public UILabel m_GraveQuote;

	public UILabel m_GraveNumber;

	[CallerCount(Count = 0)]
	public Panel_GravePopup()
	{
	}
}
