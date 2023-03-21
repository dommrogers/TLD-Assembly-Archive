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
	[CallerCount(Count = 7)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(FallDamage), Member = "MaybeSprainAnkle")]
	[Calls(Type = typeof(FallDamage), Member = "MaybeSprainWrist")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 45)]
	public void ApplyFallDamage(float height, float damageOverride)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IgnoreDamageReduction()
	{
		return false;
	}

	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private bool MaybeSprainAnkle()
	{
		return false;
	}

	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private bool MaybeSprainWrist()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private bool MaybeBloodLoss()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
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
