using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class PackManagerDataProxy
{
	public string m_LeaderGuid;

	public float m_Time;

	public List<string> m_MemberGuids;

	public int m_FormationCount;

	public float m_PackMoraleModifier;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public PackManagerDataProxy()
	{
	}
}
