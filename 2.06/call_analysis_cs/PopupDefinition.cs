using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class PopupDefinition : ScriptableObject
{
	private sealed class _003CDisplayPopup_003Ed__7 : IDisposable, IEnumerator<object>, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public GameObject go;

		public PopupDefinition _003C_003E4__this;

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
			[CallerCount(Count = 44)]
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
		public _003CDisplayPopup_003Ed__7(int _003C_003E1__state)
		{
		}

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(Transform), Member = "set_parent")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
		[Calls(Type = typeof(GameObject), Member = "get_transform")]
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameObject), Member = "SetActive")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public UIPanel m_PanelPrefab;

	public float m_DurationSeconds;

	public string m_AudioEvent;

	private Action m_OnPopupEndAction;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(PopupDefinition), Member = "DisplayPopup")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(Action_ShowPopup), Member = "OnExecute")]
	[Calls(Type = typeof(InterfaceManager), Member = "InstantiatePopup")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	public void Show(Action onPopupEndAction)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void ConfigurePopup(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void PlayAudio()
	{
	}

	[IteratorStateMachine(typeof(_003CDisplayPopup_003Ed__7))]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PopupDefinition), Member = "Show")]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator DisplayPopup(GameObject go, float duration)
	{
		return null;
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PopupDefinition()
	{
	}
}
