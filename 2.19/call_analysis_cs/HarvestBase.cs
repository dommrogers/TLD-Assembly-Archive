using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using UnityEngine;

public abstract class HarvestBase : MonoBehaviour
{
	public SkillType m_AppliedSkillType;

	public int m_DurationMinutes;

	public string m_Audio;

	public float m_GunpowderYield;

	public ToolsItem[] m_RequiredTools;

	public PowderType[] m_YieldPowder;

	public float[] m_YieldPowderKilograms;

	public abstract int YieldCount { get; }

	public abstract GearItem GetPrefab(int index);

	public abstract int GetAmount(int index);

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool RequiresTool()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected HarvestBase()
	{
	}
}
