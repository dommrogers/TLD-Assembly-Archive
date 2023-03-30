using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RumbleEffectManager : MonoBehaviour
{
	public enum RumbleEffectType
	{
		LandingAfterFall,
		ShootingRifle,
		BreakingDownObject,
		PlayerStruggle
	}

	[Serializable]
	public class RumbleEffectDefinition
	{
		public GameObject m_PrefabObject;

		public RumbleEffectType m_EffectType;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public RumbleEffectDefinition()
		{
		}
	}

	public RumbleEffectDefinition[] m_RumbleEffects;

	private static Dictionary<RumbleEffectType, RumbleEffect> m_RumbleEffectsDict;

	private static List<RumbleEffect> m_RumbleEffectList;

	[CalledBy(Type = typeof(GameManager), Member = "InstantiateRumbleEffectManager")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void LoadEffects()
	{
	}

	[CalledBy(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void PlayEffect(RumbleEffect effect)
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "StartAudioAndRumbleEffects")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayEffect(RumbleEffectType effectType)
	{
	}

	[CalledBy(Type = typeof(RumbleEffectManager), Member = "StopEffect")]
	[CalledBy(Type = typeof(RumbleEffectManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void StopEffect(RumbleEffect effect)
	{
	}

	[CalledBy(Type = typeof(Panel_BreakDown), Member = "StopAudioAndRumbleEffects")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "StopEffect")]
	[CallsUnknownMethods(Count = 1)]
	public void StopEffect(RumbleEffectType effectType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RumbleEffectManager), Member = "StopEffect")]
	[Calls(Type = typeof(InputManager), Member = "SetVibration")]
	[Calls(Type = typeof(InputManager), Member = "StopVibration")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RumbleEffectManager()
	{
	}
}
