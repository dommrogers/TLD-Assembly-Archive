using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AlignWithSun : MonoBehaviour
{
	public bool m_CenterOnPlayer;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AlignWithSun()
	{
	}
}
