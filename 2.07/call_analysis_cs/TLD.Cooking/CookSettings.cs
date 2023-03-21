using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Cooking;

public class CookSettings : ScriptableObject
{
	public float m_MinutesToBoilWaterPerLiter;

	public float m_MinutesToMeltSnowPerLiter;

	public float m_MinutesToPurifyPerLiter;

	public float m_MinutesReadyTimeBoilingWater;

	public float m_MinutesGraceTimeInterruptedCooking;

	public AK.Wwise.Event m_MeltAndBoilAudio;

	public AK.Wwise.Event m_PutSnowInPotAudio;

	public AK.Wwise.Event m_PutWaterInPotAudio;

	public Color m_CookingHoverTextColor;

	public Color m_ReadyHoverTextColor;

	public Color m_RuinedHoverTextColor;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public CookSettings()
	{
	}
}
