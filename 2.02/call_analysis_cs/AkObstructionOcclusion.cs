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
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Mathf), Member = "Approximately")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public bool Update(float fadeRate)
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	[CalledBy(Type = typeof(AkEmitterObstructionOcclusion), Member = "Awake")]
	[CalledBy(Type = typeof(AkRoomPortalObstruction), Member = "Awake")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void InitIntervalsAndFadeRates()
	{
	}

	protected abstract void UpdateCurrentListenerList();

	[CalledBy(Type = typeof(AkObstructionOcclusion), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	private void UpdateObstructionOcclusionValues()
	{
	}

	[CalledBy(Type = typeof(AkObstructionOcclusion), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Physics), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	private void CastRays()
	{
	}

	protected abstract void SetObstructionOcclusion(KeyValuePair<AkAudioListener, ObstructionOcclusionValue> ObsOccPair);

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AkObstructionOcclusion), Member = "UpdateObstructionOcclusionValues")]
	[Calls(Type = typeof(AkObstructionOcclusion), Member = "CastRays")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ObstructionOcclusionValue), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(AkEmitterObstructionOcclusion), Member = ".ctor")]
	[CalledBy(Type = typeof(AkRoomPortalObstruction), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	protected AkObstructionOcclusion()
	{
	}
}
