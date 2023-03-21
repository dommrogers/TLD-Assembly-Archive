using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HuntedBearHPUpdate : MonoBehaviour
{
	private BaseAi m_BaseAi;

	private MissionManagerBase m_MissionManager;

	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public HuntedBearHPUpdate()
	{
	}
}
