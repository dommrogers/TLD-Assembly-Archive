using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Feat_NightWalker : Feat
{
	public float m_FatigueScaleDayMultiplier;

	public float m_FatigueScaleNightMultiplier;

	private static Feat_NightWalkerSaveData m_Feat_NightWalkerSaveData;

	private bool m_Unlocked;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[CallsUnknownMethods(Count = 3)]
	public float GetFatigueScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ValidateSaveData(string text)
	{
	}

	[DeduplicatedMethod]
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

	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Feat_NightWalker()
	{
	}
}
