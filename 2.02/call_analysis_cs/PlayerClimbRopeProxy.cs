using Cpp2ILInjected.CallAnalysis;

public class PlayerClimbRopeProxy
{
	public string m_RopeGuid;

	public float m_SplineT;

	public float m_NoStaminaTimerSeconds;

	public float m_NextSlipRollSeconds;

	public float m_NextSlipChance;

	public float m_NextFallChance;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PlayerClimbRopeProxy()
	{
	}
}
