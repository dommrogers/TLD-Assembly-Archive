using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiStag : MonoBehaviour
{
	public StagType m_StagType;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public AiStag()
	{
	}
}
