using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
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

	private PanelReference<Panel_HUD> m_HUD;

	public bool m_DieOnNextFall;

	public bool m_FallFromRope;

	private bool m_IgnoreDamageReduction;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(FallDamage), Member = "ApplyClothingDamage")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(FallDamage), Member = "MaybeSprainWrist")]
	[Calls(Type = typeof(FallDamage), Member = "MaybeSprainAnkle")]
	[Calls(Type = typeof(FallDamage), Member = "MaybeSprainAnkle")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(FootStepSounds), Member = "MaybeLeaveFootPrint")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(CameraEffects), Member = "PainPulse")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FallDamage), Member = "MaybeSprainWrist")]
	public void ApplyFallDamage(float height, float damageOverride)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IgnoreDamageReduction()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[CallsUnknownMethods(Count = 4)]
	private bool MaybeSprainAnkle()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(CameraEffects), Member = "PainPulse")]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	private bool MaybeSprainWrist()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[CallsUnknownMethods(Count = 3)]
	private bool MaybeBloodLoss()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	private void ApplyClothingDamage(float fallHeight)
	{
	}

	[CallerCount(Count = 0)]
	private void ResetIgnoreDamageReduction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FallDamage()
	{
	}
}
