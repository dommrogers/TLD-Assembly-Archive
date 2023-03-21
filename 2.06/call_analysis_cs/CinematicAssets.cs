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
		return false;
	}

	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadPermanentProp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationUtils), Member = "FindAnimatorByMissionId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public PermanentPropInfo TryGetPermanentPropInfoFromMissionId(string missionId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public PermanentPropInfo GetPermanentPropInfo(PermanentPropId value, List<PermanentPropInfo> props)
	{
		return null;
	}

	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadProp")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadProps")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(CinematicAssets), Member = "RegisterAnimators")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "DisableRenderers")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 9)]
	private bool LoadTransientProp(DialogueProp dialogueProp)
	{
		return false;
	}

	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadProp")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadProps")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CinematicAssets), Member = "TryGetPermanentPropInfoFromMissionId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 10)]
	private bool LoadPermanentProp(DialogueProp prop, List<PermanentPropInfo> permanentProps)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CinematicAssets), Member = "LoadTransientProp")]
	[Calls(Type = typeof(CinematicAssets), Member = "LoadPermanentProp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void LoadProp(DialogueProp prop, List<PermanentPropInfo> permanentProps)
	{
	}

	[CalledBy(TypeFullName = "DialogueModeRigFP.<LoadAnimations>d__250", Member = "MoveNext")]
	[CalledBy(TypeFullName = "CinematicTrack.<LoadAnimations>d__66", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(CinematicAssets), Member = "LoadTransientProp")]
	[Calls(Type = typeof(CinematicAssets), Member = "LoadPermanentProp")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void LoadProps(List<PermanentPropInfo> permanentProps)
	{
	}

	[CalledBy(TypeFullName = "DialogueModeRigFP.<LoadAnimations>d__250", Member = "MoveNext")]
	[CalledBy(TypeFullName = "CinematicTrack.<LoadAnimations>d__66", Member = "MoveNext")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void ReParentProp(PropOwnerType typeAsset, GameObject newParent)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UnloadCinematic")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicAssets), Member = "UnRegisterAnimators")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void UnloadProps()
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "ReturnToIdleAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetTriggerOnLoadedPermanentProps(string trigger)
	{
	}

	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadTransientProp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RegisterAnimators(DialogueProp dialogueProp)
	{
	}

	[CalledBy(Type = typeof(CinematicAssets), Member = "UnloadProps")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UnRegisterAnimators(DialogueProp dialogueProp)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(TypeFullName = "CinematicTrack.<LoadAnimations>d__66", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[CallsUnknownMethods(Count = 4)]
	public void UseLoadedControllerAndResumeState()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ReplaceAnimControllerAndResumeState")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[CallsUnknownMethods(Count = 4)]
	public void RestoreOriginalControllerAndResumeState()
	{
	}

	[CalledBy(Type = typeof(CinematicAssets), Member = "LateSynchronizeAnimators")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CallsUnknownMethods(Count = 1)]
	private void SynchronizePropAnimation(Animator animator, PlayEventMonitor playEventMonitor, float currentTime)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "LateSynchronizeAnimators")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsNPC")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsFP")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicAssets), Member = "SynchronizePropAnimation")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
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
