using Cpp2ILInjected.CallAnalysis;

internal class SnowfallRecord
{
	private static SnowfallRecordSaveDataProxy m_SnowfallRecordSaveDataProxy;

	public float m_CurrentSnowDepth;

	public float m_OutOfSceneRateScalar;

	[CallerCount(Count = 0)]
	public SnowfallRecord(string sceneName, float outOfSceneRateScalar)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SnowfallManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowfallManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}
}
