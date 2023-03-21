using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;

public class LoadTimelineTrigger : MonoBehaviour
{
	public AssetReferenceTimeline[] m_Timelines;

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "LoadTimeline")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "get_IsLoaded")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LoadTimelineTrigger()
	{
	}
}
