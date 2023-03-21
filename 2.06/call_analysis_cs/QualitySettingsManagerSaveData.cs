using Cpp2ILInjected.CallAnalysis;

public class QualitySettingsManagerSaveData
{
	public Quality m_CurrentQuality;

	public QualityLevelSettings m_QualityCustom;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public QualitySettingsManagerSaveData()
	{
	}
}
