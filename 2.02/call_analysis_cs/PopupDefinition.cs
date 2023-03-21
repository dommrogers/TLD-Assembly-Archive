using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class PopupDefinition : ScriptableObject
{
	private sealed class _003CDisplayPopup_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public GameObject go;

		public PopupDefinition _003C_003E4__this;

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
		public _003CDisplayPopup_003Ed__7(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(GameObject), Member = "SetActive")]
		[Calls(Type = typeof(GameObject), Member = "get_transform")]
		[Calls(Type = typeof(Transform), Member = "set_parent")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 11)]
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

	public UIPanel m_PanelPrefab;

	public float m_DurationSeconds;

	public string m_AudioEvent;

	private Action m_OnPopupEndAction;

	[CalledBy(Type = typeof(Action_ShowPopup), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "InstantiatePopup")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PopupDefinition), Member = "DisplayPopup")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Show(Action onPopupEndAction)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected virtual void ConfigurePopup(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void PlayAudio()
	{
	}

	[CalledBy(Type = typeof(PopupDefinition), Member = "Show")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator DisplayPopup(GameObject go, float duration)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PopupDefinition()
	{
	}
}
