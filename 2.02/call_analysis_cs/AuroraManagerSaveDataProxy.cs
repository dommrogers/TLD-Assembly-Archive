using Cpp2ILInjected.CallAnalysis;

public class AuroraManagerSaveDataProxy
{
	public float m_NormalizedActive;

	public bool m_ForceDisable;

	public float m_HoursPlayed;

	public bool m_ForceAuroraNextOpportunity;

	public bool m_ForceAuroraEarlyWindowAllowed;

	public bool m_ForceAuroraLateWindowAllowed;

	public float m_ForceAuroraDurationOverride;

	public bool m_IsDoingForceAurora;

	public bool m_HasForcedAuroraStarted;

	public bool m_IsFullyActive;

	public float m_ElectrolyzerFadeOutStartTime;

	public float m_ElectrolyzerFadeInStartTime;

	public int m_NumAurorasForSave;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AuroraManagerSaveDataProxy()
	{
	}
}
