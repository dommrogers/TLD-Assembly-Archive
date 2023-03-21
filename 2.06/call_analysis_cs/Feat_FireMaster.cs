using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class Feat_FireMaster : Feat
{
	public int m_NumFiresRequired;

	public int m_DefaultFireStartingSkillLevel;

	private static int m_NumFiresStarted;

	private static Feat_FireMasterSaveData m_Feat_FireMasterSaveData;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ValidateSaveData(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	public int GetDefaultFireStartingSkillLevel()
	{
		return default(int);
	}

	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void IncrementFiresStarted(int count)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	public override string GetDescription()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public override string GetShortDescription()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Skill_Firestarting), Member = "Deserialize")]
	[CalledBy(Type = typeof(Skill), Member = "Start")]
	[CalledBy(Type = typeof(Fire), Member = "FireStateSet")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "SetNormalizedProgress")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "IncrementFiresStarted")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Deserialize")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	public void MaybeUpdateFireStartingSkillLevel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Feat_FireMaster()
	{
	}
}
