using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class MissionInfo : MonoBehaviour
{
	public const string Label = "MissionInfo";

	public bool m_IsSideMission;

	public string m_MissionID;

	public string m_NameLocID;

	public string m_DescLocID;

	public string m_TextureName;

	public string m_TimerID;

	public string m_NPC_ID;

	public float m_TrustDecayGracePeriodHours;

	public string m_ChapterLocID;

	public bool m_ShowWhenCompleted;

	public string m_Icon;

	private static AsyncOperationHandle<IList<GameObject>> s_handles;

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "LoadMissionDataFromResources")]
	[CalledBy(Type = typeof(Utils), Member = "MaybePopulateMissionIds")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetsAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public static IList<MissionInfo> GetAllMissionInfos()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "LoadMissionDataFromResources")]
	[CalledBy(Type = typeof(Utils), Member = "MaybePopulateMissionIds")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	public static void ReleaseAllMissionInfos()
	{
	}

	[CallerCount(Count = 0)]
	public MissionInfo()
	{
	}
}
