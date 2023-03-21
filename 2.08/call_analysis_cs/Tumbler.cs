using Cpp2ILInjected.CallAnalysis;

public class Tumbler
{
	public int m_DialNumber;

	public TumblerState m_State;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Tumbler()
	{
	}
}
