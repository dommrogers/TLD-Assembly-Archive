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
			return false;
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
	[CalledBy(Type = typeof(HUDObjectives), Member = "Setup")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "OnHideTweenComplete")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "SetupPopupPanels")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ObjectiveInfoDisplay), Member = "Disable")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 19)]
	public void Disable()
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveDesc")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveTimer")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveComplete")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[Calls(Type = typeof(HUDMission), Member = "Dequeue")]
	[CallsUnknownMethods(Count = 4)]
	public void EnqueueObjective(MissionStatusType type, string id)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CallsUnknownMethods(Count = 2)]
	public void EnqueueSideMission(MissionStatusType type, string id)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public string GetDebugText()
	{
		return null;
	}

	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void HideDisplay()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(HUDObjectives), Member = "Disable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void ManualUpdate()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
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
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[CallsUnknownMethods(Count = 4)]
	public string GetMissionId()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "AddOnFinished")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ObjectiveInfoDisplay), Member = "Awake")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 52)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(HUDMission), Member = "Enqueue")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueObjective")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "EnqueueSideMission")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "RestoreDisplay")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(MissionStatusDisplaySettings), Member = "GetLocID")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(MissionStatusDisplaySettings), Member = "GetWwiseEvent")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(ObjectiveInfoDisplay), Member = "Show")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(HUDObjectives), Member = "Show")]
	[Calls(Type = typeof(HUDObjectives), Member = "HideDisplay")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 10)]
	private void Dequeue()
	{
	}

	[CalledBy(Type = typeof(HUDObjectives), Member = "OnObjectiveDisplayComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void Hide()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDObjectives), Member = "Disable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnHideTweenComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDObjectives), Member = "Hide")]
	private void OnObjectiveDisplayComplete()
	{
	}

	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	private void Show()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public HUDObjectives()
	{
	}
}
