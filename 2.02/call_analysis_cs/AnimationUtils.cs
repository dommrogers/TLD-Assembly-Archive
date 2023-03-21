using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimationUtils
{
	[CalledBy(Type = typeof(CinematicManager), Member = "SaveAnimationState")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static float GetValueIn01(float value)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 20)]
	public static bool HasParameter(Animator animator, int paramHash)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "IsAnimationPlayingOnAnyLayer")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool IsStatePlayingOnAnyLayer(Animator animator, int stateHash)
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Animator), Member = "IsInTransition")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsNPCReady")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "IsNPCReady")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public static bool IsAnyLayerInAnimationTransition(Animator animator)
	{
		return default(bool);
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "TryGetPermanentPropInfoFromMissionId")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public static Animator FindAnimatorByMissionId(string missionObjectId)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AnimationUtils()
	{
	}
}
