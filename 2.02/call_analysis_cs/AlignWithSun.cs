using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AlignWithSun : MonoBehaviour
{
	public bool m_CenterOnPlayer;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 14)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AlignWithSun()
	{
	}
}
