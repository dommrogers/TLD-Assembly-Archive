using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiStag : MonoBehaviour
{
	public StagType m_StagType;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AiStag()
	{
	}
}
