using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using Holoville.HOTween;
using Holoville.HOTween.Core;
using Holoville.HOTween.Plugins;
using UnityEngine;

namespace SWS;

public class splineMove : MonoBehaviour
{
	public enum OrientToPathType
	{
		none,
		to2DTopDown,
		to2DSideScroll,
		to3D
	}

	public enum TimeValue
	{
		time,
		speed
	}

	public enum LoopType
	{
		none,
		loop,
		pingPong,
		random
	}

	private sealed class _003CMove_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public splineMove _003C_003E4__this;

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
		public _003CMove_003Ed__36(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(splineMove), Member = "InitWaypoints")]
		[Calls(Type = typeof(splineMove), Member = "MoveToPath")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(splineMove), Member = "CreateTween")]
		[Calls(Type = typeof(splineMove), Member = "NextWaypoint")]
		[Calls(Type = typeof(splineMove), Member = "ReachedEnd")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
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

	private sealed class _003CMoveToPath_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public splineMove _003C_003E4__this;

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
		public _003CMoveToPath_003Ed__37(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(splineMove), Member = "CreateTween")]
		[Calls(Type = typeof(ABSTweenComponent), Member = "Play")]
		[Calls(Type = typeof(Tweener), Member = "UsePartialPath")]
		[Calls(Type = typeof(ABSTweenComponent), Member = "WaitForCompletion")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(splineMove), Member = "InitWaypoints")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 23)]
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

	private sealed class _003CNextWaypoint_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public splineMove _003C_003E4__this;

		private int _003Cpoint_003E5__2;

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
		public _003CNextWaypoint_003Ed__40(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(splineMove), Member = "ReachedEnd")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(Messages), Member = "Execute")]
		[Calls(Type = typeof(splineMove), Member = "WaitDelay")]
		[Calls(Type = typeof(ABSTweenComponent), Member = "Play")]
		[Calls(Type = typeof(Tweener), Member = "UsePartialPath")]
		[Calls(Type = typeof(ABSTweenComponent), Member = "WaitForCompletion")]
		[CallsUnknownMethods(Count = 11)]
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

	private sealed class _003CWaitDelay_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public splineMove _003C_003E4__this;

		private float _003Ctimer_003E5__2;

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
		public _003CWaitDelay_003Ed__41(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ABSTweenComponent), Member = "OnPause")]
		[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
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

	private sealed class _003CReachedEnd_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public splineMove _003C_003E4__this;

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
		public _003CReachedEnd_003Ed__42(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(splineMove), Member = "InitWaypoints")]
		[Calls(Type = typeof(splineMove), Member = "CreateTween")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		[Calls(Type = typeof(ABSTweenComponent), Member = "Play")]
		[Calls(Type = typeof(Tweener), Member = "UsePartialPath")]
		[Calls(Type = typeof(ABSTweenComponent), Member = "WaitForCompletion")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(splineMove), Member = "NextWaypoint")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 66)]
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

	public PathManager pathContainer;

	public PathType pathType;

	public int currentPoint;

	public bool onStart;

	public bool moveToPath;

	public bool closeLoop;

	public OrientToPathType orientToPath;

	public bool local;

	public float lookAhead;

	public float sizeToAdd;

	public RangeValue[] delays;

	public Messages messages;

	public TimeValue timeValue;

	public float speed;

	public EaseType easeType;

	public AnimationCurve animEaseType;

	public LoopType loopType;

	public Transform[] waypoints;

	public bool repeat;

	public Axis lockAxis;

	public Axis lockPosition;

	public Tweener tween;

	private Vector3[] wpPos;

	private TweenParms tParms;

	private PlugVector3Path plugPath;

	private System.Random rand;

	private int[] rndArray;

	private int rndIndex;

	private bool waiting;

	private float originSpeed;

	private int startingPoint;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(splineMove), Member = "StartMove")]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(_003CMove_003Ed__36), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CMoveToPath_003Ed__37), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CReachedEnd_003Ed__42), Member = "MoveNext")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void InitWaypoints()
	{
	}

	[CalledBy(Type = typeof(splineMove), Member = "Start")]
	[CalledBy(Type = typeof(splineMove), Member = "SetPath")]
	[CalledBy(Type = typeof(splineMove), Member = "SetPath")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Messages), Member = "Initialize")]
	[Calls(Type = typeof(splineMove), Member = "Stop")]
	[Calls(Type = typeof(splineMove), Member = "Move")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(splineMove), Member = "Teleport")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 29)]
	public void StartMove()
	{
	}

	[CalledBy(Type = typeof(splineMove), Member = "StartMove")]
	[CalledBy(Type = typeof(splineMove), Member = "Teleport")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator Move()
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CMove_003Ed__36), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator MoveToPath()
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CMove_003Ed__36), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CMoveToPath_003Ed__37), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CReachedEnd_003Ed__42), Member = "MoveNext")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TweenParms), Member = ".ctor")]
	[Calls(Type = typeof(TweenParms), Member = "Prop")]
	[Calls(Type = typeof(TweenParms), Member = "Loops")]
	[Calls(Type = typeof(TweenParms), Member = "Ease")]
	[Calls(Type = typeof(TweenParms), Member = "Ease")]
	[Calls(Type = typeof(HOTween), Member = "To")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 29)]
	private void CreateTween()
	{
	}

	[CalledBy(Type = typeof(_003CMove_003Ed__36), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CReachedEnd_003Ed__42), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator NextWaypoint()
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CNextWaypoint_003Ed__40), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator WaitDelay()
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CMove_003Ed__36), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CNextWaypoint_003Ed__40), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator ReachedEnd()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(splineMove), Member = "ResetMove")]
	[Calls(Type = typeof(splineMove), Member = "StartMove")]
	public void SetPath(PathManager newPath)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(splineMove), Member = "Stop")]
	[Calls(Type = typeof(splineMove), Member = "ResetMove")]
	[Calls(Type = typeof(splineMove), Member = "StartMove")]
	public void SetPath(PathManager newPath, bool reset)
	{
	}

	[CalledBy(Type = typeof(splineMove), Member = "StartMove")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(splineMove), Member = "Stop")]
	[Calls(Type = typeof(splineMove), Member = "Move")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Teleport(int index)
	{
	}

	[CalledBy(Type = typeof(splineMove), Member = "StartMove")]
	[CalledBy(Type = typeof(splineMove), Member = "SetPath")]
	[CalledBy(Type = typeof(splineMove), Member = "Teleport")]
	[CalledBy(Type = typeof(splineMove), Member = "ResetMove")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Stop()
	{
	}

	[CalledBy(Type = typeof(splineMove), Member = "SetPath")]
	[CalledBy(Type = typeof(splineMove), Member = "SetPath")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(splineMove), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public void ResetMove(bool reposition)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ABSTweenComponent), Member = "OnPause")]
	public void Pause()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Resume()
	{
	}

	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(Messages), Member = ".ctor")]
	[Calls(Type = typeof(System.Random), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public splineMove()
	{
	}
}
