using Cpp2ILInjected.CallAnalysis;

public class WindSaveDataProxy
{
	public int m_Version;

	public WindDirection m_windDirectionProxy;

	public WindStrength m_windStrengthProxy;

	public float m_windMPHProxy;

	public bool m_FirstPhaseSetProxy;

	public float m_PhaseElapsedTODSecondsProxy;

	public float m_PhaseDurationHoursProxy;

	public float m_TransitionTimeTODSecondsProxy;

	public string m_ActiveSettingsSerialized;

	public string m_SourceSettingsSerialized;

	public string m_TargetSettingsSerialized;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public WindSaveDataProxy()
	{
	}
}
