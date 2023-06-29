using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Scenes.ObjectReferences;

public class SceneObjectReferenceOwnerAttribute : PropertyAttribute
{
	private readonly string m_BaseAssetPath;

	public string BaseAssetPath
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 86)]
	public SceneObjectReferenceOwnerAttribute(string baseAssetPath)
	{
	}
}
