using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Harvest : MonoBehaviour
{
	public GearItem[] m_YieldGear;

	public int[] m_YieldGearUnits;

	public ToolsItem[] m_RequiredTools;

	public SkillType m_AppliedSkillType;

	public int m_DurationMinutes;

	public string m_Audio;

	public float m_GunpowderYield;

	[CallerCount(Count = 0)]
	public bool RequiresTool()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public Harvest()
	{
	}
}
