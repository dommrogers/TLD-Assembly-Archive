using Cpp2ILInjected.CallAnalysis;

public class qb_TemplateSignature
{
	public string name;

	public string directory;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public qb_TemplateSignature()
	{
	}
}
