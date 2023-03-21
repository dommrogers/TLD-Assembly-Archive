using Cpp2ILInjected.CallAnalysis;

public class OpenCloseSaveDataProxy
{
	public string m_Guid;

	public bool m_Open;

	public string m_LockSerialized;

	public string m_SafeSerialized;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public OpenCloseSaveDataProxy()
	{
	}
}
