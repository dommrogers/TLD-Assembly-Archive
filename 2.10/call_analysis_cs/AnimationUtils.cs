using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimationUtils
{
	[CalledBy(Type = typeof(CinematicManager), Member = "SaveAnimationState")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetValueIn01(float value)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Start_Anim")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnableWeapon")]
	[CalledBy(Type = typeof(BaseAi), Member = "ResetWeapon")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterStruggle")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "SetTriggerOnLoadedPermanentProps")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetAnimationParameter_IsInDialogue")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReturnToIdleAnimation")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoTriggerAnimation")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "ReturnToIdleAnimation")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static bool HasParameter(Animator animator, int paramHash)
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "IsAnimationPlayingOnAnyLayer")]
	[CalledBy(Type = typeof(BodyCarry), Member = "IsPlayingCarryIdleAnimation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsStatePlayingOnAnyLayer(Animator animator, int stateHash)
	{
		return false;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsNPCReady")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsAnyLayerInAnimationTransition(Animator animator)
	{
		return false;
	}

	[CalledBy(Type = typeof(CinematicAssets), Member = "TryGetPermanentPropInfoFromMissionId")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadPermanentProp")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	public static Animator FindAnimatorByMissionId(string missionObjectId)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public AnimationUtils()
	{
	}
}
