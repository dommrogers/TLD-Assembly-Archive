using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerAnimationContainer : MonoBehaviour
{
	public AnimatedInteraction m_SprayPaintAnimation;

	public AnimatedInteraction m_SprayPaintRemovalAnimation;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlayerAnimationContainer()
	{
	}
}
