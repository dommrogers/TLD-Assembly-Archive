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

	private sealed class _003CMove_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bezierMove _003C_003E4__this;

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
		public _003CMove_003Ed__28(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(bezierMove), Member = "InitWaypoints")]
		[Calls(Type = typeof(bezierMove), Member = "MoveToPath")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(bezierMove), Member = "CreateTween")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
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

	private sealed class _003CMoveToPath_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bezierMove _003C_003E4__this;

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
		public _003CMoveToPath_003Ed__29(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WaypointManager), Member = "SmoothCurve")]
		[Calls(Type = typeof(Array), Member = "Copy")]
		[Calls(Type = typeof(bezierMove), Member = "CreateTween")]
		[Calls(Type = typeof(Tweener), Member = "UsePartialPath")]
		[Calls(Type = typeof(ABSTweenComponent), Member = "WaitForCompletion")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(bezierMove), Member = "InitWaypoints")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 93)]
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
		public _003CWait_003Ed__32(int _003C_003E1__state)
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
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
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
	[CalledBy(Type = typeof(_003CMoveToPath_003Ed__29), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void InitWaypoints()
	{
	}

	[CalledBy(Type = typeof(bezierMove), Member = "Start")]
	[CalledBy(Type = typeof(bezierMove), Member = "ReachedEnd")]
	[CalledBy(Type = typeof(bezierMove), Member = "SetPath")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(bezierMove), Member = "Stop")]
	[Calls(Type = typeof(bezierMove), Member = "Move")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void StartMove()
	{
	}

	[CalledBy(Type = typeof(bezierMove), Member = "StartMove")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator Move()
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CMove_003Ed__28), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator MoveToPath()
	{
		return null;
	}

	[CalledBy(Type = typeof(bezierMove), Member = "ReachedEnd")]
	[CalledBy(Type = typeof(_003CMove_003Ed__28), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CMoveToPath_003Ed__29), Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TweenParms), Member = ".ctor")]
	[Calls(Type = typeof(TweenParms), Member = "Prop")]
	[Calls(Type = typeof(TweenParms), Member = "Loops")]
	[Calls(Type = typeof(TweenParms), Member = "Ease")]
	[Calls(Type = typeof(TweenParms), Member = "Ease")]
	[Calls(Type = typeof(HOTween), Member = "To")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 42)]
	private void CreateTween()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Messages), Member = "Execute")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void CheckPoint()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator Wait(float value)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(bezierMove), Member = "CreateTween")]
	[Calls(Type = typeof(bezierMove), Member = "Stop")]
	[Calls(Type = typeof(bezierMove), Member = "StartMove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 28)]
	private void ReachedEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bezierMove), Member = "Stop")]
	[Calls(Type = typeof(bezierMove), Member = "StartMove")]
	public void SetPath(BezierPathManager newPath)
	{
	}

	[CalledBy(Type = typeof(bezierMove), Member = "StartMove")]
	[CalledBy(Type = typeof(bezierMove), Member = "ReachedEnd")]
	[CalledBy(Type = typeof(bezierMove), Member = "SetPath")]
	[CalledBy(Type = typeof(bezierMove), Member = "ResetMove")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bezierMove), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
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
	[Calls(Type = typeof(Tweener), Member = "GetPlugVector3PathPlugin")]
	[Calls(TypeFullName = "Holoville.HOTween.Core.Path", Member = "GetConstPathPercFromTimePerc")]
	[Calls(TypeFullName = "Holoville.HOTween.Core.Path", Member = "GetPoint")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	private void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Messages), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public bezierMove()
	{
	}
}
