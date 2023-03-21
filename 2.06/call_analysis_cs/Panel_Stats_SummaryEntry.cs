using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Stats_SummaryEntry : MonoBehaviour
{
	public UISprite m_Sprite_Icon;

	public UILabel m_Label_Value;

	public UILabel m_Label_Title;

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Panel_Stats_SummaryEntry()
	{
	}
}
