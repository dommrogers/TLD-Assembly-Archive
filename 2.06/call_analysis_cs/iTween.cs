using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class iTween : MonoBehaviour
{
	private delegate float EasingFunction(float start, float end, float value);

	private delegate void ApplyTween();

	public enum EaseType
	{
		easeInQuad,
		easeOutQuad,
		easeInOutQuad,
		easeInCubic,
		easeOutCubic,
		easeInOutCubic,
		easeInQuart,
		easeOutQuart,
		easeInOutQuart,
		easeInQuint,
		easeOutQuint,
		easeInOutQuint,
		easeInSine,
		easeOutSine,
		easeInOutSine,
		easeInExpo,
		easeOutExpo,
		easeInOutExpo,
		easeInCirc,
		easeOutCirc,
		easeInOutCirc,
		linear,
		spring,
		easeInBounce,
		easeOutBounce,
		easeInOutBounce,
		easeInBack,
		easeOutBack,
		easeInOutBack,
		easeInElastic,
		easeOutElastic,
		easeInOutElastic,
		punch
	}

	public enum LoopType
	{
		none,
		loop,
		pingPong
	}

	public enum NamedValueColor
	{
		_Color,
		_SpecColor,
		_Emission,
		_ReflectColor
	}

	public static class Defaults
	{
		public static float time;

		public static float delay;

		public static NamedValueColor namedColorValue;

		public static LoopType loopType;

		public static EaseType easeType;

		public static float lookSpeed;

		public static bool isLocal;

		public static Space space;

		public static bool orientToPath;

		public static Color color;

		public static float updateTimePercentage;

		public static float updateTime;

		public static int cameraFadeDepth;

		public static float lookAhead;

		public static bool useRealTime;

		public static Vector3 up;
	}

	private class CRSpline
	{
		public Vector3[] pts;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Copy")]
		[CallsUnknownMethods(Count = 1)]
		public CRSpline(Vector3[] pts)
		{
		}

		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(iTween), Member = "ApplyMoveToPathTargets")]
		[CalledBy(Type = typeof(iTween), Member = "ApplyMoveToPathTargets")]
		[CalledBy(Type = typeof(iTween), Member = "ApplyMoveToPathTargets")]
		[CallerCount(Count = 3)]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	private sealed class _003CTweenDelay_003Ed__144 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public iTween _003C_003E4__this;

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

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CTweenDelay_003Ed__144(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(iTween), Member = "TweenStart")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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

	private sealed class _003CTweenRestart_003Ed__146 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public iTween _003C_003E4__this;

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
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		public _003CTweenRestart_003Ed__146(int _003C_003E1__state)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(iTween), Member = "TweenStart")]
		[CallsUnknownMethods(Count = 7)]
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

	private sealed class _003CStart_003Ed__228 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public iTween _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(Count = 44)]
			[DebuggerHidden]
			[DeduplicatedMethod]
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

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public _003CStart_003Ed__228(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(iTween), Member = "TweenStart")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallsUnknownMethods(Count = 5)]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public static ArrayList tweens;

	public string id;

	public string type;

	public string method;

	public EaseType easeType;

	public float time;

	public float delay;

	public LoopType loopType;

	public bool isRunning;

	public bool isPaused;

	public string _name;

	private float runningTime;

	private float percentage;

	private float delayStarted;

	private bool kinematic;

	private bool isLocal;

	private bool loop;

	private bool reverse;

	private bool wasPaused;

	private bool physics;

	private Hashtable tweenArguments;

	private Space space;

	private EasingFunction ease;

	private ApplyTween apply;

	private AudioSource audioSource;

	private Vector3[] vector3s;

	private Vector2[] vector2s;

	private Color[,] colors;

	private float[] floats;

	private Rect[] rects;

	private CRSpline path;

	private Vector3 preUpdate;

	private Vector3 postUpdate;

	private NamedValueColor namedcolorvalue;

	private float lastRealTime;

	private bool useRealTime;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "MoveBy")]
	public static void Init(GameObject target)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "ColorFrom")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "ColorFrom")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Calls(Type = typeof(iTween), Member = "ColorTo")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[CallsUnknownMethods(Count = 17)]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "ColorTo")]
	[CallerCount(Count = 1)]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTween), Member = "FadeFrom")]
	[CalledBy(Type = typeof(iTween), Member = "FadeFrom")]
	[CalledBy(Type = typeof(iTween), Member = "ColorFrom")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 39)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "ColorFrom")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CalledBy(Type = typeof(iTween), Member = "FadeTo")]
	[CalledBy(Type = typeof(iTween), Member = "FadeTo")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(iTween), Member = "ColorTo")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CalledBy(Type = typeof(iTween), Member = "ColorTo")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 42)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 1)]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(iTween), Member = "Init")]
	[CallerCount(Count = 1)]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsUnknownMethods(Count = 1)]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Calls(Type = typeof(iTween), Member = "GenerateScaleAddTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateScaleByTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateScaleToTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateRectTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateColorTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateVector3Targets")]
	[Calls(Type = typeof(iTween), Member = "GenerateVector2Targets")]
	[Calls(Type = typeof(iTween), Member = "GenerateFloatTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GeneratePunchPositionTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GeneratePunchScaleTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateMoveToTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateMoveByTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateColorToTargets")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(iTween), Member = "TweenStart")]
	[CallsUnknownMethods(Count = 117)]
	[Calls(Type = typeof(iTween), Member = "GeneratePunchRotationTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateAudioToTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateStabTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateLookToTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateRotateAddTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateRotateByTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateShakePositionTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateShakeScaleTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateShakeRotationTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateRotateToTargets")]
	private void GenerateTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void GenerateRectTargets()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 5)]
	private void GenerateColorTargets()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void GenerateVector3Targets()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	private void GenerateVector2Targets()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	private void GenerateFloatTargets()
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 31)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 28)]
	private void GenerateColorToTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void GenerateAudioToTargets()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(AudioSource), Member = "set_volume")]
	[Calls(Type = typeof(AudioSource), Member = "set_playOnAwake")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	private void GenerateStabTargets()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void GenerateLookToTargets()
	{
	}

	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 18)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	private void GenerateMoveToPathTargets()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 15)]
	[CallsDeduplicatedMethods(Count = 21)]
	private void GenerateMoveToTargets()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 18)]
	private void GenerateMoveByTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	private void GenerateScaleToTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void GenerateScaleByTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 10)]
	private void GenerateScaleAddTargets()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
	private void GenerateRotateToTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 12)]
	private void GenerateRotateAddTargets()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	private void GenerateRotateByTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 1)]
	private void GenerateShakePositionTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	private void GenerateShakeScaleTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 10)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 1)]
	private void GenerateShakeRotationTargets()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 12)]
	private void GeneratePunchPositionTargets()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 8)]
	private void GeneratePunchRotationTargets()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	private void GeneratePunchScaleTargets()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	private void ApplyRectTargets()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void ApplyColorTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void ApplyVector3Targets()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void ApplyVector2Targets()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void ApplyFloatTargets()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 20)]
	private void ApplyColorToTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AudioSource), Member = "set_volume")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void ApplyAudioToTargets()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void ApplyStabTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(CRSpline), Member = "Interp")]
	[Calls(Type = typeof(CRSpline), Member = "Interp")]
	[Calls(Type = typeof(CRSpline), Member = "Interp")]
	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	private void ApplyMoveToPathTargets()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 19)]
	private void ApplyMoveToTargets()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 0)]
	private void ApplyMoveByTargets()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	private void ApplyScaleToTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	private void ApplyLookToTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsUnknownMethods(Count = 23)]
	[CallerCount(Count = 0)]
	private void ApplyRotateToTargets()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 14)]
	private void ApplyRotateAddTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 26)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void ApplyShakePositionTargets()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	private void ApplyPunchRotationTargets()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "punch")]
	private void ApplyPunchScaleTargets()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[IteratorStateMachine(typeof(_003CTweenDelay_003Ed__144))]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Calls(Type = typeof(iTween), Member = "GenerateTargets")]
	[CalledBy(Type = typeof(_003CTweenRestart_003Ed__146), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CTweenDelay_003Ed__144), Member = "MoveNext")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "ConflictCheck")]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(_003CStart_003Ed__228), Member = "MoveNext")]
	private void TweenStart()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[IteratorStateMachine(typeof(_003CTweenRestart_003Ed__146))]
	[CallerCount(Count = 0)]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[CalledBy(Type = typeof(iTween), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "Update")]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void TweenUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(iTween), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "Update")]
	[CalledBy(Type = typeof(iTween), Member = "Update")]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(iTween), Member = "FixedUpdate")]
	private void TweenComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	private void TweenLoop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "FloatUpdate")]
	[Calls(Type = typeof(iTween), Member = "FloatUpdate")]
	[Calls(Type = typeof(iTween), Member = "FloatUpdate")]
	[Calls(Type = typeof(iTween), Member = "FloatUpdate")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(iTween), Member = "RectUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "RectUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "RectUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "RectUpdate")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Calls(Type = typeof(iTween), Member = "ColorUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(iTween), Member = "FadeUpdate")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(iTween), Member = "FadeUpdate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[CallsUnknownMethods(Count = 78)]
	[CalledBy(Type = typeof(iTween), Member = "ColorUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "ColorUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "FadeUpdate")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "ColorUpdate")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "ColorUpdate")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CalledBy(Type = typeof(iTween), Member = "AudioUpdate")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 2)]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "AudioUpdate")]
	[CallsUnknownMethods(Count = 25)]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 25)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CalledBy(Type = typeof(iTween), Member = "RotateUpdate")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "RotateUpdate")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CalledBy(Type = typeof(iTween), Member = "ScaleUpdate")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[CallerCount(Count = 2)]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Hash")]
	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "ScaleUpdate")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Calls(Type = typeof(iTween), Member = "LookUpdate")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 37)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(iTween), Member = "MoveUpdate")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(iTween), Member = "MoveUpdate")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CalledBy(Type = typeof(iTween), Member = "MoveUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "LookUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "LateUpdate")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(iTween), Member = "LookUpdate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsUnknownMethods(Count = 4)]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 0)]
	public static Texture2D CameraTexture(Color color)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[CallerCount(Count = 0)]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[CallerCount(Count = 0)]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[CallerCount(Count = 0)]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallerCount(Count = 0)]
	public static void DrawLine(Vector3[] line)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void DrawLine(Transform[] line)
	{
	}

	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallerCount(Count = 0)]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallerCount(Count = 0)]
	public static void DrawPath(Vector3[] path)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallerCount(Count = 0)]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	public static void DrawPath(Transform[] path)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallerCount(Count = 0)]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsUnknownMethods(Count = 3)]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	public static void Resume(GameObject target)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static void Resume(GameObject target, string type)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 24)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[CallsDeduplicatedMethods(Count = 5)]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void Resume()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	public static void Resume(string type)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	public static void Pause(GameObject target)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[CallsUnknownMethods(Count = 16)]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Pause(GameObject target, string type)
	{
	}

	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	public static void Pause()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public static void Pause(string type)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static int Count()
	{
		return default(int);
	}

	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 4)]
	public static int Count(string type)
	{
		return default(int);
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	public static void Stop()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public static void Stop(string type)
	{
	}

	[Calls(Type = typeof(iTween), Member = "StopByName")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	public static void StopByName(string name)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	public static void Stop(GameObject target)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CallsUnknownMethods(Count = 16)]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CalledBy(Type = typeof(iTweenEvent), Member = "Stop")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[CallerCount(Count = 2)]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Stop")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 24)]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "StopByName")]
	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[CallsUnknownMethods(Count = 20)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "FadeTo")]
	[CalledBy(Type = typeof(iTween), Member = "ColorUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "AudioUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "RotateUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "ScaleUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "MoveUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "LookUpdate")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(iTween), Member = "FadeFrom")]
	[CalledBy(Type = typeof(iTween), Member = "FadeUpdate")]
	public static Hashtable Hash(object[] args)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "RetrieveArgs")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[IteratorStateMachine(typeof(_003CStart_003Ed__228))]
	private IEnumerator Start()
	{
		return null;
	}

	[Calls(Type = typeof(iTween), Member = "TweenUpdate")]
	[Calls(Type = typeof(iTween), Member = "TweenComplete")]
	[Calls(Type = typeof(iTween), Member = "TweenComplete")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(iTween), Member = "TweenComplete")]
	[Calls(Type = typeof(iTween), Member = "TweenUpdate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "TweenComplete")]
	private void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "LookUpdate")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTweenPath), Member = "OnDrawGizmosSelected")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHelper")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 26)]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Calls(Type = typeof(Hashtable), Member = ".ctor")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 32)]
	[CallsUnknownMethods(Count = 60)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static string GenerateID()
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 32)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(iTween), Member = "GetEasingFunction")]
	[CalledBy(Type = typeof(iTween), Member = "Awake")]
	[CallsUnknownMethods(Count = 85)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void RetrieveArgs()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(iTween), Member = "RetrieveArgs")]
	[CallsUnknownMethods(Count = 162)]
	[CallsDeduplicatedMethods(Count = 13)]
	private void GetEasingFunction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdatePercentage()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "TweenStart")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(iTween), Member = "TweenComplete")]
	[CalledBy(Type = typeof(iTween), Member = "TweenComplete")]
	[CalledBy(Type = typeof(iTween), Member = "TweenUpdate")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 4)]
	private void CallBack(string callbackType)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[CalledBy(Type = typeof(iTween), Member = "TweenComplete")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateLookToTargets")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateAudioToTargets")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(iTween), Member = "ConflictCheck")]
	[CalledBy(Type = typeof(iTween), Member = "ConflictCheck")]
	[CalledBy(Type = typeof(iTween), Member = "ConflictCheck")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(iTween), Member = "ConflictCheck")]
	private void Dispose()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Component), Member = "GetComponents")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CalledBy(Type = typeof(iTween), Member = "TweenStart")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	private void ConflictCheck()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void EnableKinematic()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void DisableKinematic()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	private void ResumeDelay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "easeOutBounce")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(iTween), Member = "easeInOutBounce")]
	[CalledBy(Type = typeof(iTween), Member = "easeInOutBounce")]
	[CalledBy(Type = typeof(iTween), Member = "easeInBounce")]
	[CallerCount(Count = 3)]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Calls(Type = typeof(iTween), Member = "easeOutBounce")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "easeOutBounce")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public iTween()
	{
	}
}
