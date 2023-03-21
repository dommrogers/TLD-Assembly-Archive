using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RadioTower : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_ProgressDisplayName;

	public string m_InteractAudio;

	public static List<RadioTower> s_RadioTowers;

	private bool m_IsBeingInteractedWith;

	private float m_InteractTimer;

	private PlayerControlMode m_RestoreControlMode;

	private uint m_InteractAudioID;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(RadioTower), Member = "UpdateInteraction")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(RadioTower), Member = "UpdateInteraction")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[CallsUnknownMethods(Count = 11)]
	public void Cancel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void ProgressBarStarted()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RadioTower), Member = "InitializeInteraction")]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(RadioTower), Member = "ProcessInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void InitializeInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(RadioTower), Member = "Cancel")]
	[Calls(Type = typeof(RadioTower), Member = "InteractionComplete")]
	[Calls(Type = typeof(RadioTower), Member = "Cancel")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateInteraction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadioTower), Member = "UpdateInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	private void InteractionComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void PlayAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	private void StopAudio()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RadioTower()
	{
	}
}
