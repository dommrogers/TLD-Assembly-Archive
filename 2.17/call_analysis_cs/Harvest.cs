using Cpp2ILInjected.CallAnalysis;

public class Harvest : HarvestBase
{
	public GearItem[] m_YieldGear;

	public int[] m_YieldGearUnits;

	public override int YieldCount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override GearItem GetPrefab(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override int GetAmount(int index)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Harvest()
	{
	}
}
