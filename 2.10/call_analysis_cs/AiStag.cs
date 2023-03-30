using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiStag : MonoBehaviour
{
	public StagType m_StagType;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AiStag()
	{
	}
}
