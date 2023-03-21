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
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 29)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		public _003CCoUpdate_003Ed__8(int _003C_003E1__state)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public VolumetricLightBeam volumetricLightBeam;

	public bool shouldUpdateEachFrame;

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public bool IsAttachedToSelf()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(_003CCoUpdate_003Ed__8), Member = "MoveNext")]
	[CalledBy(Type = typeof(SkewingHandle), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SkewingHandle), Member = "OnEnable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SkewingHandle), Member = "CanUpdateEachFrame")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(SkewingHandle), Member = "ShouldUpdateEachFrame")]
	[CallerCount(Count = 5)]
	public bool CanSetSkewingVector()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkewingHandle), Member = "CanSetSkewingVector")]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(SkewingHandle), Member = "CanSetSkewingVector")]
	[Calls(Type = typeof(SkewingHandle), Member = "SetSkewingVector")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SkewingHandle), Member = "CanSetSkewingVector")]
	[Calls(Type = typeof(SkewingHandle), Member = "CoUpdate")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SkewingHandle), Member = "Start")]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator CoUpdate()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(_003CCoUpdate_003Ed__8), Member = "MoveNext")]
	[CalledBy(Type = typeof(SkewingHandle), Member = "OnEnable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private void SetSkewingVector()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SkewingHandle()
	{
	}
}
