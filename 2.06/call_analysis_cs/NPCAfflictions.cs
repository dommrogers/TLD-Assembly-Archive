using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
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

	private PanelReference<Panel_Diagnosis> m_Diagnosis;

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

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(MissionUtils), Member = "PostAfflictionEvent")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNPCAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	public void AfflictionDiagnosed(NPCAffliction affliction)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 10)]
	public bool AreAllAfflictionTreated()
	{
		return default(bool);
	}

	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "RemoveAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private void RemoveAffliction(NPCAffliction affliction)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCCondition), Member = "GetAdjustedMaxHP")]
	[CallsUnknownMethods(Count = 9)]
	public float GetTotalHitPointReduction()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BodyCarry), Member = "DiagnoseCallback")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(NPC), Member = "PerformInteraction")]
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

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public void EndDiagnosing()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NPCAffliction), Member = "Save")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(NPC), Member = "Serialize")]
	[CallsUnknownMethods(Count = 12)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(NPC), Member = "Deserialize")]
	[Calls(Type = typeof(NPCAffliction), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByType")]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(NPCThirst), Member = "StartDehydrationRiskAffliction")]
	[CalledBy(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_bloodloss")]
	[CalledBy(Type = typeof(NPCThirst), Member = "DoUpdate")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByType")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void AddAffliction(AfflictionType afflictionType, string causeLocId, AfflictionBodyArea location)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 1)]
	public void AddAffliction(string afflictionName, string causeLocId, AfflictionBodyArea location)
	{
	}

	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "RemoveAffliction")]
	public void RemoveAffliction(AfflictionType afflictionType)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	public void AddAffliction(AfflictionDefinition afflictionDefinition, string causeLocId, AfflictionBodyArea location)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDiagnoseOutroComplete()
	{
	}

	[Calls(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SyncNode), Member = "OverlapsObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 11)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	public bool HasDehydrationRisk()
	{
		return default(bool);
	}

	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallerCount(Count = 0)]
	public bool HasBloodLoss()
	{
		return default(bool);
	}

	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallerCount(Count = 0)]
	public bool HasFrostbite()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHeathForBloodLoss")]
	[CallsUnknownMethods(Count = 4)]
	public int GetBloodLossCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	public bool HasHypothermia()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void AssignNpc(NPC npc)
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(NPC), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybeReparentAnimatedInteractions()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public NPCAfflictions()
	{
	}
}
