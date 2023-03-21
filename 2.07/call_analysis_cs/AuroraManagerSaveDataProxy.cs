using Cpp2ILInjected.CallAnalysis;

public class AuroraManagerSaveDataProxy
{
	public bool m_ForceDisable;

	public bool m_ForceAuroraNextOpportunity;

	public bool m_ForceAuroraEarlyWindowAllowed;

	public bool m_ForceAuroraLateWindowAllowed;

	public float m_ForceAuroraDurationOverride;

	public bool m_IsDoingForceAurora;

	public bool m_HasForcedAuroraStarted;

	public int m_NumAurorasForSave;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public AuroraManagerSaveDataProxy()
	{
	}
}
