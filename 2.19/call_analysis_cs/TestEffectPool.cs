using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TestEffectPool : MonoBehaviour
{
	public ArrowImpactEffectPool m_ArrowImpactEffectPool;

	public BulletImpactEffectPool m_BulletImpactEffectPool;

	private float m_time;

	private EffectPool<ArrowImpactEffectType>.EffectHandle[] m_ArrowImpactEffects;

	private int m_EffectIndex;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectPool<>), Member = "LoadEffects")]
	[CallsUnknownMethods(Count = 1)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectPool<>), Member = "SpawnUntilParticlesDone")]
	[Calls(Type = typeof(EffectPool<>), Member = "LoadEffects")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 13)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	public TestEffectPool()
	{
	}
}
