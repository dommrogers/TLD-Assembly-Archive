using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_SwitchBakedObjectsTexture : MonoBehaviour
{
	public MeshRenderer targetRenderer;

	public Material[] materials;

	public MB3_MeshBaker meshBaker;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	public void OnGUI()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 21)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
