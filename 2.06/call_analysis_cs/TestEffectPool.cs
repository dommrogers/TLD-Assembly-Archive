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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	public TestEffectPool()
	{
	}
}
