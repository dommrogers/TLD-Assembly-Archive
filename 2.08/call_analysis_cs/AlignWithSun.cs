using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AlignWithSun : MonoBehaviour
{
	public bool m_CenterOnPlayer;

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AlignWithSun()
	{
	}
}
