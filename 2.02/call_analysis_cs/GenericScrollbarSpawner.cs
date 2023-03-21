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

	[CallsUnknownMethods(Count = 60)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 41)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	private void OnDragFinished()
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public GenericScrollbarSpawner()
	{
	}
}
