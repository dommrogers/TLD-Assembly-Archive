using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiWolf : MonoBehaviour
{
	public WolfType m_WolfType;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AiWolf()
	{
	}
}
