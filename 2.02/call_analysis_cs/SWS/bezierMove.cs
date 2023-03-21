using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Holoville.HOTween;
using Holoville.HOTween.Core;
using Holoville.HOTween.Plugins;
using UnityEngine;

namespace SWS;

public class bezierMove : MonoBehaviour
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
		pingPong
	}

	private sealed class _003CMove_003Ed__28 : IDisposable, IEnumerator<object>, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bezierMove _003C_003E4__this;

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
		public _003CMove_003Ed__28(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(bezierMove), Member = "InitWaypoints")]
		[Calls(Type = typeof(bezierMove), Member = "MoveToPath")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(bezierMove), Member = "CreateTween")]
		[CallsUnknownMethods(Count = 8)]
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

	private sealed class _003CMoveToPath_003Ed__29 : IEnumerator, IDisposable, IEnumerator<object>
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bezierMove _003C_003E4__this;

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
		public _003CMoveToPath_003Ed__29(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 93)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(bezierMove), Member = "InitWaypoints")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(ABSTweenComponent), Member = "WaitForCompletion")]
		[Calls(Type = typeof(Array), Member = "Copy")]
		[Calls(Type = typeof(bezierMove), Member = "CreateTween")]
		[Calls(Type = typeof(WaypointManager), Member = "SmoothCurve")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Tweener), Member = "UsePartialPath")]
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

	private sealed class _003CWait_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bezierMove _003C_003E4__this;

		public float value;

		private float _003Ctimer_003E5__2;

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
		public _003CWait_003Ed__32(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(ABSTweenComponent), Member = "OnPause")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
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

	public BezierPathManager pathContainer;

	public PathType pathType;

	public bool onStart;

	public bool moveToPath;

	public OrientToPathType orientToPath;

	public float lookAhead;

	public float sizeToAdd;

	public Messages messages;

	public TimeValue timeValue;

	public float speed;

	public EaseType easeType;

	public AnimationCurve animEaseType;

	public LoopType loopType;

	private Vector3[] waypoints;

	public Axis lockAxis;

	public Axis lockPosition;

	public Tweener tween;

	private Vector3[] wpPos;

	private TweenParms tParms;

	private PlugVector3Path plugPath;

	private float positionOnPath;

	private float originSpeed;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bezierMove), Member = "StartMove")]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(_003CMove_003Ed__28), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(_003CMoveToPath_003Ed__29), Member = "MoveNext")]
	private void InitWaypoints()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(bezierMove), Member = "Stop")]
	[Calls(Type = typeof(bezierMove), Member = "Move")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(bezierMove), Member = "Start")]
	[CalledBy(Type = typeof(bezierMove), Member = "ReachedEnd")]
	[CalledBy(Type = typeof(bezierMove), Member = "SetPath")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	public void StartMove()
	{
	}

	[CalledBy(Type = typeof(bezierMove), Member = "StartMove")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	private IEnumerator Move()
	{
		return null;
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(_003CMove_003Ed__28), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator MoveToPath()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 42)]
	[CalledBy(Type = typeof(_003CMoveToPath_003Ed__29), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CMove_003Ed__28), Member = "MoveNext")]
	[Calls(Type = typeof(HOTween), Member = "To")]
	[Calls(Type = typeof(TweenParms), Member = "Ease")]
	[CalledBy(Type = typeof(bezierMove), Member = "ReachedEnd")]
	[Calls(Type = typeof(TweenParms), Member = "Loops")]
	[Calls(Type = typeof(TweenParms), Member = "Prop")]
	[Calls(Type = typeof(TweenParms), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TweenParms), Member = "Ease")]
	private void CreateTween()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Messages), Member = "Execute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void CheckPoint()
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator Wait(float value)
	{
		return null;
	}

	[Calls(Type = typeof(bezierMove), Member = "StartMove")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(bezierMove), Member = "Stop")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bezierMove), Member = "CreateTween")]
	private void ReachedEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bezierMove), Member = "Stop")]
	[Calls(Type = typeof(bezierMove), Member = "StartMove")]
	public void SetPath(BezierPathManager newPath)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(bezierMove), Member = "StartMove")]
	[CalledBy(Type = typeof(bezierMove), Member = "ReachedEnd")]
	[CalledBy(Type = typeof(bezierMove), Member = "SetPath")]
	[CalledBy(Type = typeof(bezierMove), Member = "ResetMove")]
	[CallsUnknownMethods(Count = 1)]
	public void Stop()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(bezierMove), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Tweener), Member = "GetPlugVector3PathPlugin")]
	[Calls(Type = typeof(Holoville.HOTween.Core.Path), Member = "GetConstPathPercFromTimePerc")]
	[Calls(Type = typeof(Holoville.HOTween.Core.Path), Member = "GetPoint")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 9)]
	private void OnDrawGizmosSelected()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Messages), Member = ".ctor")]
	public bezierMove()
	{
	}
}
