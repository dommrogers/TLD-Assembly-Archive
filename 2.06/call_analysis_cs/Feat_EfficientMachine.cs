using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class Feat_EfficientMachine : Feat
{
	public int m_NumDaysRequired;

	public int m_CalorieReductionBenefit;

	private static float m_ElapsedHours;

	private static float m_HoursAccumulator;

	private static Feat_EfficientMachineSaveData m_Feat_EfficientMachineSaveData;

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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	public float ReduceCaloriesScale()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public void IncrementElapsedHours(float hours)
	{
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public override string GetDescription()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	public override string GetShortDescription()
	{
		return null;
	}

	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public override string GetBonusDescription()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsUnlocked()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override float GetNormalizedProgress()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Feat_EfficientMachine()
	{
	}
}
