using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_SwapShirts : MonoBehaviour
{
	public MB3_MeshBaker meshBaker;

	public Renderer[] clothingAndBodyPartsBareTorso;

	public Renderer[] clothingAndBodyPartsBareTorsoDamagedArm;

	public Renderer[] clothingAndBodyPartsHoodie;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnGUI()
	{
	}

	[CallsUnknownMethods(Count = 40)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public MB_SwapShirts()
	{
	}
}
