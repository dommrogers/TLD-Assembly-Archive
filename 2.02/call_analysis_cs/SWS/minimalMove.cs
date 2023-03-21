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

public class minimalMove : MonoBehaviour
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

	private sealed class _003CMove_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public minimalMove _003C_003E4__this;

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

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003CMove_003Ed__25(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(minimalMove), Member = "MoveToPath")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(minimalMove), Member = "CreateTween")]
		[CallsUnknownMethods(Count = 5)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CMoveToPath_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public minimalMove _003C_003E4__this;

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
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CMoveToPath_003Ed__26(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(ABSTweenComponent), Member = "WaitForCompletion")]
		[CallsUnknownMethods(Count = 23)]
		[Calls(Type = typeof(Tweener), Member = "UsePartialPath")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[CallsDeduplicatedMethods(Count = 7)]
		[Calls(Type = typeof(minimalMove), Member = "CreateTween")]
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

	public PathManager pathContainer;

	public PathType pathType;

	public bool onStart;

	public bool moveToPath;

	public bool closeLoop;

	public OrientToPathType orientToPath;

	public float lookAhead;

	public TimeValue timeValue;

	public float speed;

	public EaseType easeType;

	public AnimationCurve animEaseType;

	public LoopType loopType;

	public Vector3[] waypoints;

	public bool repeat;

	public Axis lockAxis;

	public Axis lockPosition;

	public Tweener tween;

	private TweenParms tParms;

	private PlugVector3Path plugPath;

	private float originSpeed;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(minimalMove), Member = "SetPath")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(minimalMove), Member = "Move")]
	[Calls(Type = typeof(minimalMove), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	public void StartMove()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(minimalMove), Member = "StartMove")]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private IEnumerator Move()
	{
		return null;
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(_003CMove_003Ed__25), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator MoveToPath()
	{
		return null;
	}

	[CalledBy(Type = typeof(minimalMove), Member = "ReachedEnd")]
	[CalledBy(Type = typeof(_003CMove_003Ed__25), Member = "MoveNext")]
	[Calls(Type = typeof(HOTween), Member = "To")]
	[CallsUnknownMethods(Count = 35)]
	[CalledBy(Type = typeof(_003CMoveToPath_003Ed__26), Member = "MoveNext")]
	[Calls(Type = typeof(TweenParms), Member = "Ease")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TweenParms), Member = "Loops")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TweenParms), Member = "Ease")]
	[Calls(Type = typeof(TweenParms), Member = "Prop")]
	[Calls(Type = typeof(TweenParms), Member = ".ctor")]
	private void CreateTween()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Reverse")]
	[Calls(Type = typeof(minimalMove), Member = "CreateTween")]
	[CallsUnknownMethods(Count = 3)]
	private void ReachedEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(minimalMove), Member = "Stop")]
	[Calls(Type = typeof(minimalMove), Member = "StartMove")]
	public void SetPath(PathManager newPath)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(minimalMove), Member = "ResetMove")]
	[CalledBy(Type = typeof(minimalMove), Member = "SetPath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(minimalMove), Member = "StartMove")]
	[CallerCount(Count = 3)]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(minimalMove), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	public void ResetMove(bool reposition)
	{
	}

	[Calls(Type = typeof(ABSTweenComponent), Member = "OnPause")]
	[CallerCount(Count = 0)]
	public void Pause()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Resume()
	{
	}

	[CallerCount(Count = 0)]
	public void ChangeSpeed(float value)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public minimalMove()
	{
	}
}
