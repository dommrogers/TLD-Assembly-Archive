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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public CRSpline(Vector3[] pts)
		{
		}

		[CalledBy(Type = typeof(iTween), Member = "ApplyMoveToPathTargets")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 13)]
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
		public _003CTweenDelay_003Ed__144(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(iTween), Member = "TweenStart")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
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

	private sealed class _003CTweenRestart_003Ed__146 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public iTween _003C_003E4__this;

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
		public _003CTweenRestart_003Ed__146(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(iTween), Member = "TweenStart")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
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

	private sealed class _003CStart_003Ed__228 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public iTween _003C_003E4__this;

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
		public _003CStart_003Ed__228(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(iTween), Member = "TweenStart")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(iTween), Member = "MoveBy")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Init(GameObject target)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 6)]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "ColorFrom")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "ColorTo")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "FadeFrom")]
	[CalledBy(Type = typeof(iTween), Member = "ColorFrom")]
	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "ColorFrom")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 31)]
	[CallsUnknownMethods(Count = 44)]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "FadeTo")]
	[CalledBy(Type = typeof(iTween), Member = "ColorTo")]
	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "ColorTo")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 19)]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 13)]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 24)]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 7)]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 10)]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 44)]
	[CallsUnknownMethods(Count = 84)]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(iTween), Member = "Init")]
	[CallerCount(Count = 1)]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 10)]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 22)]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 10)]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 28)]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "TweenStart")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "GenerateAudioToTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateStabTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateLookToTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateRotateToTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateRotateAddTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateRotateByTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateShakePositionTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateShakeScaleTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateShakeRotationTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateRectTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateColorTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateVector3Targets")]
	[Calls(Type = typeof(iTween), Member = "GenerateVector2Targets")]
	[Calls(Type = typeof(iTween), Member = "GenerateFloatTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateScaleAddTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateScaleByTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateScaleToTargets")]
	[Calls(Type = typeof(iTween), Member = "GeneratePunchPositionTargets")]
	[Calls(Type = typeof(iTween), Member = "GeneratePunchRotationTargets")]
	[Calls(Type = typeof(iTween), Member = "GeneratePunchScaleTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateMoveByTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateMoveToTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateColorToTargets")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 149)]
	private void GenerateTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	private void GenerateRectTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	private void GenerateColorTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	private void GenerateVector3Targets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 23)]
	private void GenerateVector2Targets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	private void GenerateFloatTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 128)]
	private void GenerateColorToTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 28)]
	private void GenerateAudioToTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(AudioSource), Member = "set_playOnAwake")]
	[Calls(Type = typeof(AudioSource), Member = "set_volume")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 28)]
	private void GenerateStabTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "clerp")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 100)]
	private void GenerateLookToTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(iTween), Member = "PathLength")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 77)]
	private void GenerateMoveToPathTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 75)]
	private void GenerateMoveToTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 90)]
	private void GenerateMoveByTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 58)]
	private void GenerateScaleToTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 50)]
	private void GenerateScaleByTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 47)]
	private void GenerateScaleAddTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "clerp")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 87)]
	private void GenerateRotateToTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 50)]
	private void GenerateRotateAddTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 50)]
	private void GenerateRotateByTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 13)]
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

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 34)]
	private void GenerateShakeRotationTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 46)]
	private void GeneratePunchPositionTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 40)]
	private void GeneratePunchRotationTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 37)]
	private void GeneratePunchScaleTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 44)]
	private void ApplyRectTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 48)]
	private void ApplyColorTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 35)]
	private void ApplyVector3Targets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 26)]
	private void ApplyVector2Targets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	private void ApplyFloatTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 94)]
	private void ApplyColorToTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(AudioSource), Member = "set_volume")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	private void ApplyAudioToTargets()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void ApplyStabTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(CRSpline), Member = "Interp")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 33)]
	private void ApplyMoveToPathTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 64)]
	private void ApplyMoveToTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 66)]
	private void ApplyMoveByTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 27)]
	private void ApplyScaleToTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 39)]
	private void ApplyLookToTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 63)]
	private void ApplyRotateToTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(EasingFunction), Member = "Invoke")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 53)]
	private void ApplyRotateAddTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 77)]
	private void ApplyShakePositionTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 37)]
	private void ApplyShakeScaleTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 45)]
	private void ApplyShakeRotationTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 66)]
	private void ApplyPunchPositionTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 53)]
	private void ApplyPunchRotationTargets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 36)]
	private void ApplyPunchScaleTargets()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CTweenDelay_003Ed__144), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CTweenRestart_003Ed__146), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CStart_003Ed__228), Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[Calls(Type = typeof(iTween), Member = "ConflictCheck")]
	[Calls(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void TweenStart()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[CalledBy(Type = typeof(iTween), Member = "Update")]
	[CalledBy(Type = typeof(iTween), Member = "FixedUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void TweenUpdate()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Update")]
	[CalledBy(Type = typeof(iTween), Member = "FixedUpdate")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void TweenComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void TweenLoop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "FloatUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(iTween), Member = "RectUpdate")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(iTween), Member = "FadeUpdate")]
	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "ColorUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "FadeUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "FadeUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "ColorUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "ColorUpdate")]
	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "ColorUpdate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 102)]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "ColorUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "AudioUpdate")]
	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 42)]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "AudioUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 25)]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "RotateUpdate")]
	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 72)]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "RotateUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "ScaleUpdate")]
	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 64)]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "ScaleUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "MoveUpdate")]
	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(iTween), Member = "LookUpdate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 37)]
	[CallsUnknownMethods(Count = 96)]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "MoveUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "MoveUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "LookUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "LateUpdate")]
	[CalledBy(TypeFullName = "iTweenEvent.<StartEvent>d__41", Member = "MoveNext")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 94)]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "LookUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static float PathLength(Transform[] path)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float PathLength(Vector3[] path)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 15)]
	public static Texture2D CameraTexture(Color color)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLine(Vector3[] line)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawLine(Transform[] line)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawPath(Vector3[] path)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawPath(Transform[] path)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void Resume(GameObject target)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public static void Resume(GameObject target, string type)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 21)]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public static void Resume()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	public static void Resume(string type)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void Pause(GameObject target)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public static void Pause(GameObject target, string type)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 21)]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public static void Pause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	public static void Pause(string type)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static int Count()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public static int Count(string type)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int Count(GameObject target)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static int Count(GameObject target, string type)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	public static void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	public static void Stop(string type)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[Calls(Type = typeof(iTween), Member = "StopByName")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	public static void StopByName(string name)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void Stop(GameObject target)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static void Stop(GameObject target, string type)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[CalledBy(Type = typeof(iTweenEvent), Member = "Stop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static void StopByName(GameObject target, string name)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "StopByName")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 18)]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "FadeUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "ColorUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "AudioUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "RotateUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "ScaleUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "MoveUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "LookUpdate")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public static Hashtable Hash(object[] args)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "RetrieveArgs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator Start()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "TweenComplete")]
	[Calls(Type = typeof(iTween), Member = "TweenUpdate")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "TweenComplete")]
	[Calls(Type = typeof(iTween), Member = "TweenUpdate")]
	private void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(iTween), Member = "LookUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTweenPath), Member = "OnDrawGizmosSelected")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 27)]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(char), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 50)]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(char), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static string GenerateID()
	{
		return null;
	}

	[CalledBy(Type = typeof(iTween), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(iTween), Member = "GetEasingFunction")]
	[CallsDeduplicatedMethods(Count = 32)]
	[CallsUnknownMethods(Count = 75)]
	private void RetrieveArgs()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "RetrieveArgs")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 225)]
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
	[CalledBy(Type = typeof(iTween), Member = "TweenUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "TweenComplete")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 20)]
	private void CallBack(string callbackType)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateAudioToTargets")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateLookToTargets")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[CalledBy(Type = typeof(iTween), Member = "TweenComplete")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[CalledBy(Type = typeof(iTween), Member = "ConflictCheck")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void Dispose()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "TweenStart")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 23)]
	private void ConflictCheck()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void EnableKinematic()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void DisableKinematic()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ResumeDelay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float linear(float start, float end, float value)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateLookToTargets")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateRotateToTargets")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float clerp(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float spring(float start, float end, float value)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float easeInQuad(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float easeOutQuad(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float easeInOutQuad(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float easeInCubic(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float easeOutCubic(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float easeInOutCubic(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float easeInQuart(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float easeOutQuart(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float easeInOutQuart(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float easeInQuint(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float easeOutQuint(float start, float end, float value)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float easeInOutQuint(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float easeInSine(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float easeOutSine(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float easeInOutSine(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float easeInExpo(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float easeOutExpo(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float easeInOutExpo(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float easeInCirc(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float easeOutCirc(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float easeInOutCirc(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "easeOutBounce")]
	private float easeInBounce(float start, float end, float value)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(iTween), Member = "easeInBounce")]
	[CalledBy(Type = typeof(iTween), Member = "easeInOutBounce")]
	[CallerCount(Count = 3)]
	private float easeOutBounce(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "easeOutBounce")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float easeInBack(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float easeOutBack(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float easeInOutBack(float start, float end, float value)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CallerCount(Count = 18)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private float punch(float amplitude, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float easeInElastic(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float easeOutElastic(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private float easeInOutElastic(float start, float end, float value)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public iTween()
	{
	}
}
