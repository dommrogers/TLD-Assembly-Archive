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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Copy")]
		[CallsUnknownMethods(Count = 1)]
		public CRSpline(Vector3[] pts)
		{
		}

		[CallsUnknownMethods(Count = 13)]
		[CalledBy(Type = typeof(iTween), Member = "ApplyMoveToPathTargets")]
		[CalledBy(Type = typeof(iTween), Member = "ApplyMoveToPathTargets")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(iTween), Member = "ApplyMoveToPathTargets")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	private sealed class _003CTweenDelay_003Ed__144 : IEnumerator, IDisposable, IEnumerator<object>
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public iTween _003C_003E4__this;

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
		public _003CTweenDelay_003Ed__144(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 10)]
		[Calls(Type = typeof(iTween), Member = "TweenStart")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
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

	private sealed class _003CTweenRestart_003Ed__146 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public iTween _003C_003E4__this;

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
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		public _003CTweenRestart_003Ed__146(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 10)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(iTween), Member = "TweenStart")]
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

	private sealed class _003CStart_003Ed__228 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public iTween _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(Count = 29)]
			[DeduplicatedMethod]
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
		public _003CStart_003Ed__228(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(iTween), Member = "TweenStart")]
		[CallsUnknownMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(iTween), Member = "MoveBy")]
	public static void Init(GameObject target)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "ColorFrom")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "ColorTo")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTween), Member = "FadeFrom")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 44)]
	[CalledBy(Type = typeof(iTween), Member = "ColorFrom")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(iTween), Member = "ColorFrom")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 39)]
	[CallerCount(Count = 3)]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CalledBy(Type = typeof(iTween), Member = "ColorTo")]
	[CalledBy(Type = typeof(iTween), Member = "FadeTo")]
	[Calls(Type = typeof(iTween), Member = "ColorTo")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 19)]
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
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsUnknownMethods(Count = 84)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 44)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(iTween), Member = "Init")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsUnknownMethods(Count = 1)]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 10)]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 22)]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsUnknownMethods(Count = 1)]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "GenerateScaleToTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateScaleByTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateScaleAddTargets")]
	[Calls(Type = typeof(iTween), Member = "GeneratePunchPositionTargets")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "GenerateFloatTargets")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "GeneratePunchRotationTargets")]
	[CallsUnknownMethods(Count = 149)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "GenerateMoveByTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateMoveToTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "GenerateColorToTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateVector2Targets")]
	[Calls(Type = typeof(iTween), Member = "GeneratePunchScaleTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateVector3Targets")]
	[CalledBy(Type = typeof(iTween), Member = "TweenStart")]
	[Calls(Type = typeof(iTween), Member = "GenerateRectTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateColorTargets")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "GenerateAudioToTargets")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "GenerateStabTargets")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "GenerateLookToTargets")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "GenerateRotateToTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateRotateAddTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateRotateByTargets")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "GenerateShakePositionTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateShakeScaleTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateShakeRotationTargets")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 1)]
	private void GenerateTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void GenerateRectTargets()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 17)]
	private void GenerateColorTargets()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 22)]
	private void GenerateVector3Targets()
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void GenerateVector2Targets()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 22)]
	private void GenerateFloatTargets()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 34)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 128)]
	private void GenerateColorToTargets()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	private void GenerateAudioToTargets()
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(AudioSource), Member = "set_playOnAwake")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(AudioSource), Member = "set_volume")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void GenerateStabTargets()
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 100)]
	[Calls(Type = typeof(iTween), Member = "clerp")]
	[Calls(Type = typeof(iTween), Member = "clerp")]
	[Calls(Type = typeof(iTween), Member = "clerp")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void GenerateLookToTargets()
	{
	}

	[CallsUnknownMethods(Count = 77)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(iTween), Member = "PathLength")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	private void GenerateMoveToPathTargets()
	{
	}

	[CallsUnknownMethods(Count = 75)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void GenerateMoveToTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsUnknownMethods(Count = 90)]
	private void GenerateMoveByTargets()
	{
	}

	[CallsUnknownMethods(Count = 58)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void GenerateScaleToTargets()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 50)]
	private void GenerateScaleByTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 47)]
	private void GenerateScaleAddTargets()
	{
	}

	[Calls(Type = typeof(iTween), Member = "clerp")]
	[Calls(Type = typeof(iTween), Member = "clerp")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(iTween), Member = "clerp")]
	[CallsUnknownMethods(Count = 87)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void GenerateRotateToTargets()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 50)]
	private void GenerateRotateAddTargets()
	{
	}

	[CallsUnknownMethods(Count = 50)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void GenerateRotateByTargets()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 40)]
	private void GenerateShakePositionTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 34)]
	private void GenerateShakeScaleTargets()
	{
	}

	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void GenerateShakeRotationTargets()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 46)]
	private void GeneratePunchPositionTargets()
	{
	}

	[CallsUnknownMethods(Count = 40)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void GeneratePunchRotationTargets()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 37)]
	private void GeneratePunchScaleTargets()
	{
	}

	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	private void ApplyRectTargets()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallsUnknownMethods(Count = 48)]
	private void ApplyColorTargets()
	{
	}

	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	private void ApplyVector3Targets()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	private void ApplyVector2Targets()
	{
	}

	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallsUnknownMethods(Count = 18)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void ApplyFloatTargets()
	{
	}

	[CallsUnknownMethods(Count = 94)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	private void ApplyColorToTargets()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(AudioSource), Member = "set_volume")]
	[CallsUnknownMethods(Count = 23)]
	private void ApplyAudioToTargets()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void ApplyStabTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(CRSpline), Member = "Interp")]
	[Calls(Type = typeof(CRSpline), Member = "Interp")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(CRSpline), Member = "Interp")]
	[CallsUnknownMethods(Count = 33)]
	[CallerCount(Count = 0)]
	private void ApplyMoveToPathTargets()
	{
	}

	[CallsUnknownMethods(Count = 64)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 17)]
	private void ApplyMoveToTargets()
	{
	}

	[CallsUnknownMethods(Count = 66)]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	private void ApplyMoveByTargets()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallsUnknownMethods(Count = 27)]
	private void ApplyScaleToTargets()
	{
	}

	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallerCount(Count = 0)]
	private void ApplyLookToTargets()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsUnknownMethods(Count = 63)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	private void ApplyRotateToTargets()
	{
	}

	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 53)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	private void ApplyRotateAddTargets()
	{
	}

	[CallsUnknownMethods(Count = 77)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	private void ApplyShakePositionTargets()
	{
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 37)]
	private void ApplyShakeScaleTargets()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 0)]
	private void ApplyShakeRotationTargets()
	{
	}

	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[CallsUnknownMethods(Count = 66)]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "punch")]
	private void ApplyPunchPositionTargets()
	{
	}

	[CallsUnknownMethods(Count = 53)]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Calls(Type = typeof(iTween), Member = "punch")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "punch")]
	private void ApplyPunchScaleTargets()
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(_003CStart_003Ed__228), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CTweenRestart_003Ed__146), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CTweenDelay_003Ed__144), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(iTween), Member = "ConflictCheck")]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void TweenStart()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[CalledBy(Type = typeof(iTween), Member = "Update")]
	[CalledBy(Type = typeof(iTween), Member = "FixedUpdate")]
	[CallsUnknownMethods(Count = 4)]
	private void TweenUpdate()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(iTween), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "Update")]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	private void TweenComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	private void TweenLoop()
	{
	}

	[Calls(Type = typeof(iTween), Member = "FloatUpdate")]
	[Calls(Type = typeof(iTween), Member = "FloatUpdate")]
	[Calls(Type = typeof(iTween), Member = "FloatUpdate")]
	[Calls(Type = typeof(iTween), Member = "FloatUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "ColorUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "FadeUpdate")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(iTween), Member = "FadeUpdate")]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[CallsUnknownMethods(Count = 102)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CalledBy(Type = typeof(iTween), Member = "ColorUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "ColorUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "FadeUpdate")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(iTween), Member = "ColorUpdate")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "ColorUpdate")]
	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 0)]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CalledBy(Type = typeof(iTween), Member = "AudioUpdate")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Calls(Type = typeof(iTween), Member = "AudioUpdate")]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[CallsUnknownMethods(Count = 25)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsUnknownMethods(Count = 72)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[CalledBy(Type = typeof(iTween), Member = "RotateUpdate")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallerCount(Count = 2)]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "RotateUpdate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[CalledBy(Type = typeof(iTween), Member = "ScaleUpdate")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 64)]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Calls(Type = typeof(iTween), Member = "ScaleUpdate")]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[CallsUnknownMethods(Count = 96)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CalledBy(Type = typeof(iTween), Member = "MoveUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(iTween), Member = "LookUpdate")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 39)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(iTween), Member = "MoveUpdate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CalledBy(Type = typeof(iTween), Member = "LateUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "LookUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "MoveUpdate")]
	[CallsUnknownMethods(Count = 94)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 24)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "LookUpdate")]
	[CallsUnknownMethods(Count = 17)]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[CallsUnknownMethods(Count = 1)]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	public static Texture2D CameraTexture(Color color)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsUnknownMethods(Count = 4)]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[CallerCount(Count = 0)]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsUnknownMethods(Count = 12)]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsUnknownMethods(Count = 10)]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLine(Vector3[] line)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void DrawLine(Transform[] line)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawPath(Vector3[] path)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawPath(Transform[] path)
	{
	}

	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static void Resume(GameObject target)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallsUnknownMethods(Count = 9)]
	public static void Resume(GameObject target, string type)
	{
	}

	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Resume")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void Resume()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[CallsUnknownMethods(Count = 16)]
	public static void Resume(string type)
	{
	}

	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	public static void Pause(GameObject target)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[CallsUnknownMethods(Count = 13)]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 9)]
	public static void Pause(GameObject target, string type)
	{
	}

	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[CallsUnknownMethods(Count = 6)]
	public static void Pause()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[CallsUnknownMethods(Count = 16)]
	public static void Pause(string type)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static int Count()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static int Count(string type)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallsUnknownMethods(Count = 2)]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallerCount(Count = 0)]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[CallsUnknownMethods(Count = 7)]
	public static void Stop()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	public static void Stop(string type)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[Calls(Type = typeof(iTween), Member = "StopByName")]
	[CallsUnknownMethods(Count = 16)]
	public static void StopByName(string name)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	public static void Stop(GameObject target)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CallsUnknownMethods(Count = 13)]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static void Stop(GameObject target, string type)
	{
	}

	[CalledBy(Type = typeof(iTweenEvent), Member = "Stop")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static void StopByName(GameObject target, string name)
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[Calls(Type = typeof(iTween), Member = "StopByName")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(iTween), Member = "MoveUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "ScaleUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "RotateUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "AudioUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "LookUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "FadeUpdate")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(iTween), Member = "ColorUpdate")]
	public static Hashtable Hash(object[] args)
	{
		return null;
	}

	[Calls(Type = typeof(iTween), Member = "RetrieveArgs")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator Start()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "TweenComplete")]
	[Calls(Type = typeof(iTween), Member = "TweenComplete")]
	[Calls(Type = typeof(iTween), Member = "TweenUpdate")]
	private void Update()
	{
	}

	[Calls(Type = typeof(iTween), Member = "TweenUpdate")]
	[Calls(Type = typeof(iTween), Member = "TweenComplete")]
	[Calls(Type = typeof(iTween), Member = "TweenComplete")]
	[CallerCount(Count = 0)]
	private void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "LookUpdate")]
	[CallsUnknownMethods(Count = 2)]
	private void LateUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "DrawLineGizmos")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTweenPath), Member = "OnDrawGizmosSelected")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 9)]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 32)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsUnknownMethods(Count = 50)]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private static string GenerateID()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 75)]
	[CalledBy(Type = typeof(iTween), Member = "Awake")]
	[Calls(Type = typeof(iTween), Member = "GetEasingFunction")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 33)]
	[CallerCount(Count = 1)]
	private void RetrieveArgs()
	{
	}

	[CallsUnknownMethods(Count = 225)]
	[CalledBy(Type = typeof(iTween), Member = "RetrieveArgs")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void GetEasingFunction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdatePercentage()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(iTween), Member = "TweenComplete")]
	[CalledBy(Type = typeof(iTween), Member = "TweenComplete")]
	[CalledBy(Type = typeof(iTween), Member = "TweenUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "TweenStart")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void CallBack(string callbackType)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(iTween), Member = "ConflictCheck")]
	[CalledBy(Type = typeof(iTween), Member = "ConflictCheck")]
	[CalledBy(Type = typeof(iTween), Member = "ConflictCheck")]
	[CalledBy(Type = typeof(iTween), Member = "ConflictCheck")]
	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[CalledBy(Type = typeof(iTween), Member = "TweenComplete")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateLookToTargets")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateAudioToTargets")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 14)]
	private void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(iTween), Member = "TweenStart")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	private void ConflictCheck()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void EnableKinematic()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void DisableKinematic()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	private void ResumeDelay()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateRotateToTargets")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateLookToTargets")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateLookToTargets")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateLookToTargets")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateRotateToTargets")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateRotateToTargets")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "easeInBounce")]
	[CalledBy(Type = typeof(iTween), Member = "easeInOutBounce")]
	[CalledBy(Type = typeof(iTween), Member = "easeInOutBounce")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Calls(Type = typeof(iTween), Member = "easeOutBounce")]
	[Calls(Type = typeof(iTween), Member = "easeOutBounce")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 18)]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public iTween()
	{
	}
}
