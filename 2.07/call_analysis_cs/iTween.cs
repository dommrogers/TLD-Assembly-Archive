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

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Copy")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
		[CallsUnknownMethods(Count = 8)]
		public CRSpline(Vector3[] pts)
		{
		}

		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(iTween), Member = "ApplyMoveToPathTargets")]
		[CalledBy(Type = typeof(iTween), Member = "ApplyMoveToPathTargets")]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(iTween), Member = "ApplyMoveToPathTargets")]
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
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
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

		[CallerCount(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(iTween), Member = "TweenStart")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
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
			[CallerCount(Count = 28)]
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
			[CallerCount(Count = 28)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(iTween), Member = "TweenStart")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
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
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
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

		[CallerCount(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
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

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
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

	[Calls(Type = typeof(iTween), Member = "MoveBy")]
	[CallerCount(Count = 0)]
	public static void Init(GameObject target)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsUnknownMethods(Count = 1)]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(iTween), Member = "ColorFrom")]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[CallerCount(Count = 0)]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Calls(Type = typeof(iTween), Member = "ColorFrom")]
	[CallerCount(Count = 0)]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "ColorTo")]
	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 0)]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "ColorTo")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "FadeFrom")]
	[CalledBy(Type = typeof(iTween), Member = "FadeFrom")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(iTween), Member = "ColorFrom")]
	[CalledBy(Type = typeof(iTween), Member = "ColorFrom")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsUnknownMethods(Count = 28)]
	[CallsDeduplicatedMethods(Count = 39)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(iTween), Member = "ColorTo")]
	[CalledBy(Type = typeof(iTween), Member = "FadeTo")]
	[CalledBy(Type = typeof(iTween), Member = "FadeTo")]
	[Calls(Type = typeof(iTween), Member = "ColorTo")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallerCount(Count = 3)]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
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
	[CallsUnknownMethods(Count = 50)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 42)]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "Init")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateScaleToTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateScaleByTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateScaleAddTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateRectTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateColorTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateVector3Targets")]
	[Calls(Type = typeof(iTween), Member = "GenerateVector2Targets")]
	[Calls(Type = typeof(iTween), Member = "GenerateFloatTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(iTween), Member = "GeneratePunchScaleTargets")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(iTween), Member = "TweenStart")]
	[Calls(Type = typeof(iTween), Member = "GenerateColorToTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateMoveByTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GeneratePunchPositionTargets")]
	[Calls(Type = typeof(iTween), Member = "GeneratePunchRotationTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateMoveToTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateStabTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateLookToTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateAudioToTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateShakePositionTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateShakeRotationTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateShakeScaleTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateRotateToTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateRotateAddTargets")]
	[Calls(Type = typeof(iTween), Member = "GenerateRotateByTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void GenerateTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallerCount(Count = 1)]
	private void GenerateRectTargets()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void GenerateColorTargets()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void GenerateVector3Targets()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 6)]
	private void GenerateVector2Targets()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void GenerateFloatTargets()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 31)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	private void GenerateColorToTargets()
	{
	}

	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	private void GenerateAudioToTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(AudioSource), Member = "set_playOnAwake")]
	[Calls(Type = typeof(AudioSource), Member = "set_volume")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void GenerateStabTargets()
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void GenerateLookToTargets()
	{
	}

	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(CRSpline), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 35)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	private void GenerateMoveToPathTargets()
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	private void GenerateMoveToTargets()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 18)]
	[CallsDeduplicatedMethods(Count = 22)]
	private void GenerateMoveByTargets()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 12)]
	private void GenerateScaleToTargets()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	private void GenerateScaleByTargets()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	private void GenerateScaleAddTargets()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void GenerateRotateToTargets()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	private void GenerateRotateAddTargets()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	private void GenerateRotateByTargets()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	private void GenerateShakePositionTargets()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	private void GenerateShakeScaleTargets()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 10)]
	private void GenerateShakeRotationTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateTargets")]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
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
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 13)]
	private void ApplyColorToTargets()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AudioSource), Member = "set_volume")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void ApplyAudioToTargets()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void ApplyStabTargets()
	{
	}

	[Calls(Type = typeof(CRSpline), Member = "Interp")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(CRSpline), Member = "Interp")]
	[Calls(Type = typeof(CRSpline), Member = "Interp")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 0)]
	private void ApplyMoveToPathTargets()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	private void ApplyMoveToTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 0)]
	private void ApplyMoveByTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	private void ApplyScaleToTargets()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	private void ApplyLookToTargets()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsUnknownMethods(Count = 23)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void ApplyRotateToTargets()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	private void ApplyRotateAddTargets()
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 26)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void ApplyShakePositionTargets()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 9)]
	private void ApplyShakeScaleTargets()
	{
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	private void ApplyShakeRotationTargets()
	{
	}

	[Calls(Type = typeof(Transform), Member = "Translate")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 17)]
	private void ApplyPunchPositionTargets()
	{
	}

	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[CallsUnknownMethods(Count = 12)]
	private void ApplyPunchRotationTargets()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	[Calls(Type = typeof(iTween), Member = "punch")]
	private void ApplyPunchScaleTargets()
	{
	}

	[IteratorStateMachine(typeof(_003CTweenDelay_003Ed__144))]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Calls(Type = typeof(iTween), Member = "ConflictCheck")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "GenerateTargets")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(_003CTweenRestart_003Ed__146), Member = "MoveNext")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(_003CTweenDelay_003Ed__144), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CStart_003Ed__228), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void TweenStart()
	{
	}

	[IteratorStateMachine(typeof(_003CTweenRestart_003Ed__146))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[CalledBy(Type = typeof(iTween), Member = "Update")]
	[CalledBy(Type = typeof(iTween), Member = "FixedUpdate")]
	[CallsUnknownMethods(Count = 4)]
	private void TweenUpdate()
	{
	}

	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(iTween), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "Update")]
	[CalledBy(Type = typeof(iTween), Member = "Update")]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(iTween), Member = "CallBack")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void TweenComplete()
	{
	}

	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(iTween), Member = "RectUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "RectUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "RectUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "RectUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Calls(Type = typeof(iTween), Member = "ColorUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(iTween), Member = "FadeUpdate")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(iTween), Member = "FadeUpdate")]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[CallerCount(Count = 0)]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Material), Member = "get_color")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(iTween), Member = "FadeUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "ColorUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "ColorUpdate")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(iTween), Member = "ColorUpdate")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Calls(Type = typeof(iTween), Member = "ColorUpdate")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[CalledBy(Type = typeof(iTween), Member = "AudioUpdate")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[CallsUnknownMethods(Count = 11)]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(iTween), Member = "AudioUpdate")]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[CallerCount(Count = 0)]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CalledBy(Type = typeof(iTween), Member = "RotateUpdate")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallerCount(Count = 1)]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(iTween), Member = "RotateUpdate")]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[CallerCount(Count = 0)]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[CalledBy(Type = typeof(iTween), Member = "ScaleUpdate")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Hash")]
	[Calls(Type = typeof(iTween), Member = "ScaleUpdate")]
	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 0)]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(iTween), Member = "MoveUpdate")]
	[Calls(Type = typeof(iTween), Member = "LookUpdate")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 37)]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallerCount(Count = 1)]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(iTween), Member = "MoveUpdate")]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDampAngle")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(iTween), Member = "LateUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "LookUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "MoveUpdate")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(iTween), Member = "CleanArgs")]
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Calls(Type = typeof(iTween), Member = "LookUpdate")]
	[Calls(Type = typeof(iTween), Member = "Hash")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 17)]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 6)]
	public static Texture2D CameraTexture(Color color)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DrawLine(Transform[] line)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Calls(Type = typeof(iTween), Member = "DrawLineHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsUnknownMethods(Count = 3)]
	public static void DrawPath(Transform[] path)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallerCount(Count = 0)]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallerCount(Count = 0)]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsUnknownMethods(Count = 3)]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	public static void Resume(GameObject target)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[CallsUnknownMethods(Count = 14)]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	public static void Resume(GameObject target, string type)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	public static void Resume()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(iTween), Member = "Resume")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public static void Resume(string type)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	public static void Pause(GameObject target)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[CallsUnknownMethods(Count = 14)]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Pause(GameObject target, string type)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
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

	[Calls(Type = typeof(iTween), Member = "Pause")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void Pause()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[Calls(Type = typeof(iTween), Member = "Pause")]
	[CallsUnknownMethods(Count = 4)]
	public static void Pause(string type)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static int Count()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static int Count(string type)
	{
		return default(int);
	}

	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallerCount(Count = 0)]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[CallsUnknownMethods(Count = 4)]
	public static void Stop(string type)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(iTween), Member = "StopByName")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor")]
	public static void StopByName(string name)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	public static void Stop(GameObject target)
	{
	}

	[Calls(Type = typeof(iTween), Member = "Stop")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CallsUnknownMethods(Count = 14)]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	public static void Stop(GameObject target, string type)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[CalledBy(Type = typeof(iTweenEvent), Member = "Stop")]
	[CallsUnknownMethods(Count = 3)]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[Calls(Type = typeof(iTween), Member = "StopByName")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(iTween), Member = "ColorUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "FadeUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "FadeTo")]
	[CalledBy(Type = typeof(iTween), Member = "FadeFrom")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(iTween), Member = "RotateUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "AudioUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "MoveUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "LookUpdate")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(iTween), Member = "ScaleUpdate")]
	public static Hashtable Hash(object[] args)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "RetrieveArgs")]
	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__228))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(iTween), Member = "TweenComplete")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "TweenUpdate")]
	[Calls(Type = typeof(iTween), Member = "TweenComplete")]
	private void FixedUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "LookUpdate")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
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
	[CalledBy(Type = typeof(iTween), Member = "DrawLineGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLine")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawLineHandles")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathGizmos")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHandles")]
	[CalledBy(Type = typeof(iTweenPath), Member = "OnDrawGizmosSelected")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPath")]
	[Calls(Type = typeof(iTween), Member = "PathControlPointGenerator")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[Calls(Type = typeof(iTween), Member = "Interp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 13)]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CallerCount(Count = 10)]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PutOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "PointOnPath")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CalledBy(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(iTween), Member = "PathLength")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "GenerateID")]
	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 6)]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor")]
	[CallerCount(Count = 32)]
	[CallsDeduplicatedMethods(Count = 15)]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(iTween), Member = "Launch")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	private static string GenerateID()
	{
		return null;
	}

	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 51)]
	[CalledBy(Type = typeof(iTween), Member = "Awake")]
	[Calls(Type = typeof(iTween), Member = "GetEasingFunction")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 32)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void RetrieveArgs()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(iTween), Member = "RetrieveArgs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void GetEasingFunction()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdatePercentage()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(iTween), Member = "TweenComplete")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(iTween), Member = "TweenStart")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(iTween), Member = "TweenUpdate")]
	[CalledBy(Type = typeof(iTween), Member = "TweenComplete")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void CallBack(string callbackType)
	{
	}

	[CalledBy(Type = typeof(iTween), Member = "TweenComplete")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "Stop")]
	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[CalledBy(Type = typeof(iTween), Member = "StopByName")]
	[CalledBy(Type = typeof(iTween), Member = "ConflictCheck")]
	[CalledBy(Type = typeof(iTween), Member = "ConflictCheck")]
	[CalledBy(Type = typeof(iTween), Member = "ConflictCheck")]
	[CalledBy(Type = typeof(iTween), Member = "ConflictCheck")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateLookToTargets")]
	[CalledBy(Type = typeof(iTween), Member = "GenerateMoveToPathTargets")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(iTween), Member = "GenerateAudioToTargets")]
	private void Dispose()
	{
	}

	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Component), Member = "GetComponents")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 23)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(iTween), Member = "TweenStart")]
	private void ConflictCheck()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void EnableKinematic()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void DisableKinematic()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	private void ResumeDelay()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(iTween), Member = "easeOutBounce")]
	[CallerCount(Count = 0)]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(iTween), Member = "easeInOutBounce")]
	[CalledBy(Type = typeof(iTween), Member = "easeInBounce")]
	[CallerCount(Count = 3)]
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

	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchRotationTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchScaleTargets")]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	[CallerCount(Count = 18)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(iTween), Member = "ApplyPunchPositionTargets")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public iTween()
	{
	}
}
