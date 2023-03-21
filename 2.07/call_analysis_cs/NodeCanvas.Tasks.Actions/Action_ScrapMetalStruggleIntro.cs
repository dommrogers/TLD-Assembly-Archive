using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_ScrapMetalStruggleIntro : ActionTask
{
	public GameObject m_PropPrefab;

	private GameObject m_SpawnedProp;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_ScrapMetalStruggleIntro), Member = "MaybeSpawnProp")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(Action_ScrapMetalStruggleIntro), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeSpawnProp()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_ScrapMetalStruggleIntro()
	{
	}
}
