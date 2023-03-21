using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
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

	private Panel_HUD m_HUD;

	private PanelReference<Panel_Map> m_Map;

	private PanelReference<Panel_MissionsStory> m_MissionsStory;

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

	[CalledBy(Type = typeof(HUDObjectives), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "SetupPopupPanels")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "OnHideTweenComplete")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Setup")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(ObjectiveInfoDisplay), Member = "Disable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void Disable()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveDesc")]
	[Calls(Type = typeof(HUDMission), Member = "Dequeue")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[Calls(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	public void EnqueueObjective(MissionStatusType type, string id)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CallsUnknownMethods(Count = 2)]
	public void EnqueueSideMission(MissionStatusType type, string id)
	{
	}

	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetDebugText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[Calls(Type = typeof(HUDObjectives), Member = "Disable")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CallsUnknownMethods(Count = 5)]
	public void ManualUpdate()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public void RestoreDisplay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDObjectives), Member = "Disable")]
	public void Setup()
	{
	}

	[CallerCount(Count = 0)]
	public bool WantsUpdates()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallsUnknownMethods(Count = 5)]
	public string GetMissionId()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(ObjectiveInfoDisplay), Member = "Awake")]
	[Calls(Type = typeof(UITweener), Member = "AddOnFinished")]
	[Calls(Type = typeof(UITweener), Member = "AddOnFinished")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "RestoreDisplay")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueSideMission")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[CalledBy(Type = typeof(HUDMission), Member = "Enqueue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(HUDObjectives), Member = "HideDisplay")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[Calls(Type = typeof(HUDObjectives), Member = "Show")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(MissionStatusDisplaySettings), Member = "GetWwiseEvent")]
	[Calls(Type = typeof(MissionStatusDisplaySettings), Member = "GetLocID")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(MissionStatusDisplaySettings), Member = "GetLocID")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ObjectiveInfoDisplay), Member = "Show")]
	private void Dequeue()
	{
	}

	[CalledBy(Type = typeof(HUDObjectives), Member = "OnObjectiveDisplayComplete")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	private void Hide()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HUDObjectives), Member = "Disable")]
	[CallsUnknownMethods(Count = 1)]
	private void OnHideTweenComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDObjectives), Member = "Hide")]
	private void OnObjectiveDisplayComplete()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void Show()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public HUDObjectives()
	{
	}
}
