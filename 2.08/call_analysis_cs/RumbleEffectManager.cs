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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public RumbleEffectDefinition()
		{
		}
	}

	public RumbleEffectDefinition[] m_RumbleEffects;

	private static Dictionary<RumbleEffectType, RumbleEffect> m_RumbleEffectsDict;

	private static List<RumbleEffect> m_RumbleEffectList;

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateRumbleEffectManager")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public void LoadEffects()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[CallsUnknownMethods(Count = 4)]
	public void PlayEffect(RumbleEffect effect)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "StartAudioAndRumbleEffects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	public void PlayEffect(RumbleEffectType effectType)
	{
	}

	[CalledBy(Type = typeof(RumbleEffectManager), Member = "Update")]
	[CalledBy(Type = typeof(RumbleEffectManager), Member = "StopEffect")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void StopEffect(RumbleEffect effect)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RumbleEffectManager), Member = "StopEffect")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "StopAudioAndRumbleEffects")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsUnknownMethods(Count = 1)]
	public void StopEffect(RumbleEffectType effectType)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(InputManager), Member = "StopVibration")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RumbleEffectManager), Member = "StopEffect")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "SetVibration")]
	public void Update()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RumbleEffectManager()
	{
	}
}
