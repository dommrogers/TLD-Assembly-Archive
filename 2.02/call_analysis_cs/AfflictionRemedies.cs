using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class AfflictionRemedies
{
	public AfflictionRemedy m_Remedy1;

	public AfflictionRemedy m_Remedy2;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AfflictionRemedies()
	{
	}
}
