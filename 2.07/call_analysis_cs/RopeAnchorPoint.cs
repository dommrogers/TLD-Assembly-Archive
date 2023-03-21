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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "Start")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SnapRope")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "FindByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static RopeAnchorPoint LookupAnchorPointFromRope(Rope r)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CallsUnknownMethods(Count = 1)]
	public void SnapRope()
	{
	}

	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "SnapRope")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Start")]
	[Calls(Type = typeof(RopeLedge), Member = "SetActiveInitial")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	private void SetRopeActiveState(bool state, bool isInteraction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	public void CancelAction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void PerformInteraction()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Inventory), Member = "GetBestRopeItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private void ActionStarted(RopeAnchorActionState action)
	{
	}

	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "CancelAction")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Update")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "GetBestRopeItem")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	private void ActionFinished()
	{
	}

	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private static RopeAnchorPoint FindByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RopeAnchorPoint()
	{
	}
}
