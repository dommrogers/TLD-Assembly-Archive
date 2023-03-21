using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

internal class SnowfallRecord
{
	private static SnowfallRecordSaveDataProxy m_SnowfallRecordSaveDataProxy;

	public float m_CurrentSnowDepth;

	public float m_OutOfSceneRateScalar;

	[CallerCount(Count = 0)]
	public SnowfallRecord(string sceneName, float outOfSceneRateScalar)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowfallManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}
}
