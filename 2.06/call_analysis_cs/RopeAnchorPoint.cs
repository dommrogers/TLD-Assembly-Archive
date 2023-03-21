using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class RopeAnchorPoint : MonoBehaviour
{
	public Rope m_Rope;

	public Rope m_RopeShort;

	public bool m_RopeDeployed;

	public float m_ProgressBarDurationSeconds;

	public string m_Audio_DeployRope;

	public string m_Audio_TakeRope;

	private static readonly List<RopeAnchorPoint> s_RopeAnchorPoints;

	private RopeAnchorActionState m_ActionState;

	private float m_ActionTimerSeconds;

	private float m_StoredDayLengthScale;

	private bool m_TimeAccelerated;

	private uint m_ActionAudioID;

	private bool m_StartHasBeenCalled;

	private bool m_RopeSnapped;

	private Panel_HUD m_HUD;

	private static RopeAnchorPointSaveData m_RopeAnchorPointSaveData;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "DeserializeAll")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SnapRope")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "Start")]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetObjectGuidFromGO")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 11)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "FindByGuid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static RopeAnchorPoint LookupAnchorPointFromRope(Rope r)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SnapRope()
	{
	}

	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RopeLedge), Member = "SetActiveInitial")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Start")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "SnapRope")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CallsUnknownMethods(Count = 9)]
	private void SetRopeActiveState(bool state, bool isInteraction)
	{
	}

	[Calls(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CallerCount(Count = 0)]
	public void CancelAction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void PerformInteraction()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Inventory), Member = "GetBestRopeItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private void ActionStarted(RopeAnchorActionState action)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Update")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Update")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "CancelAction")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Inventory), Member = "GetBestRopeItem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ActionFinished()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	private static RopeAnchorPoint FindByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public RopeAnchorPoint()
	{
	}
}
