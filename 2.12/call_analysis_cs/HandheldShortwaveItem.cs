using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Audio;
using Cpp2ILInjected.CallAnalysis;
using InteractiveObjects;
using TLD.FX;
using UnityEngine;

public class HandheldShortwaveItem : MonoBehaviour
{
	public enum Range
	{
		OutOfRange,
		FullSignal,
		AudioStart,
		Far
	}

	private enum DeviceState
	{
		Tracking,
		SwitchingMode,
		Off
	}

	private sealed class _003CUpdateTrackingInfoCoroutine_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HandheldShortwaveItem _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CUpdateTrackingInfoCoroutine_003Ed__45(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HandheldShortwaveItem), Member = "UpdateTrackingInformation")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public static bool s_ShowDebugInfo;

	public List<TrackableItemType> m_TrackingModes;

	public Range m_NearestRange;

	public float m_NearestDistance;

	public float m_Intensity;

	public float m_NearestAudioRange;

	public float m_NearestFullSignalRange;

	public float m_NearestMaxRange;

	private HandheldShortwaveAudio m_AudioComponent;

	private EmissiveGlow m_EmissiveGlow;

	private EmissiveGlow.Channel m_GaugeGlowMaskChannel;

	private EmissiveGlow.Channel m_BlinkingLightGlowMaskChannel;

	private AnimationCurve m_BlinkRatePerDistanceAnimationCurve;

	private Coroutine m_TrackingInformationUpdate;

	private float m_LedBlinkTimer;

	private bool m_LastElectrostaticForceActive;

	private TrackableItemType m_CurrentTrackingMode;

	private DeviceState m_DeviceState;

	public event Action<TrackableItemType> m_TrackingModeChanged
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "Update")]
		[CalledBy(Type = typeof(HandheldShortwaveAudio), Member = "OnEnable")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "Update")]
		[CalledBy(Type = typeof(HandheldShortwaveAudio), Member = "OnDisable")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "SetCurrentTrackingMode")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	public HandheldShortwaveSaveDataProxy Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "SetCurrentTrackingMode")]
	[CallsUnknownMethods(Count = 6)]
	public void Deserialize(HandheldShortwaveSaveDataProxy saveProxy)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HandheldShortwaveAudio), Member = "UpdateAudio")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateAudio()
	{
	}

	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateIntensityNeedle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "IsActive")]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "IsEquipped")]
	[CallsUnknownMethods(Count = 2)]
	public bool CanTrack()
	{
		return false;
	}

	[CalledBy(Type = typeof(HandheldShortwaveItem), Member = "CanTrack")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsEquipped()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnAddedToBackPack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void OnEquippedInHand()
	{
	}

	[CallerCount(Count = 0)]
	public static string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private float GetNormalizedDistance()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private void Reset()
	{
	}

	[CalledBy(Type = typeof(HandheldShortwaveItem), Member = "CanTrack")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(EmissiveGlow), Member = "UpdateEmissiveStrengthByChannel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateBlinkingLight()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsUnknownMethods(Count = 1)]
	public float GetBlinkAudioInterval()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(_003CUpdateTrackingInfoCoroutine_003Ed__45), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 21)]
	private void UpdateTrackingInformation()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void StartSwitchingTrackingMode()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsSwitchingMode()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	public TrackableItemType GetTrackableMode()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SetDeviceState(DeviceState deviceState)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateNearestRange(TrackableItemData item, float nearestDistance)
	{
	}

	[CalledBy(Type = typeof(HandheldShortwaveItem), Member = "Awake")]
	[CalledBy(Type = typeof(HandheldShortwaveItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EmissiveGlow), Member = "UpdateEmissiveColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetCurrentTrackingMode(TrackableItemType trackingMode, bool fireEvent = true)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateTrackingInfoCoroutine_003Ed__45))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator UpdateTrackingInfoCoroutine()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public HandheldShortwaveItem()
	{
	}
}
