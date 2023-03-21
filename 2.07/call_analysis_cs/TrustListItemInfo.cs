using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class TrustListItemInfo
{
	public string m_TrustID;

	public string m_NameLocID;

	public string m_DescLocID;

	public string m_BigIconName;

	public Episode m_Episode;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public TrustListItemInfo()
	{
	}
}
