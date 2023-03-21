using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ClothSelector : MonoBehaviour
{
	public enum ClothType
	{
		Physics,
		Fast
	}

	private Cloth m_PhysicsCloth;

	private FastCloth m_FastCloth;

	private ClothType m_Default;

	private ClothType m_NintendoSwitch;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	public ClothSelector()
	{
	}
}
