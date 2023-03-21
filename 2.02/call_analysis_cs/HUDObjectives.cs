using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HUDObjectives : MonoBehaviour
{
	public delegate void OnCompleteDelegate();

	private enum State
	{
		Inactive,
		Delay,
		Active,
		Hide
	}

	private struct StatusUpdate
	{
		public bool isSideMission;

		public string mission;

		public string objective;

		public MissionStatusType type;

		[CallerCount(Count = 0)]
		public void Clear()
		{
		}

		[CallerCount(Count = 0)]
		public bool IsValid()
		{
			return default(bool);
		}
	}

	public UILabel m_DetailsLabel;

	public UILabel m_MapHotkeyLabel;

	public Vector3 m_DetailsLabelOffset;

	public float m_DetailsLabelMoveDuration;

	public float m_InitialDisplayDelay;

	public MissionStatusDisplaySettings m_ObjectiveDisplaySettings;

	public MissionStatusDisplaySettings m_SideMissionDisplaySettings;

	public List<ObjectiveInfoDisplay> m_ObjectiveDisplays;

	public int m_EffectGroupHide;

	public int m_EffectGroupShow;

	public bool m_RestoreDisplay;

	public OnCompleteDelegate m_OnComplete;

	private List<UITweener> m_HideTweens;

	private List<UITweener> m_ShowTweens;

	private int m_ActiveTweens;

	private int m_ActiveDisplays;

	private float m_DisplayDelayTimer;

	private int m_PeakDisplays;

	private State m_State;

	private Queue<StatusUpdate> m_Queue;

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "SetupPopupPanels")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "OnHideTweenComplete")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Setup")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "ManualUpdate")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(ObjectiveInfoDisplay), Member = "Disable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 6)]
	public void Disable()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveDesc")]
	[Calls(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[Calls(Type = typeof(HUDMission), Member = "EnqueueObjective")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public void EnqueueObjective(MissionStatusType type, string id)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDMission), Member = "Enqueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	public void EnqueueSideMission(MissionStatusType type, string id)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	public string GetDebugText()
	{
		return null;
	}

	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void HideDisplay()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[Calls(Type = typeof(HUDObjectives), Member = "Disable")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CallsUnknownMethods(Count = 4)]
	public void ManualUpdate()
	{
	}

	[Calls(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Map), Member = "NoMapsUnlocked")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void RestoreDisplay()
	{
	}

	[Calls(Type = typeof(HUDObjectives), Member = "Disable")]
	[CallerCount(Count = 0)]
	public void Setup()
	{
	}

	[CallerCount(Count = 0)]
	public bool WantsUpdates()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	public string GetMissionId()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(ObjectiveInfoDisplay), Member = "Awake")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UITweener), Member = "AddOnFinished")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "AddOnFinished")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(HUDObjectives), Member = "Show")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(HUDObjectives), Member = "HideDisplay")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueSideMission")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "RestoreDisplay")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(MissionStatusDisplaySettings), Member = "GetLocID")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(MissionStatusDisplaySettings), Member = "GetLocID")]
	[Calls(Type = typeof(MissionStatusDisplaySettings), Member = "GetWwiseEvent")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(ObjectiveInfoDisplay), Member = "Show")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	private void Dequeue()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "OnObjectiveDisplayComplete")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	private void Hide()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(HUDObjectives), Member = "Disable")]
	private void OnHideTweenComplete()
	{
	}

	[Calls(Type = typeof(HUDObjectives), Member = "Hide")]
	[CallerCount(Count = 0)]
	private void OnObjectiveDisplayComplete()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Map), Member = "NoMapsUnlocked")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CallsUnknownMethods(Count = 11)]
	private void Show()
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public HUDObjectives()
	{
	}
}
