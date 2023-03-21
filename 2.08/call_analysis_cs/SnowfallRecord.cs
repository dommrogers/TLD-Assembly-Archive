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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SnowfallManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}
}
