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
	[CallsUnknownMethods(Count = 7)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 12)]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MB_SwapShirts()
	{
	}
}
