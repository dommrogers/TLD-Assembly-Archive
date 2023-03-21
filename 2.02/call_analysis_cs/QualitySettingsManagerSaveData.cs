using Cpp2ILInjected.CallAnalysis;

public class QualitySettingsManagerSaveData
{
	public Quality m_CurrentQuality;

	public QualityLevelSettings m_QualityCustom;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public QualitySettingsManagerSaveData()
	{
	}
}
