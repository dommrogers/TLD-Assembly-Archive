using Cpp2ILInjected.CallAnalysis;

public class AssemblyInfo
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AssemblyInfo()
	{
	}
}
