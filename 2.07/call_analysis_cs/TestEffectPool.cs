using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TestEffectPool : MonoBehaviour
{
	public ArrowImpactEffectPool m_ArrowImpactEffectPool;

	public BulletImpactEffectPool m_BulletImpactEffectPool;

	private float m_time;

	private EffectPool<ArrowImpactEffectType>.EffectHandle[] m_ArrowImpactEffects;

	private int m_EffectIndex;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 13)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	public TestEffectPool()
	{
	}
}
