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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FeatsManager), Member = "InstantiateFeatPrefab")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "add_OnBeforeSerialization")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "add_OnAfterDeserialization")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FeatsManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	private void HandleSerialization(ProfileState profileState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FeatsManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	private void HandleDeserialization(ProfileState profileState)
	{
	}

	[CalledBy(Type = typeof(FeatsManager), Member = "HandleSerialization")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(FeatsManager), Member = "HandleDeserialization")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "GetNumUnlockedFeats")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public Feat GetFeatFromIndex(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumFeats()
	{
		return 0;
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileFeatData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public void ValidateSaveData(string serialized)
	{
	}

	[CalledBy(Type = typeof(FeatsManager), Member = "Awake")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private GameObject InstantiateFeatPrefab(GameObject prefab)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FeatsManager()
	{
	}
}
