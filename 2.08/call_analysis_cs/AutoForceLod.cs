using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AutoForceLod : MonoBehaviour
{
	public int m_LodLevel;

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AutoForceLod()
	{
	}
}
