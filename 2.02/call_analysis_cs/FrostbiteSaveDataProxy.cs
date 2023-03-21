using Cpp2ILInjected.CallAnalysis;

public class FrostbiteSaveDataProxy
{
	public int[] m_LocationsWithActiveFrostbite;

	public int[] m_LocationsWithFrostbiteRisk;

	public float[] m_LocationsCurrentFrostbiteDamage;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public FrostbiteSaveDataProxy()
	{
	}
}
