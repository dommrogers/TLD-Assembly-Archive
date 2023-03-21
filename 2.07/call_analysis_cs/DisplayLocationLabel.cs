using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class DisplayLocationLabel : MonoBehaviour
{
	public LocalizedString m_LocalizedLabel;

	private PanelReference<Panel_HUD> m_HUD;

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
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "SerializeAll")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DisplayLocationLabel), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 7)]
	public static string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DisplayLocationLabel), Member = "Deserialize")]
	[Calls(Type = typeof(DisplayLocationLabel), Member = "FindDisplayLocationLabelByPosition")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(DisplayLocationLabel), Member = "FindDisplayLocationLabelByGuid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[Calls(Type = typeof(Knowledge), Member = "GetLocalizedKnowledgeCategoryName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Log), Member = "AddLocation")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[Calls(Type = typeof(MusicEventManager), Member = "PlayLocationSound")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Knowledge), Member = "Unlock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnTriggerExit(Collider c)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 9)]
	private static DisplayLocationLabel FindDisplayLocationLabelByPosition(DisplayLocationLabelSaveDataProxy proxy)
	{
		return null;
	}

	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private static DisplayLocationLabel FindDisplayLocationLabelByGuid(string guid)
	{
		return null;
	}

	[Calls(Type = typeof(Knowledge), Member = "Unlock")]
	[Calls(Type = typeof(Knowledge), Member = "GetLocalizedKnowledgeCategoryName")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeUnlockKnowledge()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DisplayLocationLabel()
	{
	}
}
