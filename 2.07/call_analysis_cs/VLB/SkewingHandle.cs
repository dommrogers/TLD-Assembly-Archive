using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public class SkewingHandle : MonoBehaviour
{
	private sealed class _003CCoUpdate_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkewingHandle _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		public _003CCoUpdate_003Ed__8(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SkewingHandle), Member = "CanSetSkewingVector")]
		[Calls(Type = typeof(SkewingHandle), Member = "SetSkewingVector")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public VolumetricLightBeam volumetricLightBeam;

	public bool shouldUpdateEachFrame;

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool IsAttachedToSelf()
	{
		return default(bool);
	}

	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(_003CCoUpdate_003Ed__8), Member = "MoveNext")]
	[CalledBy(Type = typeof(SkewingHandle), Member = "CanUpdateEachFrame")]
	[CalledBy(Type = typeof(SkewingHandle), Member = "ShouldUpdateEachFrame")]
	[CalledBy(Type = typeof(SkewingHandle), Member = "OnEnable")]
	[CalledBy(Type = typeof(SkewingHandle), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanSetSkewingVector()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SkewingHandle), Member = "CanSetSkewingVector")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool CanUpdateEachFrame()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkewingHandle), Member = "CanSetSkewingVector")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldUpdateEachFrame()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkewingHandle), Member = "CanSetSkewingVector")]
	[Calls(Type = typeof(SkewingHandle), Member = "SetSkewingVector")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SkewingHandle), Member = "CanSetSkewingVector")]
	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CCoUpdate_003Ed__8))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator CoUpdate()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(_003CCoUpdate_003Ed__8), Member = "MoveNext")]
	[CalledBy(Type = typeof(SkewingHandle), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 5)]
	private void SetSkewingVector()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SkewingHandle()
	{
	}
}
