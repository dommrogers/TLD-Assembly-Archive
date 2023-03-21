using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class Skill_Firestarting : Skill
{
	public int m_LevelWhereTinderNotRequired;

	public int[] m_BaseSuccessChance;

	public int[] m_DurationPercentIncrease;

	public int[] m_StartPercentIncrease;

	private static Skill_FirestartingSaveData m_Skill_FirestartingSaveData;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public int GetBaseChanceSuccess()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public float GetDurationScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetStartTimeScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterialsString")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerGetTinderChoice")]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterialsString")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerHasMaterialsToStartFire")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshTinderLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	public bool TinderRequired()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = ".ctor")]
	public Skill_Firestarting()
	{
	}
}
