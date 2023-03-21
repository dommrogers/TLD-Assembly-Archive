using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_SwitchBakedObjectsTexture : MonoBehaviour
{
	public MeshRenderer targetRenderer;

	public Material[] materials;

	public MB3_MeshBaker meshBaker;

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[CallerCount(Count = 0)]
	public void OnGUI()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 12)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
