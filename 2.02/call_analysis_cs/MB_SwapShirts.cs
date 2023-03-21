using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_SwapShirts : MonoBehaviour
{
	public MB3_MeshBaker meshBaker;

	public Renderer[] clothingAndBodyPartsBareTorso;

	public Renderer[] clothingAndBodyPartsBareTorsoDamagedArm;

	public Renderer[] clothingAndBodyPartsHoodie;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnGUI()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 42)]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public MB_SwapShirts()
	{
	}
}
