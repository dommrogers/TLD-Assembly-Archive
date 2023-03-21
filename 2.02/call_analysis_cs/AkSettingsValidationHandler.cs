using Cpp2ILInjected.CallAnalysis;

public class AkSettingsValidationHandler
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void Validate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AkSettingsValidationHandler()
	{
	}
}
