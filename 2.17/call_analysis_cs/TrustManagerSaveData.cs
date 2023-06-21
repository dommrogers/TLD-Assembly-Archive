using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class TrustManagerSaveData
{
	public Dictionary<string, int> m_TrustDictionary;

	public Dictionary<string, int> m_StrikesDictionary;

	public Dictionary<string, float> m_StrikeTimersDictionary;

	public Dictionary<string, string> m_NeedTrackersSerialized;

	public Dictionary<string, string> m_UnlockableTrackersSerialized;

	public Dictionary<string, float> m_TrustDecayDictionary;

	public Dictionary<string, float> m_GracePeriodTimersDictionary;

	public Dictionary<string, float> m_GracePeriodValuesDictionary;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public TrustManagerSaveData()
	{
	}
}
