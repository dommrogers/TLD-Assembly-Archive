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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNPCAffliction")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionUtils), Member = "PostAfflictionEvent")]
	public void AfflictionDiagnosed(NPCAffliction affliction)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 10)]
	public bool AreAllAfflictionTreated()
	{
		return default(bool);
	}

	[CallerCount(Count = 23)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private NPCAffliction GetNPCAffliction(AfflictionType afflictionType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void HealedAffliction(AfflictionType afflictionType)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NPCAfflictions), Member = "RemoveAffliction")]
	[Calls(Type = typeof(MissionUtils), Member = "PostAfflictionEvent")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AreAllAfflictionTreated")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 3)]
	public void HealedAffliction(NPCAffliction affliction)
	{
	}

	[CalledBy(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "RemoveAffliction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	private void RemoveAffliction(NPCAffliction affliction)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(NPCCondition), Member = "GetAdjustedMaxHP")]
	[CallsUnknownMethods(Count = 9)]
	public float GetTotalHitPointReduction()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(BodyCarry), Member = "DiagnoseCallback")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(NPC), Member = "ProcessInteraction")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(NPCAfflictions), Member = "SelectApproachSide")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	public void StartDiagnosing()
	{
	}

	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ExitInterface")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void EndDiagnosing()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(NPCAffliction), Member = "Save")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(NPC), Member = "Serialize")]
	[CallsUnknownMethods(Count = 14)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(NPC), Member = "Deserialize")]
	[Calls(Type = typeof(NPCAffliction), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByType")]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_bloodloss")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[CalledBy(Type = typeof(NPCThirst), Member = "DoUpdate")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(NPCThirst), Member = "StartDehydrationRiskAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	public void AddAffliction(AfflictionType afflictionType, string causeLocId, AfflictionBodyArea location)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	public void AddAffliction(string afflictionName, string causeLocId, AfflictionBodyArea location)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "RemoveAffliction")]
	public void RemoveAffliction(AfflictionType afflictionType)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	public void AddAffliction(AfflictionDefinition afflictionDefinition, string causeLocId, AfflictionBodyArea location)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDiagnoseOutroComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "Enable")]
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

	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SyncNode), Member = "OverlapsObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SyncNode), Member = "OverlapsObjects")]
	private void SelectApproachSide()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	private bool HasAfflictionType(AfflictionType afflictionType)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	public bool IsDehydrated()
	{
		return default(bool);
	}

	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallerCount(Count = 0)]
	public bool HasDehydrationRisk()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	public bool HasBloodLoss()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	public bool HasFrostbite()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHeathForBloodLoss")]
	[CallsUnknownMethods(Count = 4)]
	public int GetBloodLossCount()
	{
		return default(int);
	}

	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallerCount(Count = 0)]
	public bool HasHypothermia()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void AssignNpc(NPC npc)
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(NPC), Member = "Initialize")]
	[CallsUnknownMethods(Count = 46)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybeReparentAnimatedInteractions()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public NPCAfflictions()
	{
	}
}
