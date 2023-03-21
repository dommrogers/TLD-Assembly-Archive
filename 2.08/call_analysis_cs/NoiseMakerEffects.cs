using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NoiseMakerEffects : MonoBehaviour
{
	private Renderer m_FuseRenderer;

	private Transform[] m_WickTransformChain;

	private Transform m_WickFXRoot;

	private ParticleSystem m_WickFX;

	private ParticleSystem m_DetonateFX;

	private GearItem m_GearItem;

	private static readonly int s_BurnStrengthPropertyID;

	private static readonly int s_BurnPositionPropertyID;

	private MaterialPropertyBlock m_FuseBurnPropertyBlock;

	private NoiseMakerState m_LastState;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void SetEffectsHidden(bool isHidden)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public GameObject GetDetonateEffectObject()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "GetInterpolatedPointAlongWick")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "MaybeLeaveScorchMarkOnGround")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "PlayDetonateInHand")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "GetNormalizedWickTimeLeft")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	private void PlayDetonateInHand()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "EnableEffect")]
	[CallsUnknownMethods(Count = 2)]
	private void EnableDisconnectedEffect(ParticleSystem effect, bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "PlayDetonateInHand")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "EnableDisconnectedEffect")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void EnableEffect(ParticleSystem effect, bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast_Internal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RaycastManager), Member = "GetInstance")]
	private void MaybeLeaveScorchMarkOnGround()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(NoiseMakerEffects), Member = "GetImpactEffectTypeBasedOnMaterial")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[CallsUnknownMethods(Count = 4)]
	private static void LeaveScorchMark(RaycastHit hit)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "LeaveScorchMark")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	private static ScorchImpactEffectType GetImpactEffectTypeBasedOnMaterial(string tag)
	{
		return default(ScorchImpactEffectType);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateFuseBurnEffect(float burnPosition, float burnStrength)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private Vector3 GetInterpolatedPointAlongWick(float ratio)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NoiseMakerEffects()
	{
	}
}
