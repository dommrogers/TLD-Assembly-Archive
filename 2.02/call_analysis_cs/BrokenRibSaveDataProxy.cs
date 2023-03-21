using Cpp2ILInjected.CallAnalysis;

public class BrokenRibSaveDataProxy
{
	public string[] m_CausesLocIDs;

	public int[] m_Locations;

	public int[] m_PainKillersTaken;

	public int[] m_BandagesApplied;

	public float[] m_ElapsedRestList;

	public float[] m_NumHoursRestForCureList;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public BrokenRibSaveDataProxy()
	{
	}
}
