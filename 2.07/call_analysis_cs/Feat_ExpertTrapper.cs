using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class Feat_ExpertTrapper : Feat
{
	public int m_NumSnaredRabbitsRequired;

	public int m_ChanceIncreaseToCatchRabbitsPercent;

	private static int s_RabbitSnaredCount;

	private static Feat_ExpertTrapperSaveData m_Feat_ExpertTrapperSaveData;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ValidateSaveData(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	public float GetRabbitChanceCaughtModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	public void IncrementRabbitSnaredCount()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public override string GetDescription()
	{
		return null;
	}

	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public override string GetShortDescription()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	public override string GetBonusDescription()
	{
		return null;
	}

	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsUnknownMethods(Count = 1)]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[CallerCount(Count = 0)]
	public Feat_ExpertTrapper()
	{
	}
}
