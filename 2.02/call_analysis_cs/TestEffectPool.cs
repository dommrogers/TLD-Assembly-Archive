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
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EffectPool<>), Member = "LoadEffects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(EffectPool<>), Member = "SpawnUntilParticlesDone")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(EffectPool<>), Member = "LoadEffects")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 24)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public TestEffectPool()
	{
	}
}
