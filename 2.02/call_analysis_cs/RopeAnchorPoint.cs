using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RopeAnchorPoint : MonoBehaviour
{
	public Rope m_Rope;

	public Rope m_RopeShort;

	public bool m_RopeDeployed;

	public float m_ProgressBarDurationSeconds;

	public string m_Audio_DeployRope;

	public string m_Audio_TakeRope;

	private static List<RopeAnchorPoint> m_RopeAnchorPoints;

	private RopeAnchorActionState m_ActionState;

	private float m_ActionTimerSeconds;

	private float m_StoredDayLengthScale;

	private bool m_TimeAccelerated;

	private uint m_ActionAudioID;

	private bool m_StartHasBeenCalled;

	private bool m_RopeSnapped;

	private static RopeAnchorPointSaveData m_RopeAnchorPointSaveData;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "SerializeAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SnapRope")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "Serialize")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "FindByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 10)]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static RopeAnchorPoint LookupAnchorPointFromRope(Rope r)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	public string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public void SnapRope()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "ActionStarted")]
	[CallerCount(Count = 1)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "SnapRope")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Start")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RopeLedge), Member = "SetActiveInitial")]
	private void SetRopeActiveState(bool state, bool isInteraction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	public void CancelAction()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ProcessInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(TimeOfDay), Member = "Accelerate")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "GetBestRopeItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private void ActionStarted(RopeAnchorActionState action)
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "CancelAction")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Update")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetBestRopeItem")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	private void ActionFinished()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "DeserializeAll")]
	private static RopeAnchorPoint FindByGuid(string guid)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RopeAnchorPoint()
	{
	}
}
