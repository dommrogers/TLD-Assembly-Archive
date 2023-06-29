using Cpp2ILInjected.CallAnalysis;

public class FeatsManagerSaveData
{
	public string m_Feat_BookSmartsSerialized;

	public string m_Feat_ColdFusionSerialized;

	public string m_Feat_EfficientMachineSerialized;

	public string m_Feat_FireMasterSerialized;

	public string m_Feat_FreeRunnerSerialized;

	public string m_Feat_SnowWalkerSerialized;

	public string m_Feat_ExpertTrappererialized;

	public string m_Feat_StraightToHeartSerialized;

	public string m_Feat_BlizzardWalkerSerialized;

	public string m_Feat_NightWalkerSerialized;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public FeatsManagerSaveData()
	{
	}
}
