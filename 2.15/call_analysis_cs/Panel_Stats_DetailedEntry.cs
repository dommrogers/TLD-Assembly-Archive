using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Stats_DetailedEntry : MonoBehaviour
{
	public UILabel m_Label_CurrentValue;

	public UILabel m_Label_AllTimeValuePilgrim;

	public UILabel m_Label_AllTimeValueVoyageur;

	public UILabel m_Label_AllTimeValueStalker;

	public UILabel m_Label_AllTimeValueInterloper;

	public UILabel m_Label_Title;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Panel_Stats_DetailedEntry()
	{
	}
}
