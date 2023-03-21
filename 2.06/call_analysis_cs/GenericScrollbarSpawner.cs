using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GenericScrollbarSpawner : MonoBehaviour
{
	public GameObject m_Prefab;

	public Vector3 m_UpButtonPos;

	public Vector3 m_DownButtonPos;

	public Vector3 m_ColliderSize;

	public Vector2 m_SliderSize;

	public Vector2 m_GlowSize;

	public List<EventDelegate> onClickUp;

	public List<EventDelegate> onClickDown;

	public List<EventDelegate> onChange;

	public List<EventDelegate> onDragFinished;

	public Color m_ButtonColorNormal;

	public Color m_ButtonColorHover;

	public Color m_ButtonColorPressed;

	public Color m_ScrollbarColor;

	public Color m_ScrollbarBGColor;

	public Color m_ScrollbarGlowColor;

	public GameObject m_SpawnedObject;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 41)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 0)]
	private void OnDragFinished()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	public GenericScrollbarSpawner()
	{
	}
}
