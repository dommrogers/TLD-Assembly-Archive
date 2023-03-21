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

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 13)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public ClothSelector()
	{
	}
}
