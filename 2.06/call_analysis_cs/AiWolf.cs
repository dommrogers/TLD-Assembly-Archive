using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiWolf : MonoBehaviour
{
	public WolfType m_WolfType;

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AiWolf()
	{
	}
}
