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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnGUI()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MB_SwapShirts()
	{
	}
}
