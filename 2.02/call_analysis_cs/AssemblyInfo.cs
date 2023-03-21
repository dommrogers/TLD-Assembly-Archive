using Cpp2ILInjected.CallAnalysis;

public class AssemblyInfo
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public AssemblyInfo()
	{
	}
}
