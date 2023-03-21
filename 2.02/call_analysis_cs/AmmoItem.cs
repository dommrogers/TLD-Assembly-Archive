using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AmmoItem : MonoBehaviour
{
	public GunType m_AmmoForGunType;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AmmoItem()
	{
	}
}
