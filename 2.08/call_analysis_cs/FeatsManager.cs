using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
using TLD.Serialization;
using UnityEngine;

public class FeatsManager : MonoBehaviour
{
	public GameObject m_Feat_BookSmarts_Prefab;

	public GameObject m_Feat_ColdFusion_Prefab;

	public GameObject m_Feat_EfficientMachine_Prefab;

	public GameObject m_Feat_FireMaster_Prefab;

	public GameObject m_Feat_FreeRunner_Prefab;

	public GameObject m_Feat_SnowWalker_Prefab;

	public GameObject m_Feat_ExpertTrapper_Prefab;

	public GameObject m_Feat_StraightToHeart_Prefab;

	public GameObject m_Feat_BlizzardWalker_Prefab;

	public GameObject m_Feat_NightWalker_Prefab;

	public static Feat_BookSmarts m_Feat_BookSmarts;

	public static Feat_ColdFusion m_Feat_ColdFusion;

	public static Feat_EfficientMachine m_Feat_EfficientMachine;

	public static Feat_FireMaster m_Feat_FireMaster;

	public static Feat_FreeRunner m_Feat_FreeRunner;

	public static Feat_SnowWalker m_Feat_SnowWalker;

	public static Feat_ExpertTrapper m_Feat_ExpertTrapper;

	public static Feat_StraightToHeart m_Feat_StraightToHeart;

	public static Feat_BlizzardWalker m_Feat_BlizzardWalker;

	public static Feat_NightWalker m_Feat_NightWalker;

	private static bool m_InsantiatedFeats;

	private static List<Feat> m_Feats;

	private static FeatsManagerSaveData m_FeatsManagerSaveData;

	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FeatsManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	private void HandleSerialization(ProfileState profileState)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FeatsManager), Member = "Deserialize")]
	private void HandleDeserialization(ProfileState profileState)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FeatsManager), Member = "HandleSerialization")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(FeatsManager), Member = "HandleDeserialization")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 11)]
	public void Deserialize(string text)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(FeatEnabledTracker), Member = "Deserialize")]
	[CalledBy(Type = typeof(FeatEnabledTracker), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSelectedFeats")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_unlock_all")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetFeat")]
	[CallerCount(Count = 5)]
	public Feat GetFeat(FeatType featType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "GetNumUnlockedFeats")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsContinue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	public Feat GetFeatFromIndex(int index)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumFeats()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileFeatData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 11)]
	public void ValidateSaveData(string serialized)
	{
	}

	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 10)]
	private GameObject InstantiateFeatPrefab(GameObject prefab)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FeatsManager()
	{
	}
}
