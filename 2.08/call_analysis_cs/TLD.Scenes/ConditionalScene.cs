using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.AddressableAssets;

namespace TLD.Scenes;

[Serializable]
public class ConditionalScene
{
	public AssetReference m_Scene;

	public SceneLoadCondition m_Condition;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ConditionalScene()
	{
	}
}
