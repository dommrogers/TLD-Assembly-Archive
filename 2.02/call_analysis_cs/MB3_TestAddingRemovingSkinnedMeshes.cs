using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB3_TestAddingRemovingSkinnedMeshes : MonoBehaviour
{
	private sealed class _003CTestScript_003Ed__3 : IEnumerator, IDisposable, IEnumerator<object>
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MB3_TestAddingRemovingSkinnedMeshes _003C_003E4__this;

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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CTestScript_003Ed__3(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 141)]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[CallsDeduplicatedMethods(Count = 21)]
		[CallerCount(Count = 0)]
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

	public MB3_MeshBaker meshBaker;

	public GameObject[] g;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_TestAddingRemovingSkinnedMeshes), Member = "TestScript")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MB3_TestAddingRemovingSkinnedMeshes), Member = "Start")]
	[CallerCount(Count = 1)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	private IEnumerator TestScript()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MB3_TestAddingRemovingSkinnedMeshes()
	{
	}
}
