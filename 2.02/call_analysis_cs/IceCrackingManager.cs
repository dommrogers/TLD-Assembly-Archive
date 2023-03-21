using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(IceCrackingManager), Member = "UpdateTrackLocation")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public bool IsInsideTrigger()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsInsideFallTrigger()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Register(IceCrackingTrigger trigger)
	{
	}

	[CallerCount(Count = 0)]
	public bool FellInRecently()
	{
		return false;
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public IceCrackingTrigger FindNearestFallTrigger(Vector3 pos)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(IceCrackingTrigger), Member = "Overlaps")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public bool OverlapsFallTrigger(Collider c, float ignoreDistance)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Collider), Member = "Raycast")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public float GetDistToClosestFallTrigger(Vector3 pos)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "FallInWater")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BreakableIce), Member = "IsInDangerOfFallingIn")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public Vector3 GetRespawnLocation()
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 19)]
	public void SetBreakableIce(BreakableIce bi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool DisableWeakIce()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateHUDWarning()
	{
	}

	[CalledBy(Type = typeof(IceCrackingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BreakableIce), Member = "IsInDangerOfFallingIn")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateTrackLocation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public IceCrackingManager()
	{
	}
}
