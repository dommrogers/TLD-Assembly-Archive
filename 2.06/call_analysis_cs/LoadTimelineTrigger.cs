using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;

public class LoadTimelineTrigger : MonoBehaviour
{
	public AssetReferenceTimeline[] m_Timelines;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "LoadTimeline")]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public LoadTimelineTrigger()
	{
	}
}
