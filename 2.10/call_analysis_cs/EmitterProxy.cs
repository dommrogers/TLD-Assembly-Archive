using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EmitterProxy : MonoBehaviour
{
	public GameObject m_Proxy;

	public AkGameObj m_AkGameObj;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public EmitterProxy()
	{
	}
}
