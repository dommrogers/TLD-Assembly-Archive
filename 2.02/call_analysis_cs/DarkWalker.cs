using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DarkWalker : MonoBehaviour
{
	public GameObject m_LookAtRotator;

	public Transform m_LeftFoot;

	public Transform m_RightFoot;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DarkWalker()
	{
	}
}
