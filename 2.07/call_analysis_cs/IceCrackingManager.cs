using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class IceCrackingManager : MonoBehaviour
{
	public Vector3 m_EnteredWarningPosition;

	public float m_ConditionLossOnFallThrough;

	public float m_FadeOutSeconds;

	public float m_StayFadedOutSeconds;

	public float m_FadeInSeconds;

	public Vector3 m_FarDecalScale;

	public Vector3 m_MediumDecalScale;

	public Vector3 m_CloseDecalScale;

	public Vector3 m_CritDecalScale;

	private PanelReference<Panel_HUD> m_HUD;

	public float m_FellInRecentlyTimer;

	public BreakableIce m_BreakableIce;

	private float m_FadeInTimeSeconds;

	private float m_FadeOutTimeSeconds;

	private float m_CurrentVolume;

	private int m_NumTriggersInside;

	private int m_NumFallTriggersInside;

	private uint m_IceCrackingSoundID;

	private List<IceCrackingTrigger> m_IceFallTriggers;

	private Vector3 m_LastSafeLocation;

	private Vector3 m_RespawnLocation;

	private float m_TrackLocationTimer;

	private bool m_ShowingWeakIceLabel;

	private Collider[] m_RespawnColliders;

	private int m_AnimParameter_ShowThinIceIndicator;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(IceCrackingManager), Member = "UpdateTrackLocation")]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void EnterIceCrackingTrigger(string audioID, GameObject go, float fadeInSeconds)
	{
	}

	[CallerCount(Count = 0)]
	public void ExitIceCrackingTrigger(float fadeOutSeconds)
	{
	}

	[CallerCount(Count = 0)]
	public void EnterFallTrigger()
	{
	}

	[CallerCount(Count = 0)]
	public void ExitFallTrigger()
	{
	}

	[CallerCount(Count = 0)]
	public void ExitAllTriggers()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsInsideTrigger()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsInsideFallTrigger()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Register(IceCrackingTrigger trigger)
	{
	}

	[CallerCount(Count = 0)]
	public bool FellInRecently()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	public IceCrackingTrigger FindNearestFallTrigger(Vector3 pos)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(IceCrackingTrigger), Member = "Overlaps")]
	public bool OverlapsFallTrigger(Collider c, float ignoreDistance)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	public float GetDistToClosestFallTrigger(Vector3 pos)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "FallInWater")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BreakableIce), Member = "IsInDangerOfFallingIn")]
	public Vector3 GetRespawnLocation()
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public void SetBreakableIce(BreakableIce bi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public bool DisableWeakIce()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateHUDWarning()
	{
	}

	[CalledBy(Type = typeof(IceCrackingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BreakableIce), Member = "IsInDangerOfFallingIn")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void UpdateTrackLocation()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public IceCrackingManager()
	{
	}
}
