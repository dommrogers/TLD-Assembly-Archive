using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class Feat_NightWalker : Feat
{
	public float m_FatigueScaleDayMultiplier;

	public float m_FatigueScaleNightMultiplier;

	private static Feat_NightWalkerSaveData m_Feat_NightWalkerSaveData;

	private bool m_Unlocked;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[CallsUnknownMethods(Count = 2)]
	public float GetFatigueScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	public void ValidateSaveData(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsUnlocked()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[CallerCount(Count = 0)]
	public Feat_NightWalker()
	{
	}
}
