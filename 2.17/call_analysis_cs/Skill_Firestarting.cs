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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public int GetBaseChanceSuccess()
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetDurationScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetStartTimeScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshTinderLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterialsString")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerGetTinderChoice")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerHasMaterialsToStartFire")]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	public bool TinderRequired()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = ".ctor")]
	public Skill_Firestarting()
	{
	}
}
