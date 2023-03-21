using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimationUtils
{
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(CinematicManager), Member = "SaveAnimationState")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetValueIn01(float value)
	{
		return default(float);
	}

	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static bool HasParameter(Animator animator, int paramHash)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "IsAnimationPlayingOnAnyLayer")]
	[CalledBy(Type = typeof(BodyCarry), Member = "IsPlayingCarryIdleAnimation")]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsStatePlayingOnAnyLayer(Animator animator, int stateHash)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsNPCReady")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsNPCReady")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	public static bool IsAnyLayerInAnimationTransition(Animator animator)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadPermanentProp")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "TryGetPermanentPropInfoFromMissionId")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
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
