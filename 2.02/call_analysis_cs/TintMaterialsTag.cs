using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TintMaterialsTag : MonoBehaviour
{
	private string m_Tag;

	private Renderer[] m_Renderers;

	[DeduplicatedMethod]
	[CallerCount(Count = 35)]
	public string GetTag()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
	public Renderer[] GetRenderers()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TintMaterialsTag()
	{
	}
}
