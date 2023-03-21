using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FallDamage : MonoBehaviour
{
	public float m_HeightStartDamage;

	public float m_DamagePerMeter;

	public float m_DamagePerMeterFromRope;

	public float m_MaxRopeDamagePercentage;

	public float m_FatalRopeFallHealthDropPercentage;

	public float m_ClothingDamagePerMeterFallen;

	public string m_NoDamage;

	public string m_LightDamage;

	public string m_MediumDamage;

	public string m_HeavyDamage;

	public string m_AnkleSprain;

	public string m_WristSprain;

	public string m_BloodLoss;

	public bool m_DieOnNextFall;

	public bool m_FallFromRope;

	private bool m_IgnoreDamageReduction;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FallDamage), Member = "MaybeSprainAnkle")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(FallDamage), Member = "MaybeSprainAnkle")]
	[Calls(Type = typeof(FallDamage), Member = "MaybeSprainWrist")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(FallDamage), Member = "MaybeSprainWrist")]
	public void ApplyFallDamage(float height, float damageOverride)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IgnoreDamageReduction()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	private bool MaybeSprainAnkle()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	private bool MaybeSprainWrist()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[CallsUnknownMethods(Count = 7)]
	private bool MaybeBloodLoss()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	private void ApplyClothingDamage(float fallHeight)
	{
	}

	[CallerCount(Count = 0)]
	private void ResetIgnoreDamageReduction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FallDamage()
	{
	}
}
