using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetEvent_003Eb__0(iTweenEvent tween)
		{
			return false;
		}
	}

	private sealed class _003CStartEvent_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public iTweenEvent _003C_003E4__this;

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
		public _003CStartEvent_003Ed__41(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Hashtable), Member = ".ctor")]
		[Calls(Type = typeof(iTweenEvent), Member = "DeserializeValues")]
		[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(iTweenPath), Member = "GetPath")]
		[Calls(Type = typeof(Guid), Member = "NewGuid")]
		[Calls(Type = typeof(Guid), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(iTween), Member = "AudioFrom")]
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
		[Calls(Type = typeof(iTween), Member = "LookUpdate")]
		[Calls(Type = typeof(iTween), Member = "MoveAdd")]
		[Calls(Type = typeof(iTween), Member = "MoveBy")]
		[Calls(Type = typeof(iTween), Member = "MoveFrom")]
		[Calls(Type = typeof(iTween), Member = "MoveTo")]
		[Calls(Type = typeof(iTween), Member = "MoveUpdate")]
		[Calls(Type = typeof(iTween), Member = "PunchPosition")]
		[Calls(Type = typeof(iTween), Member = "PunchRotation")]
		[Calls(Type = typeof(iTween), Member = "PunchScale")]
		[Calls(Type = typeof(iTween), Member = "RotateAdd")]
		[Calls(Type = typeof(iTween), Member = "RotateBy")]
		[Calls(Type = typeof(iTween), Member = "RotateFrom")]
		[Calls(Type = typeof(iTween), Member = "RotateTo")]
		[Calls(Type = typeof(iTween), Member = "RotateUpdate")]
		[Calls(Type = typeof(iTween), Member = "ScaleAdd")]
		[Calls(Type = typeof(iTween), Member = "ScaleBy")]
		[Calls(Type = typeof(iTween), Member = "ScaleFrom")]
		[Calls(Type = typeof(iTween), Member = "ScaleTo")]
		[Calls(Type = typeof(iTween), Member = "ScaleUpdate")]
		[Calls(Type = typeof(iTween), Member = "ShakePosition")]
		[Calls(Type = typeof(iTween), Member = "ShakeRotation")]
		[Calls(Type = typeof(iTween), Member = "ShakeScale")]
		[Calls(Type = typeof(iTween), Member = "Stab")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 39)]
		[CallsUnknownMethods(Count = 34)]
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

	[CalledBy(Type = typeof(ObjectAnim), Member = "Play")]
	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 36)]
	public static iTweenEvent GetEvent(GameObject obj, string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTweenEvent), Member = "Stop")]
	[Calls(Type = typeof(iTweenEvent), Member = "StartEvent")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(ObjectAnim), Member = "Play")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(iTweenEvent), Member = "Stop")]
	[Calls(Type = typeof(iTweenEvent), Member = "StartEvent")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	public void Play()
	{
	}

	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[CalledBy(Type = typeof(iTweenEvent), Member = "Start")]
	[CalledBy(Type = typeof(iTweenEvent), Member = "Play")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(iTween), Member = "StopByName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsUnknownMethods(Count = 1)]
	public void OnAnimComplete(string name)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsAnimating()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void OnDrawGizmos()
	{
	}

	[CalledBy(Type = typeof(StartAndStopTween), Member = "OnGUI")]
	[CalledBy(Type = typeof(iTweenEvent), Member = "Start")]
	[CalledBy(Type = typeof(iTweenEvent), Member = "Play")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator StartEvent()
	{
		return null;
	}

	[CalledBy(Type = typeof(iTweenEvent), Member = "set_Values")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(iTweenEvent), Member = "AddToList")]
	[Calls(Type = typeof(iTweenEvent), Member = "AddToList")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 241)]
	private void SerializeValues()
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(iTweenEvent), Member = "SerializeValues")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, KeyValuePair<string, object> pair)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, KeyValuePair<string, object> pair, string metadata)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, string key, object value)
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(iTweenEvent), Member = "SerializeValues")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, string key, object value, string metadata)
	{
	}

	[CalledBy(Type = typeof(iTweenEvent), Member = "get_Values")]
	[CalledBy(Type = typeof(_003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 234)]
	private void DeserializeValues()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public iTweenEvent()
	{
	}
}
