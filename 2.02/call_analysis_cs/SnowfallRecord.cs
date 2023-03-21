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

	[CalledBy(Type = typeof(SnowfallManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SnowfallManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}
}
