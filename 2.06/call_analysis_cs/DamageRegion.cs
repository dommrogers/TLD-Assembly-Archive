using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class DamageRegion : IComparable
{
	public BodyPart m_bodyPart;

	public float m_DamageScale;

	public float m_DamageScaleForRevolver;

	public int m_BleedOutMinutes;

	public int m_BleedOutMinutesForArrow;

	public int m_BleedOutMinutesForFlareGunRound;

	public int m_BleedOutMinutesForRevolver;

	public int m_ChanceKill;

	public int m_ChanceKillForRevolver;

	public bool m_DoNotBleedOut;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "CompareTo")]
	[CallsUnknownMethods(Count = 6)]
	public int CompareTo(object obj)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public DamageRegion()
	{
	}
}
