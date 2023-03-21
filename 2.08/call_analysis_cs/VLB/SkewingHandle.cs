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
		public _003CCoUpdate_003Ed__8(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SkewingHandle), Member = "CanSetSkewingVector")]
		[Calls(Type = typeof(SkewingHandle), Member = "SetSkewingVector")]
		[CallsUnknownMethods(Count = 1)]
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

	public VolumetricLightBeam volumetricLightBeam;

	public bool shouldUpdateEachFrame;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsAttachedToSelf()
	{
		return false;
	}

	[CalledBy(Type = typeof(_003CCoUpdate_003Ed__8), Member = "MoveNext")]
	[CalledBy(Type = typeof(SkewingHandle), Member = "CanUpdateEachFrame")]
	[CalledBy(Type = typeof(SkewingHandle), Member = "ShouldUpdateEachFrame")]
	[CalledBy(Type = typeof(SkewingHandle), Member = "OnEnable")]
	[CalledBy(Type = typeof(SkewingHandle), Member = "Start")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanSetSkewingVector()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkewingHandle), Member = "CanSetSkewingVector")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanUpdateEachFrame()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkewingHandle), Member = "CanSetSkewingVector")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldUpdateEachFrame()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkewingHandle), Member = "CanSetSkewingVector")]
	[Calls(Type = typeof(SkewingHandle), Member = "SetSkewingVector")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkewingHandle), Member = "CanSetSkewingVector")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(_003CCoUpdate_003Ed__8), Member = "MoveNext")]
	[CalledBy(Type = typeof(SkewingHandle), Member = "OnEnable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
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
