using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB3_BoneWeightCopier : MonoBehaviour
{
	public GameObject inputGameObject;

	public GameObject outputPrefab;

	public float radius;

	public SkinnedMeshRenderer seamMesh;

	public string outputFolder;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MB3_BoneWeightCopier()
	{
	}
}
