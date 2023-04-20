using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
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
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EffectPoolManager), Member = "CreatePool")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(EffectPool<>), Member = "LoadEffects")]
		[CallsUnknownMethods(Count = 11)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
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
	[CallerCount(Count = 4)]
	public ArrowImpactEffectPool GetArrowImpactEffectPool()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	public BulletImpactEffectPool GetBulletImpactEffectPool()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 15)]
	public SplashEffectPool GetSplashEffectPool()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	public HeavyFootstepEffectPool GetHeavyFootstepEffectPool()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 29)]
	public ScorchImpactEffectPool GetScorchImpactEffectPool()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(_003CStart_003Ed__16), Member = "MoveNext")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private T CreatePool<T>(GameObject effectPoolPrefab)
	{
		return default(T);
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__16))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public IEnumerator Start()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public EffectPoolManager()
	{
	}
}
