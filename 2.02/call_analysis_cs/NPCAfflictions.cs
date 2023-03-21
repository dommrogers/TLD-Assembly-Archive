using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCAfflictions : MonoBehaviour
{
	public enum UIOutlineType
	{
		Female01,
		Female02,
		Male01,
		Male02
	}

	private enum ApproachSideSelected
	{
		None,
		SideLeft,
		SideRight
	}

	public UIOutlineType m_UIOutline;

	public List<NPCAffliction> m_Afflictions;

	public bool m_MustCureBeforeCarry;

	public AnimatedInteraction m_DiagnoseIntroLeft;

	public AnimatedInteraction m_DiagnoseOutroLeft;

	public AnimatedInteraction m_DiagnoseIntroRight;

	public AnimatedInteraction m_DiagnoseOutroRight;

	public bool m_ReparentAnimatedInteractionsToNPCParent;

	private NPC m_NPC;

	private ApproachSideSelected m_ApproachSideSelected;

	private SyncNode m_SyncNodeLeft;

	private SyncNode m_SyncNodeRight;

	private Transform m_DiagnoseIntroLeftOriginalParent;

	private Transform m_DiagnoseIntroRightOriginalParent;

	private Transform m_DiagnoseOutroLeftOriginalParent;

	private Transform m_DiagnoseOutroRightOriginalParent;

	private Collider[] m_ResultColliders;

	private const int MAX_COLLIDERS_COUNT = 5;

	private const float m_CharacterRadius = 0.5f;

	private const float m_CharacterHeight = 1.75f;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 20)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNPCAffliction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionUtils), Member = "PostAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AfflictionDiagnosed(NPCAffliction affliction)
	{
	}

	[CalledBy(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public bool AreAllAfflictionTreated()
	{
		return false;
	}

	[CalledBy(Type = typeof(NPCStatusBar), Member = "IsDebuffActive")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "RemoveAffliction")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "RemoveAffliction")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HasAfflictionType")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "IsDehydrated")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HasDehydrationRisk")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HasBloodLoss")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HasFrostbite")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HasHypothermia")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCThirst), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCThirst), Member = "ApplyTODHours")]
	[CalledBy(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private NPCAffliction GetNPCAffliction(AfflictionType afflictionType)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void HealedAffliction(AfflictionType afflictionType)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NPCAfflictions), Member = "RemoveAffliction")]
	[Calls(Type = typeof(MissionUtils), Member = "PostAfflictionEvent")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AreAllAfflictionTreated")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void HealedAffliction(NPCAffliction affliction)
	{
	}

	[CalledBy(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "RemoveAffliction")]
	[CalledBy(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void RemoveAffliction(NPCAffliction affliction)
	{
	}

	[CalledBy(Type = typeof(NPCCondition), Member = "GetAdjustedMaxHP")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public float GetTotalHitPointReduction()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(NPC), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(BodyCarry), Member = "DiagnoseCallback")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NPCAfflictions), Member = "SelectApproachSide")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void StartDiagnosing()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ExitInterface")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public void EndDiagnosing()
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(NPCAffliction), Member = "Save")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(NPC), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NPCAffliction), Member = "Load")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_bloodloss")]
	[CalledBy(Type = typeof(NPCThirst), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[CalledBy(Type = typeof(NPCThirst), Member = "StartDehydrationRiskAffliction")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddAffliction(AfflictionType afflictionType, string causeLocId, AfflictionBodyArea location)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddAffliction(string afflictionName, string causeLocId, AfflictionBodyArea location)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "RemoveAffliction")]
	public void RemoveAffliction(AfflictionType afflictionType)
	{
	}

	[CalledBy(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void AddAffliction(AfflictionDefinition afflictionDefinition, string causeLocId, AfflictionBodyArea location)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDiagnoseOutroComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDiagnoseIntroComplete()
	{
	}

	[CallerCount(Count = 0)]
	private AnimatedInteraction GetSelectedIntro()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private AnimatedInteraction GetSelectedOutro()
	{
		return null;
	}

	[CalledBy(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SyncNode), Member = "OverlapsObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 23)]
	private void SelectApproachSide()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	private bool HasAfflictionType(AfflictionType afflictionType)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	public bool IsDehydrated()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	public bool HasDehydrationRisk()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	public bool HasBloodLoss()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	public bool HasFrostbite()
	{
		return false;
	}

	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHeathForBloodLoss")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public int GetBloodLossCount()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	public bool HasHypothermia()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void AssignNpc(NPC npc)
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 46)]
	private void MaybeReparentAnimatedInteractions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public NPCAfflictions()
	{
	}
}
