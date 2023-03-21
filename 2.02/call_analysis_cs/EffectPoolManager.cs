using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EffectPoolManager : MonoBehaviour
{
	private sealed class _003CStart_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EffectPoolManager _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CStart_003Ed__16(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EffectPoolManager), Member = "CreatePool")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(EffectPool<>), Member = "LoadEffects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 15)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public GameObject m_ArrowImpactEffectPoolPrefab;

	public GameObject m_BulletImpactEffectPoolPrefab;

	public GameObject m_SplashEffectPoolPrefab;

	public GameObject m_HeavyFootstepEffectPoolPrefab;

	public GameObject m_ScorchImpactEffectPoolPrefab;

	private ArrowImpactEffectPool m_ArrowImpactEffectPool;

	private BulletImpactEffectPool m_BulletImpactEffectPool;

	private SplashEffectPool m_SplashEffectPool;

	private HeavyFootstepEffectPool m_HeavyFootstepEffectPool;

	private ScorchImpactEffectPool m_ScorchImpactEffectPool;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ArrowImpactEffectPool GetArrowImpactEffectPool()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public BulletImpactEffectPool GetBulletImpactEffectPool()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	public SplashEffectPool GetSplashEffectPool()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	public HeavyFootstepEffectPool GetHeavyFootstepEffectPool()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 40)]
	public ScorchImpactEffectPool GetScorchImpactEffectPool()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(_003CStart_003Ed__16), Member = "MoveNext")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private T CreatePool<T>(GameObject effectPoolPrefab)
	{
		return default(T);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator Start()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public EffectPoolManager()
	{
	}
}
