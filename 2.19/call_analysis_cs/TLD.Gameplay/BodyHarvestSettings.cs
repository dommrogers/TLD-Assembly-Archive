using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay;

public class BodyHarvestSettings : ScriptableObject
{
	public float m_HarvestTimeSeconds;

	public string m_RequiredQuarterToolLocID;

	public int m_HarvestMeatMinutesPerKG;

	public int m_HarvestFrozenMeatMinutesPerKG;

	public int m_HarvestHideMinutesPerUnit;

	public int m_HarvestGutMinutesPerUnit;

	public string m_NoToolSpriteName;

	public Color m_NoToolSpriteColor;

	public Vector3 m_NoToolSpriteSize;

	public Color m_HighConditionColor;

	public string m_IconAccelerateTime;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public BodyHarvestSettings()
	{
	}
}
