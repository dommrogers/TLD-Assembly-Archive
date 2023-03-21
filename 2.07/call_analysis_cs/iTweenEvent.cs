using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class iTweenEvent : MonoBehaviour
{
	public enum TweenType
	{
		AudioFrom,
		AudioTo,
		AudioUpdate,
		CameraFadeFrom,
		CameraFadeTo,
		ColorFrom,
		ColorTo,
		ColorUpdate,
		FadeFrom,
		FadeTo,
		FadeUpdate,
		LookFrom,
		LookTo,
		LookUpdate,
		MoveAdd,
		MoveBy,
		MoveFrom,
		MoveTo,
		MoveUpdate,
		PunchPosition,
		PunchRotation,
		PunchScale,
		RotateAdd,
		RotateBy,
		RotateFrom,
		RotateTo,
		RotateUpdate,
		ScaleAdd,
		ScaleBy,
		ScaleFrom,
		ScaleTo,
		ScaleUpdate,
		ShakePosition,
		ShakeRotation,
		ShakeScale,
		Stab
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public string name;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		internal bool _003CGetEvent_003Eb__0(iTweenEvent tween)
		{
			return default(bool);
		}
	}

	private sealed class _003CStartEvent_003Ed__41 : IDisposable, IEnumerator<object>, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public iTweenEvent _003C_003E4__this;

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
		public _003CStartEvent_003Ed__41(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallAnalysisFailed]
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

	public const string VERSION = "0.6.1";

	public string tweenName;

	public bool playAutomatically;

	public float delay;

	public TweenType type;

	public bool showIconInInspector;

	private string[] keys;

	private int[] indexes;

	private string[] metadatas;

	private int[] ints;

	private float[] floats;

	private bool[] bools;

	private string[] strings;

	private Vector3[] vector3s;

	private Color[] colors;

	private Space[] spaces;

	private iTween.EaseType[] easeTypes;

	private iTween.LoopType[] loopTypes;

	private GameObject[] gameObjects;

	private Transform[] transforms;

	private AudioClip[] audioClips;

	private AudioSource[] audioSources;

	private ArrayIndexes[] vector3Arrays;

	private ArrayIndexes[] transformArrays;

	private iTweenPath[] paths;

	private Dictionary<string, object> values;

	private bool stopped;

	private bool animating;

	private iTween instantiatedTween;

	private string internalName;

	public Dictionary<string, object> Values
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(iTweenEvent), Member = "DeserializeValues")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(iTweenEvent), Member = "SerializeValues")]
		set
		{
		}
	}

	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(ObjectAnim), Member = "Play")]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	public static iTweenEvent GetEvent(GameObject obj, string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void Start()
	{
	}

	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[CalledBy(Type = typeof(ObjectAnim), Member = "Play")]
	[Calls(Type = typeof(iTweenEvent), Member = "Stop")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public void Play()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(iTweenEvent), Member = "Play")]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[Calls(Type = typeof(iTween), Member = "StopByName")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	public void Stop()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 0)]
	public void OnAnimComplete(string name)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsAnimating()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnDrawGizmos()
	{
	}

	[IteratorStateMachine(typeof(_003CStartEvent_003Ed__41))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator StartEvent()
	{
		return null;
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(iTweenEvent), Member = "set_Values")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 39)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void SerializeValues()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, KeyValuePair<string, object> pair)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, KeyValuePair<string, object> pair, string metadata)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, string key, object value)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, string key, object value, string metadata)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(iTweenEvent), Member = "get_Values")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void DeserializeValues()
	{
	}

	[CallerCount(Count = 0)]
	public iTweenEvent()
	{
	}
}
