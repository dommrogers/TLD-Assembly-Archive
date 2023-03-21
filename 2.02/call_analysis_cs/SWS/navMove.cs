using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AI;

namespace SWS;

public class navMove : MonoBehaviour
{
	public enum LoopType
	{
		none,
		loop,
		pingPong,
		random
	}

	private sealed class _003CMove_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public navMove _003C_003E4__this;

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
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CMove_003Ed__18(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[CallsUnknownMethods(Count = 11)]
		[Calls(Type = typeof(navMove), Member = "NextWaypoint")]
		[Calls(Type = typeof(navMove), Member = "ReachedEnd")]
		[Calls(Type = typeof(navMove), Member = "WaitForDestination")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[CallsDeduplicatedMethods(Count = 6)]
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

	private sealed class _003CNextWaypoint_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public navMove _003C_003E4__this;

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

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CNextWaypoint_003Ed__19(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(Type = typeof(Messages), Member = "Execute")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(navMove), Member = "WaitForDestination")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(System.Number), Member = "ParseInt32")]
		[Calls(Type = typeof(string), Member = "Replace")]
		[CallsUnknownMethods(Count = 38)]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(navMove), Member = "NextWaypoint")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(navMove), Member = "WaitDelay")]
		[Calls(Type = typeof(navMove), Member = "ReachedEnd")]
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

	private sealed class _003CWaitForDestination_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public navMove _003C_003E4__this;

		private float _003Cremain_003E5__2;

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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		public _003CWaitForDestination_003Ed__20(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(NavMeshAgent), Member = "get_pathStatus")]
		[CallsUnknownMethods(Count = 7)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CWaitDelay_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public navMove _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			[DebuggerHidden]
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
		public _003CWaitDelay_003Ed__21(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
		[CallsUnknownMethods(Count = 5)]
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

	private sealed class _003CReachedEnd_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public navMove _003C_003E4__this;

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
		public _003CReachedEnd_003Ed__22(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(Messages), Member = "Execute")]
		[Calls(Type = typeof(navMove), Member = "WaitForDestination")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[CallsUnknownMethods(Count = 72)]
		[Calls(Type = typeof(navMove), Member = "WaitDelay")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(navMove), Member = "WaitDelay")]
		[Calls(Type = typeof(Messages), Member = "Execute")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Array), Member = "Copy")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(navMove), Member = "NextWaypoint")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public PathManager pathContainer;

	public int currentPoint;

	public bool onStart;

	public bool moveToPath;

	public bool closeLoop;

	public bool updateRotation;

	public RangeValue[] delays;

	public Messages messages;

	public LoopType loopType;

	public Transform[] waypoints;

	public bool repeat;

	private NavMeshAgent agent;

	private System.Random rand;

	private int rndIndex;

	private bool waiting;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(navMove), Member = "StartMove")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(navMove), Member = "Start")]
	[Calls(Type = typeof(navMove), Member = "Stop")]
	[Calls(Type = typeof(Messages), Member = "Initialize")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public void StartMove()
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator Move()
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CReachedEnd_003Ed__22), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(_003CNextWaypoint_003Ed__19), Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(_003CMove_003Ed__18), Member = "MoveNext")]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	private IEnumerator NextWaypoint()
	{
		return null;
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(_003CMove_003Ed__18), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CNextWaypoint_003Ed__19), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CReachedEnd_003Ed__22), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator WaitForDestination()
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CReachedEnd_003Ed__22), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CReachedEnd_003Ed__22), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CNextWaypoint_003Ed__19), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	private IEnumerator WaitDelay()
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CNextWaypoint_003Ed__19), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CMove_003Ed__18), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	private IEnumerator ReachedEnd()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(navMove), Member = "SetPath")]
	public void SetPath(PathManager newPath)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(navMove), Member = "Stop")]
	[Calls(Type = typeof(navMove), Member = "ResetMove")]
	[CalledBy(Type = typeof(navMove), Member = "SetPath")]
	public void SetPath(PathManager newPath, bool reset)
	{
	}

	[CalledBy(Type = typeof(navMove), Member = "SetPath")]
	[Calls(Type = typeof(navMove), Member = "Stop")]
	[CallerCount(Count = 1)]
	public void Stop()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(navMove), Member = "StartMove")]
	[CalledBy(Type = typeof(navMove), Member = "Stop")]
	[CalledBy(Type = typeof(navMove), Member = "ResetMove")]
	[CalledBy(Type = typeof(navMove), Member = "Pause")]
	[CallsUnknownMethods(Count = 1)]
	public void Stop(bool stopUpdates)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(navMove), Member = "Stop")]
	[CalledBy(Type = typeof(navMove), Member = "SetPath")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetMove(bool reposition)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(navMove), Member = "Pause")]
	public void Pause()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(navMove), Member = "Pause")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(navMove), Member = "Stop")]
	public void Pause(bool stopUpdates)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Resume()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void ChangeSpeed(float value)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void SetDelay(int index, float min, float max)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public navMove()
	{
	}
}
