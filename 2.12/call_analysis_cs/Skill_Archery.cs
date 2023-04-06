using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class Skill_Archery : Skill
{
	public int[] m_CriticalHitChanceIncrease;

	public int[] m_DamageIncrease;

	public int[] m_ConditionDegradeOnUseReduction;

	public int[] m_SwayReduction;

	public int[] m_BleedOutTimeReduction;

	public int m_LevelWhereCanFireFromCrouch;

	private static Skill_ArcherySaveData m_Skill_ArcherySaveData;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetCriticalHitChanceScale()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public float GetArcheryDamageScale()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public float GetConditionDegradeScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetSwayScale()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetBleedOutTimeScale()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public bool CanFireBowWhileCrouched()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 2)]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = ".ctor")]
	public Skill_Archery()
	{
	}
}
