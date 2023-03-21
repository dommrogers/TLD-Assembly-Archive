using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MegaWireWatch : MonoBehaviour
{
	public bool realtime;

	public GameObject watch;

	public Matrix4x4 mat;

	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(MegaWirePlantPolesList), Member = "Rebuild")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public MegaWireWatch()
	{
	}
}
