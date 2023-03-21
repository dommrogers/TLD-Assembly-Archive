using Cpp2ILInjected.CallAnalysis;

public class ScreenshotSaveGameFormat
{
	public string m_Encoded;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ScreenshotSaveGameFormat()
	{
	}
}
