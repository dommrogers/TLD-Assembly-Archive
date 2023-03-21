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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Awake()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionUtils), Member = "PostAfflictionEvent")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNPCAffliction")]
	[CallsUnknownMethods(Count = 2)]
	public void AfflictionDiagnosed(NPCAffliction affliction)
	{
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[CallerCount(Count = 2)]
	public bool AreAllAfflictionTreated()
	{
		return default(bool);
	}

	[CallerCount(Count = 29)]
	[CallsUnknownMethods(Count = 5)]
	private NPCAffliction GetNPCAffliction(AfflictionType afflictionType)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void HealedAffliction(AfflictionType afflictionType)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(MissionUtils), Member = "PostAfflictionEvent")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AreAllAfflictionTreated")]
	public void HealedAffliction(NPCAffliction affliction)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveAffliction(NPCAffliction affliction)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(NPCCondition), Member = "GetAdjustedMaxHP")]
	[CallerCount(Count = 1)]
	public float GetTotalHitPointReduction()
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BodyCarry), Member = "DiagnoseCallback")]
	[CalledBy(Type = typeof(NPC), Member = "PerformInteraction")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "SelectApproachSide")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	public void StartDiagnosing()
	{
	}

	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 1)]
	public void EndDiagnosing()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(NPC), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByType")]
	[Calls(Type = typeof(NPCAffliction), Member = "Load")]
	[CalledBy(Type = typeof(NPC), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 12)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCThirst), Member = "StartDehydrationRiskAffliction")]
	[CalledBy(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[CalledBy(Type = typeof(NPCThirst), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByType")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_npc_bloodloss")]
	public void AddAffliction(AfflictionType afflictionType, string causeLocId, AfflictionBodyArea location)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[CallerCount(Count = 0)]
	public void AddAffliction(string afflictionName, string causeLocId, AfflictionBodyArea location)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveAffliction(AfflictionType afflictionType)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CallerCount(Count = 3)]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "Enable")]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SyncNode), Member = "OverlapsObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SyncNode), Member = "OverlapsObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[CallsUnknownMethods(Count = 10)]
	private void SelectApproachSide()
	{
	}

	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHeathForBloodLoss")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CallerCount(Count = 2)]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void AssignNpc(NPC npc)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(NPC), Member = "Initialize")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeReparentAnimatedInteractions()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public NPCAfflictions()
	{
	}
}
