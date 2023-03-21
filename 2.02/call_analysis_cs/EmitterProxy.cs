using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EmitterProxy : MonoBehaviour
{
	public GameObject m_Proxy;

	public AkGameObj m_AkGameObj;

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public EmitterProxy()
	{
	}
}
