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
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ClothSelector()
	{
	}
}
