using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class PackManagerDataProxy
{
	public string m_LeaderGuid;

	public float m_Time;

	public List<string> m_MemberGuids;

	public int m_FormationCount;

	public float m_PackMoraleModifier;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PackManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	public PackManagerDataProxy()
	{
	}
}
