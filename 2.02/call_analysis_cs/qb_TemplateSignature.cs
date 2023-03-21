using Cpp2ILInjected.CallAnalysis;

public class qb_TemplateSignature
{
	public string name;

	public string directory;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public qb_TemplateSignature()
	{
	}
}
