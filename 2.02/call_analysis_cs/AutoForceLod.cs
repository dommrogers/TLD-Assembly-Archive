using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AutoForceLod : MonoBehaviour
{
	public int m_LodLevel;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AutoForceLod()
	{
	}
}
