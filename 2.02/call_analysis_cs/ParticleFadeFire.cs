using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ParticleFadeFire : MonoBehaviour
{
	public Fire sourceFire;

	public float fullOnMinutes;

	public float fullOffMinutes;

	public List<ParticleSystem> emitters;

	public bool autoStop;

	public bool autoPlay;

	private ParticleInfo[] allPS;

	private float maxTimeSec;

	private float minTimeSec;

	private float fireTime;

	private float fadeTimeNormalized;

	private float fadeTimeDifference;

	private float fadeTimeStep;

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ParticleFadeFire()
	{
	}
}
