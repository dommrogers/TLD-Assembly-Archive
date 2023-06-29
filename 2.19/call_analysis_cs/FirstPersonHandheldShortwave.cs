using Cpp2ILInjected.CallAnalysis;
using InteractiveObjects;
using TLD.FX;
using UnityEngine;

public class FirstPersonHandheldShortwave : MonoBehaviour
{
	public Transform m_SignalStrengthMeterTransform;

	private AnimationCurve m_NeedleAngleCurve;

	private Vector2 m_NeedleNoiseSpeed;

	private float m_NeedleNoiseAmplitude;

	private float m_NeedleMovementSmoothingRate;

	private EmissiveGlow m_EmissiveGlow;

	private EmissiveGlow.Channel m_GaugeGlowMaskChannel;

	private EmissiveGlow.Channel m_BlinkingLightGlowMaskChannel;

	private float m_LedBlinkTimer;

	private bool m_LastElectrostaticForceActive;

	private float m_NeedleIntensity;

	private float m_NeedleVelocity;

	private HandheldShortwaveItem m_Lasthhsw;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EmissiveGlow), Member = "UpdateEmissiveStrengthByChannel")]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "remove_m_TrackingModeChanged")]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "add_m_TrackingModeChanged")]
	[Calls(Type = typeof(EmissiveGlow), Member = "UpdateEmissiveColor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateIntensityNeedle")]
	[Calls(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateBlinkingLight")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EmissiveGlow), Member = "UpdateEmissiveColor")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTrackingModeChanged(TrackableItemType trackingMode)
	{
	}

	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "CanTrack")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateIntensityNeedle(HandheldShortwaveItem hhsw)
	{
	}

	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(EmissiveGlow), Member = "UpdateEmissiveStrengthByChannel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateBlinkingLight(HandheldShortwaveItem hhsw)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FirstPersonHandheldShortwave()
	{
	}
}
