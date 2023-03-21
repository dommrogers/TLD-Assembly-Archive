using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DarkWalker : MonoBehaviour
{
	public GameObject m_LookAtRotator;

	public Transform m_LeftFoot;

	public Transform m_RightFoot;

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public DarkWalker()
	{
	}
}
