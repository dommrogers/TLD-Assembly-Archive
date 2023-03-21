using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class Feat_NightWalker : Feat
{
	public float m_FatigueScaleDayMultiplier;

	public float m_FatigueScaleNightMultiplier;

	private static Feat_NightWalkerSaveData m_Feat_NightWalkerSaveData;

	private bool m_Unlocked;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	public float GetFatigueScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ValidateSaveData(string text)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool IsUnlocked()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public override float GetNormalizedProgress()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[CallerCount(Count = 0)]
	public Feat_NightWalker()
	{
	}
}
