using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	private sealed class _003ClargeNumber_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MB_DynamicAddDeleteExample _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		public _003ClargeNumber_003Ed__6(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 11)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public GameObject prefab;

	private List<GameObject> objsInCombined;

	private MB3_MultiMeshBaker mbd;

	private GameObject[] objs;

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MB_DynamicAddDeleteExample), Member = "Start")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private float GaussianValue()
	{
		return default(float);
	}

	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(MB_DynamicAddDeleteExample), Member = "GaussianValue")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003ClargeNumber_003Ed__6))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnGUI()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public MB_DynamicAddDeleteExample()
	{
	}
}
