using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class PlayerSkillsSaveData
{
	public float m_RepairSkill;

	public float m_CleanSkill;

	public float m_SharpenSkill;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PlayerSkillsSaveData()
	{
	}
}
