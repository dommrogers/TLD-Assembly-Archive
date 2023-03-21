using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class Skill_Revolver : Skill
{
	public int[] m_CriticalHitChanceIncrease;

	public int[] m_ConditionRepairBonus;

	public int[] m_ConditionDegradeOnUseReduction;

	public int[] m_DamageIncrease;

	public int[] m_RecoilCompensation;

	public float[] m_AimAssistAngleDegrees;

	public int[] m_StruggleBonus;

	public string[] m_AimAssistTierText;

	private static Skill_RevolverSaveData m_Skill_RevolverSaveData;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCriticalHitChanceScale()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public int GetConditionRepairBonus()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(GunItem), Member = "GetRecoilYaw")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
	[CalledBy(Type = typeof(GunItem), Member = "GetRecoilPitch")]
	[CallsUnknownMethods(Count = 2)]
	public float GetRecoilScale()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetRevolverDamageScale()
	{
		return default(float);
	}

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 2)]
	public float GetConditionDegradeScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetAimAssistAngleDegrees()
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnRevolverFired")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetFleeChanceOnHitPercent")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetFleeChanceOnRevolverShotPercent")]
	[CallsUnknownMethods(Count = 2)]
	public float GetStruggleBonus()
	{
		return default(float);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[Calls(Type = typeof(Skill), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public Skill_Revolver()
	{
	}
}
