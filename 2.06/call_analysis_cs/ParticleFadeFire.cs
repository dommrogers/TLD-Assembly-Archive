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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void Start()
	{
	}

	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ParticleFadeFire()
	{
	}
}
