using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ParticleStopper : MonoBehaviour
{
	private ParticleSystem m_ParticleSystem;

	private bool m_StopChildren;

	private ParticleSystemStopBehavior m_StopBehavior;

	private Action m_OnStopCompletedAction;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[CallsUnknownMethods(Count = 2)]
	public void StopWithCallback(Action onStopCompleted)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnParticleSystemStopped()
	{
	}

	[CallerCount(Count = 0)]
	public ParticleStopper()
	{
	}
}
