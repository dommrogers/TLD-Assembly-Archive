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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Reset()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(RopeAnchorPoint), Member = "SnapRope")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "DeserializeAll")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "Start")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 7)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "FindByGuid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CallsUnknownMethods(Count = 3)]
	public static RopeAnchorPoint LookupAnchorPointFromRope(Rope r)
	{
		return null;
	}

	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SnapRope()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "SnapRope")]
	[Calls(Type = typeof(RopeLedge), Member = "SetActiveInitial")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Start")]
	private void SetRopeActiveState(bool state, bool isInteraction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	public void CancelAction()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void PerformInteraction()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Inventory), Member = "GetBestRopeItem")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ActionStarted(RopeAnchorActionState action)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "CancelAction")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Update")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Inventory), Member = "GetBestRopeItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void ActionFinished()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "DeserializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	private static RopeAnchorPoint FindByGuid(string guid)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RopeAnchorPoint()
	{
	}
}
