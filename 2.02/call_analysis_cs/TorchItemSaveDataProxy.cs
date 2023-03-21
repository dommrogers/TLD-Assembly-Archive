using Cpp2ILInjected.CallAnalysis;

public class TorchItemSaveDataProxy
{
	public float m_HoursPlayed;

	public TorchState m_StateProxy;

	public float m_ElapsedBurnMinutesProxy;

	public bool m_Thrown;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public TorchItemSaveDataProxy()
	{
	}
}
