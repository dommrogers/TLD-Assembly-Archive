using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TestEffectPool : MonoBehaviour
{
	public ArrowImpactEffectPool m_ArrowImpactEffectPool;

	public BulletImpactEffectPool m_BulletImpactEffectPool;

	private float m_time;

	private EffectPool<ArrowImpactEffectType>.EffectHandle[] m_ArrowImpactEffects;

	private int m_EffectIndex;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[CallsUnknownMethods(Count = 24)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TestEffectPool()
	{
	}
}
