using Cpp2ILInjected.CallAnalysis;

public class SwitchBoxSaveDataProxy
{
	public string m_Guid;

	public SwitchToggleState m_SwitchToggleState;

	public bool m_IsLocked;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public SwitchBoxSaveDataProxy()
	{
	}
}
