using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class AkObstructionOcclusion : MonoBehaviour
{
	protected class ObstructionOcclusionValue
	{
		public float currentValue;

		public float targetValue;

		[CalledBy(Type = typeof(AkObstructionOcclusion), Member = "Update")]
		[Calls(Type = typeof(Mathf), Member = "Approximately")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		public bool Update(float fadeRate)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public ObstructionOcclusionValue()
		{
		}
	}

	private readonly List<AkAudioListener> listenersToRemove;

	protected readonly List<AkAudioListener> currentListenerList;

	private readonly Dictionary<AkAudioListener, ObstructionOcclusionValue> ObstructionOcclusionValues;

	protected float fadeRate;

	public float fadeTime;

	public LayerMask LayerMask;

	public float maxDistance;

	public float refreshInterval;

	private float refreshTime;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkEmitterObstructionOcclusion), Member = "Awake")]
	[CalledBy(Type = typeof(AkRoomPortalObstruction), Member = "Awake")]
	[CallsUnknownMethods(Count = 1)]
	protected void InitIntervalsAndFadeRates()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void UpdateCurrentListenerList();

	[CalledBy(Type = typeof(AkObstructionOcclusion), Member = "Update")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void UpdateObstructionOcclusionValues()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Physics), Member = "Raycast")]
	[CalledBy(Type = typeof(AkObstructionOcclusion), Member = "Update")]
	[CallsUnknownMethods(Count = 13)]
	private void CastRays()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void SetObstructionOcclusion(KeyValuePair<AkAudioListener, ObstructionOcclusionValue> ObsOccPair);

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ObstructionOcclusionValue), Member = "Update")]
	[Calls(Type = typeof(AkObstructionOcclusion), Member = "CastRays")]
	[Calls(Type = typeof(AkObstructionOcclusion), Member = "UpdateObstructionOcclusionValues")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CalledBy(Type = typeof(AkEmitterObstructionOcclusion), Member = ".ctor")]
	[CalledBy(Type = typeof(AkRoomPortalObstruction), Member = ".ctor")]
	[CallsUnknownMethods(Count = 22)]
	protected AkObstructionOcclusion()
	{
	}
}
