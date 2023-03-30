using Cpp2ILInjected.CallAnalysis;

public class UISDAtlas : UIAtlas
{
	public float m_ReductionFactor;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIAtlas), Member = ".ctor")]
	public UISDAtlas()
	{
	}
}
