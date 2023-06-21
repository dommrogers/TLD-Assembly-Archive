using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.BigCarry;

public class BigCarrySystemSceneSaveData
{
	public List<BigCarrySystemItemSaveData> m_ActiveBigCarryItems;

	public List<string> m_RemovedBigCarryItems;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BigCarrySystemSceneSaveData()
	{
	}
}
