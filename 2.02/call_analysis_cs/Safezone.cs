using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Safezone : MonoBehaviour
{
	public GameObject m_SpriteSafezone;

	public static bool m_ShowSafeZone;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Safezone()
	{
	}
}
