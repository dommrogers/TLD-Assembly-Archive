using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Deserialize")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeFeats")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(FeatEnabledTracker), Member = "Deserialize")]
	[CalledBy(Type = typeof(FeatEnabledTracker), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSelectedFeats")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_unlock_all")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetFeat")]
	public Feat GetFeat(FeatType featType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "GetNumUnlockedFeats")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	public Feat GetFeatFromIndex(int index)
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "GetNumUnlockedFeats")]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumFeats()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 22)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileFeatData")]
	public void ValidateSaveData(string serialized)
	{
	}

	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 10)]
	private GameObject InstantiateFeatPrefab(GameObject prefab)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public FeatsManager()
	{
	}
}
