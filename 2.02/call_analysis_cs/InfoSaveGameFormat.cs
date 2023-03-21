using Cpp2ILInjected.CallAnalysis;

public class InfoSaveGameFormat
{
	public ExperienceModeType m_XPMode;

	public string m_Region;

	public string m_LocationOverride;

	public VoicePersona m_Persona;

	public float m_Condition;

	public float m_HoursSurvived;

	public float m_WorldExplored;

	public float m_EpisodeProgress;

	public bool m_EpisodeCompleted;

	public string m_ActiveMissionLocId;

	public string m_ActiveMissionId;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public InfoSaveGameFormat()
	{
	}
}
