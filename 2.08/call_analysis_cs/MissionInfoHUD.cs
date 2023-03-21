using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MissionInfoHUD : MonoBehaviour
{
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MissionInfoHUD()
	{
	}
}
