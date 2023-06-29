using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay;

public class BeachcombingBigItemSaveData
{
	public string m_Guid;

	public string m_LocationGuid;

	[NonSerialized]
	public CustomSpawnedItem m_BigSpawnedItem;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BeachcombingBigItemSaveData()
	{
	}
}
