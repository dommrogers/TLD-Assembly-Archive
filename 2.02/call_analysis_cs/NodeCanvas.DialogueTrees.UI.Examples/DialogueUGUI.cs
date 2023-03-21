using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace NodeCanvas.DialogueTrees.UI.Examples;

public class DialogueUGUI : MonoBehaviour
{
	[Serializable]
	public class SubtitleDelays
	{
		public float characterDelay;

		public float sentenceDelay;

		public float commaDelay;

		public float finalDelay;

		[CallerCount(Count = 0)]
		public SubtitleDelays()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public bool inputDown;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal void _003CInternal_OnSubtitlesRequestInfo_003Eb__0()
		{
		}
	}

	private sealed class _003CInternal_OnSubtitlesRequestInfo_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SubtitlesRequestInfo info;

		public DialogueUGUI _003C_003E4__this;

		private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

		private string _003Ctext_003E5__2;

		private AudioClip _003Caudio_003E5__3;

		private AudioSource _003CplaySource_003E5__4;

		private float _003Ctimer_003E5__5;

		private string _003CtempText_003E5__6;

		private int _003Ci_003E5__7;

		private char _003Cc_003E5__8;

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
		public _003CInternal_OnSubtitlesRequestInfo_003Ed__25(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameObject), Member = "SetActive")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Image), Member = "set_sprite")]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[Calls(Type = typeof(DialogueUGUI), Member = "get_localSource")]
		[Calls(Type = typeof(AudioSource), Member = "set_clip")]
		[Calls(Type = typeof(AudioSource), Member = "Play")]
		[Calls(Type = typeof(AudioClip), Member = "get_length")]
		[Calls(Type = typeof(Input), Member = "get_anyKeyDown")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Time), Member = "get_deltaTime")]
		[Calls(Type = typeof(DialogueUGUI), Member = "CheckInput")]
		[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
		[Calls(Type = typeof(DialogueUGUI), Member = "DelayPrint")]
		[Calls(Type = typeof(DialogueUGUI), Member = "PlayTypeSound")]
		[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
		[Calls(Type = typeof(string), Member = "get_Chars")]
		[Calls(Type = typeof(char), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 17)]
		[CallsUnknownMethods(Count = 88)]
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

	private sealed class _003CCheckInput_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action Do;

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
		public _003CCheckInput_003Ed__27(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
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

	private sealed class _003CDelayPrint_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

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
		public _003CDelayPrint_003Ed__28(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public DialogueUGUI _003C_003E4__this;

		public MultipleChoiceRequestInfo info;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass29_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_1
	{
		public Button btn;

		public _003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals1;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass29_1()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
		[Calls(Type = typeof(DialogueUGUI), Member = "Finalize")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		internal void _003COnMultipleChoiceRequest_003Eb__0()
		{
		}
	}

	private sealed class _003CCountDown_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DialogueUGUI _003C_003E4__this;

		public MultipleChoiceRequestInfo info;

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
		public _003CCountDown_003Ed__30(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_deltaTime")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[Calls(Type = typeof(DialogueUGUI), Member = "SetMassAlpha")]
		[Calls(Type = typeof(Enumerable), Member = "Last")]
		[Calls(Type = typeof(DialogueUGUI), Member = "Finalize")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
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

	public bool skipOnInput;

	public bool waitForInput;

	public RectTransform subtitlesGroup;

	public Text actorSpeech;

	public Text actorName;

	public Image actorPortrait;

	public RectTransform waitInputIndicator;

	public SubtitleDelays subtitleDelays;

	public List<AudioClip> typingSounds;

	public RectTransform optionsGroup;

	public Button optionButton;

	private Dictionary<Button, int> cachedButtons;

	private Vector2 originalSubsPosition;

	private bool isWaitingChoice;

	private AudioSource _localSource;

	private AudioSource localSource
	{
		[CalledBy(Type = typeof(DialogueUGUI), Member = "PlayTypeSound")]
		[CalledBy(Type = typeof(_003CInternal_OnSubtitlesRequestInfo_003Ed__25), Member = "MoveNext")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(GameObject), Member = "AddComponent")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueTree), Member = "add_OnDialogueStarted")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(DialogueTree), Member = "add_OnDialogueFinished")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 40)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueTree), Member = "remove_OnDialogueStarted")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(DialogueTree), Member = "remove_OnDialogueFinished")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 40)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 20)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void OnDialogueStarted(DialogueTree dlg)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void OnDialoguePaused(DialogueTree dlg)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 12)]
	private void OnDialogueFinished(DialogueTree dlg)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueUGUI), Member = "Internal_OnSubtitlesRequestInfo")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	private void OnSubtitlesRequest(SubtitlesRequestInfo info)
	{
	}

	[CalledBy(Type = typeof(DialogueUGUI), Member = "OnSubtitlesRequest")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator Internal_OnSubtitlesRequestInfo(SubtitlesRequestInfo info)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CInternal_OnSubtitlesRequestInfo_003Ed__25), Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DialogueUGUI), Member = "get_localSource")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void PlayTypeSound()
	{
	}

	[CalledBy(Type = typeof(_003CInternal_OnSubtitlesRequestInfo_003Ed__25), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator CheckInput(Action Do)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CInternal_OnSubtitlesRequestInfo_003Ed__25), Member = "MoveNext")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator DelayPrint(float time)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener")]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta")]
	[Calls(Type = typeof(DialogueUGUI), Member = "CountDown")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 78)]
	private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo info)
	{
	}

	[CalledBy(Type = typeof(DialogueUGUI), Member = "OnMultipleChoiceRequest")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator CountDown(MultipleChoiceRequestInfo info)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass29_1), Member = "<OnMultipleChoiceRequest>b__0")]
	[CalledBy(Type = typeof(_003CCountDown_003Ed__30), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueUGUI), Member = "SetMassAlpha")]
	[Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 20)]
	private void Finalize(MultipleChoiceRequestInfo info, int index)
	{
	}

	[CalledBy(Type = typeof(DialogueUGUI), Member = "Finalize")]
	[CalledBy(Type = typeof(_003CCountDown_003Ed__30), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void SetMassAlpha(RectTransform root, float alpha)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public DialogueUGUI()
	{
	}
}
