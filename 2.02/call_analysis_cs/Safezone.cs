using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Safezone : MonoBehaviour
{
	public GameObject m_SpriteSafezone;

	public static bool m_ShowSafeZone;

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Safezone()
	{
	}
}
