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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetEvent_003Eb__0(iTweenEvent tween)
		{
			return default(bool);
		}
	}

	private sealed class _003CStartEvent_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public iTweenEvent _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
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
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		public _003CStartEvent_003Ed__41(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(iTween), Member = "RotateAdd")]
		[Calls(Type = typeof(iTween), Member = "RotateFrom")]
		[Calls(Type = typeof(iTween), Member = "RotateBy")]
		[Calls(Type = typeof(iTween), Member = "PunchScale")]
		[Calls(Type = typeof(iTween), Member = "MoveTo")]
		[Calls(Type = typeof(iTween), Member = "PunchRotation")]
		[Calls(Type = typeof(iTween), Member = "PunchPosition")]
		[Calls(Type = typeof(iTween), Member = "MoveUpdate")]
		[Calls(Type = typeof(iTween), Member = "RotateTo")]
		[Calls(Type = typeof(iTween), Member = "RotateUpdate")]
		[Calls(Type = typeof(iTween), Member = "ShakeScale")]
		[Calls(Type = typeof(iTween), Member = "ScaleBy")]
		[Calls(Type = typeof(iTween), Member = "ScaleFrom")]
		[Calls(Type = typeof(iTween), Member = "ScaleTo")]
		[Calls(Type = typeof(iTween), Member = "ScaleUpdate")]
		[Calls(Type = typeof(iTween), Member = "ShakePosition")]
		[Calls(Type = typeof(iTween), Member = "ShakeRotation")]
		[Calls(Type = typeof(iTween), Member = "Stab")]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(iTween), Member = "MoveFrom")]
		[Calls(Type = typeof(iTween), Member = "ScaleAdd")]
		[Calls(Type = typeof(iTween), Member = "MoveBy")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(iTween), Member = "LookUpdate")]
		[CallsUnknownMethods(Count = 34)]
		[CallsDeduplicatedMethods(Count = 38)]
		[Calls(Type = typeof(Hashtable), Member = ".ctor")]
		[Calls(Type = typeof(iTweenEvent), Member = "DeserializeValues")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(iTweenPath), Member = "GetPath")]
		[Calls(Type = typeof(Interop), Member = "GetRandomBytes")]
		[Calls(Type = typeof(Guid), Member = "ToString")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(iTween), Member = "MoveAdd")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(iTween), Member = "AudioTo")]
		[Calls(Type = typeof(iTween), Member = "AudioUpdate")]
		[Calls(Type = typeof(iTween), Member = "ColorFrom")]
		[Calls(Type = typeof(iTween), Member = "ColorTo")]
		[Calls(Type = typeof(iTween), Member = "ColorUpdate")]
		[Calls(Type = typeof(iTween), Member = "FadeFrom")]
		[Calls(Type = typeof(iTween), Member = "FadeTo")]
		[Calls(Type = typeof(iTween), Member = "FadeUpdate")]
		[Calls(Type = typeof(iTween), Member = "LookFrom")]
		[Calls(Type = typeof(iTween), Member = "LookTo")]
		[Calls(Type = typeof(iTween), Member = "AudioFrom")]
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
		[Calls(Type = typeof(iTweenEvent), Member = "SerializeValues")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[CalledBy(Type = typeof(ObjectAnim), Member = "Play")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static iTweenEvent GetEvent(GameObject obj, string name)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(iTweenEvent), Member = "Stop")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(ObjectAnim), Member = "Play")]
	public void Play()
	{
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(iTweenEvent), Member = "Play")]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[Calls(Type = typeof(iTween), Member = "StopByName")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Stop()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public void OnAnimComplete(string name)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsAnimating()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void OnDrawGizmos()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[IteratorStateMachine(typeof(_003CStartEvent_003Ed__41))]
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
	[CallsDeduplicatedMethods(Count = 26)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsUnknownMethods(Count = 228)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CalledBy(Type = typeof(iTweenEvent), Member = "set_Values")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, KeyValuePair<string, object> pair, string metadata)
	{
	}

	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, string key, object value)
	{
	}

	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 0)]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, string key, object value, string metadata)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(iTweenEvent), Member = "get_Values")]
	[CalledBy(Type = typeof(_003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void DeserializeValues()
	{
	}

	[CallerCount(Count = 0)]
	public iTweenEvent()
	{
	}
}
