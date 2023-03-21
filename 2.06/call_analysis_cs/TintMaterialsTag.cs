using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TintMaterialsTag : MonoBehaviour
{
	private string m_Tag;

	private Renderer[] m_Renderers;

	[DeduplicatedMethod]
	[CallerCount(Count = 44)]
	public string GetTag()
	{
		return null;
	}

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public Renderer[] GetRenderers()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public TintMaterialsTag()
	{
	}
}
