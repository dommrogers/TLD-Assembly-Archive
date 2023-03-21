using Cpp2ILInjected.CallAnalysis;

public class CameraPathPreviewSupport
{
	public static bool previewSupported
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public static string previewSupportedText
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CameraPathPreviewSupport()
	{
	}
}
