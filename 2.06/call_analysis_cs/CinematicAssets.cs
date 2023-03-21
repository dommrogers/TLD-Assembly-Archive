using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CinematicAssets : MonoBehaviour
{
	public enum PermanentPropId
	{
		None,
		GM_Rifle,
		HOB_Knife,
		MET_Stick,
		JER_Radio
	}

	[Serializable]
	public class PropDataInfo
	{
		public GameObject m_PropPrefab;

		public PropOwnerType m_AssetType;

		public PermanentPropId m_PermanentPropId;

		public string m_PermanentPropMissionId;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public PropDataInfo()
		{
		}
	}

	[Serializable]
	public class PermanentPropInfo
	{
		public PermanentPropId m_PermanentPropId;

		public Animator m_Animator;

		public RuntimeAnimatorController m_OriginalController;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public PermanentPropInfo()
		{
		}
	}

	public class DialogueProp
	{
		public PropDataInfo m_Data;

		public GameObject m_LoadedPropAsset;

		public Animator m_LoadedAnimator;

		public PermanentPropInfo m_PermanentProp;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public DialogueProp()
		{
		}
	}

	public enum PropOwnerType
	{
		NPC,
		Player
	}

	public Animator m_NPC_Animator;

	public Animator m_Player_Animator;

	public List<PropDataInfo> m_Props;

	private List<DialogueProp> m_TransientProps;

	private List<DialogueProp> m_PermananentProps;

	private bool m_ArePropsLoaded;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ArePropsLoaded()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimationUtils), Member = "FindAnimatorByMissionId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadPermanentProp")]
	public PermanentPropInfo TryGetPermanentPropInfoFromMissionId(string missionId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public PermanentPropInfo GetPermanentPropInfo(PermanentPropId value, List<PermanentPropInfo> props)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadProp")]
	[Calls(Type = typeof(Utils), Member = "DisableRenderers")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CinematicAssets), Member = "RegisterAnimators")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadProps")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 9)]
	private bool LoadTransientProp(DialogueProp dialogueProp)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadProp")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadProps")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CinematicAssets), Member = "TryGetPermanentPropInfoFromMissionId")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool LoadPermanentProp(DialogueProp prop, List<PermanentPropInfo> permanentProps)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CinematicAssets), Member = "LoadTransientProp")]
	[Calls(Type = typeof(CinematicAssets), Member = "LoadPermanentProp")]
	[CallsUnknownMethods(Count = 2)]
	private void LoadProp(DialogueProp prop, List<PermanentPropInfo> permanentProps)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(CinematicTrack._003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[CalledBy(Type = typeof(DialogueModeRigFP._003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(CinematicAssets), Member = "LoadPermanentProp")]
	[Calls(Type = typeof(CinematicAssets), Member = "LoadTransientProp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void LoadProps(List<PermanentPropInfo> permanentProps)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(CinematicTrack._003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[CalledBy(Type = typeof(CinematicTrack._003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[CalledBy(Type = typeof(DialogueModeRigFP._003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	[CalledBy(Type = typeof(DialogueModeRigFP._003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void ReParentProp(PropOwnerType typeAsset, GameObject newParent)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UnloadCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(CinematicAssets), Member = "UnRegisterAnimators")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void UnloadProps()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "ReturnToIdleAnimation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[CallerCount(Count = 1)]
	public void SetTriggerOnLoadedPermanentProps(string trigger)
	{
	}

	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadTransientProp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void RegisterAnimators(DialogueProp dialogueProp)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "UnloadProps")]
	[CallsUnknownMethods(Count = 2)]
	private void UnRegisterAnimators(DialogueProp dialogueProp)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[CalledBy(Type = typeof(CinematicTrack._003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void UseLoadedControllerAndResumeState()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	public void RestoreOriginalControllerAndResumeState()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CinematicAssets), Member = "LateSynchronizeAnimators")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "LateSynchronizeAnimators")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	private void SynchronizePropAnimation(Animator animator, PlayEventMonitor playEventMonitor, float currentTime)
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsNPC")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsFP")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsFP")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsNPC")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LateSynchronizeAnimators")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(CinematicAssets), Member = "SynchronizePropAnimation")]
	[Calls(Type = typeof(CinematicAssets), Member = "SynchronizePropAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LateSynchronizeAnimators")]
	public void LateSynchronizeAnimators(PropOwnerType typeAsset, float currentTime, PlayEventMonitor playEventMonitor)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public CinematicAssets()
	{
	}
}
