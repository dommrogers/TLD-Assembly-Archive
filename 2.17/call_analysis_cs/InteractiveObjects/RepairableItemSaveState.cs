using Cpp2ILInjected.CallAnalysis;

namespace InteractiveObjects;

public class RepairableItemSaveState
{
	public string m_Guid;

	public bool m_IsRepaired;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public RepairableItemSaveState()
	{
	}
}
