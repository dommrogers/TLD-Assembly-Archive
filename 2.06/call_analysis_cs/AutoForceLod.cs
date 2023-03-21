using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AutoForceLod : MonoBehaviour
{
	public int m_LodLevel;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AutoForceLod()
	{
	}
}
