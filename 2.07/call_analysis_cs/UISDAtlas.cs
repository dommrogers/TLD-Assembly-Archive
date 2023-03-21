using Cpp2ILInjected.CallAnalysis;

public class UISDAtlas : UIAtlas
{
	public float m_ReductionFactor;

	[Calls(Type = typeof(UIAtlas), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public UISDAtlas()
	{
	}
}
