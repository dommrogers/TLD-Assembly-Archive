using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MissionInfoHUD : MonoBehaviour
{
	public static int OBJECT_POOL_SIZE;

	public GameObject m_MissionObjectivePrefab;

	public Transform m_MissionObjetivePoolParent;

	public Transform m_MissionObjetiveActiveObjects;

	public UILabel m_SelectedMissionName;

	public UISprite m_BorderSprite;

	public UILabel m_TimerLabel;

	public UISprite m_TimerBGSprite;

	public GameObject m_TimerObject;

	public Color m_TimerColorNormal;

	public Color m_TimerColorLowTime;

	public float m_SecondsToShow;

	public float m_SecondsToFadeOut;

	public float m_BorderSizeNameOnly;

	public float m_NameOffsetFromTimer;

	public float m_ObjectivesOffsetFromName;

	private UIWidget m_Widget;

	private List<StoryMissionObjective> m_ObjectivesToShow;

	private Vector3 m_LabelNamePosOrig;

	private Vector3 m_ObjectiveActiveObjectsPosOrig;

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 17)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void ShowOnHUD()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsNonRadialOverlayActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MissionInfoHUD()
	{
	}
}
