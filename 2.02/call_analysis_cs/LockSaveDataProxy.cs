using Cpp2ILInjected.CallAnalysis;

public class LockSaveDataProxy
{
	public LockState m_LockStateProxy;

	public bool m_AttemptedToOpen;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public LockSaveDataProxy()
	{
	}
}
