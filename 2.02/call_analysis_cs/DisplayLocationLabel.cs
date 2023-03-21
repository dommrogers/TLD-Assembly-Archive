using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DisplayLocationLabel : MonoBehaviour
{
	public LocalizedString m_LocalizedLabel;

	private bool m_DisplayedLabel;

	private bool m_Logged;

	private bool m_PlayedStinger;

	private float m_NextValidDisplayTime;

	private bool m_HasDoneFirstFrame;

	private bool m_DoUpdate;

	private bool m_StartHasBeenCalled;

	private static DisplayLocationLabelSaveDataProxy m_DisplayLocationLabelSaveDataProxy;

	private static List<DisplayLocationLabel> m_DisplayLocationLabels;

	public string m_Label
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 10)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 4)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DisplayLocationLabel), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 17)]
	public static string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(DisplayLocationLabel), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DisplayLocationLabel), Member = "FindDisplayLocationLabelByGuid")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DisplayLocationLabel), Member = "FindDisplayLocationLabelByPosition")]
	public static void DeserializeAll(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsLogged()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void DebugMarkLogged()
	{
	}

	[Calls(Type = typeof(MusicEventManager), Member = "PlayLocationSound")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(DisplayLocationLabel), Member = "MaybeUnlockKnowledge")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Log), Member = "AddLocation")]
	[CallsUnknownMethods(Count = 26)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnTriggerExit(Collider c)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 7)]
	private static DisplayLocationLabel FindDisplayLocationLabelByPosition(DisplayLocationLabelSaveDataProxy proxy)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	private static DisplayLocationLabel FindDisplayLocationLabelByGuid(string guid)
	{
		return null;
	}

	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(Knowledge), Member = "Unlock")]
	[Calls(Type = typeof(Knowledge), Member = "GetLocalizedKnowledgeCategoryName")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeUnlockKnowledge()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DisplayLocationLabel()
	{
	}
}
