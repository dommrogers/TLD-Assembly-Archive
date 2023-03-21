using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class PackManagerDataProxy
{
	public string m_LeaderGuid;

	public float m_Time;

	public List<string> m_MemberGuids;

	public int m_FormationCount;

	public float m_PackMoraleModifier;

	[CalledBy(Type = typeof(PackManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public PackManagerDataProxy()
	{
	}
}
