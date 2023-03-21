using Cpp2ILInjected.CallAnalysis;

public class SkillsManagerSaveData
{
	public string m_Skill_FirestartingSerialized;

	public string m_Skill_CarcassHarvestingSerialized;

	public string m_Skill_CookingSerialized;

	public string m_Skill_IceFishingSerialized;

	public string m_Skill_RifleSerialized;

	public string m_Skill_ArcherySerialized;

	public string m_Skill_ClothingRepairSerialized;

	public string m_Skill_RevolverSerialized;

	public string m_Skill_GunsmithingSerialized;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SkillsManagerSaveData()
	{
	}
}
