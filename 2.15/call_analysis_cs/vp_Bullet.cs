using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class vp_Bullet : MonoBehaviour
{
	public float Range;

	public float Force;

	public float Damage;

	public float Accuracy;

	public float MinDistanceForAimAssist;

	public string DamageMethodName;

	public float DamageFalloffPerMeterBeyondEffectiveRange;

	public float MinimumDamageFalloffBeyondEffectiveRange;

	public string m_ImpactAudio;

	public GunType m_GunType;

	public float m_GearImpactForce;

	public float m_GearImpactUpwardForce;

	public float m_GearImpactTorqueForce;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "RaycastWithAimAssist")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[Calls(Type = typeof(AiUtils), Member = "GetBaseAiFromObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(GearItem), Member = "ApplyForce")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[Calls(Type = typeof(LocalizedDamage), Member = "RollChanceToKill")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeOrAttackFromProjectileHit")]
	[Calls(Type = typeof(vp_DecalManager), Member = "FadeAndRemove")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 36)]
	[CallsUnknownMethods(Count = 40)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	private static BulletImpactEffectType GetImpactEffectTypeBasedOnMaterial(string tag)
	{
		return default(BulletImpactEffectType);
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(vp_Bullet), Member = "GetImpactEffectTypeBasedOnMaterial")]
	[Calls(Type = typeof(EffectPool<>), Member = "SpawnUntilParticlesDone")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 17)]
	private void SpawnImpactEffects(RaycastHit hit)
	{
	}

	[CallerCount(Count = 0)]
	public vp_Bullet()
	{
	}
}
