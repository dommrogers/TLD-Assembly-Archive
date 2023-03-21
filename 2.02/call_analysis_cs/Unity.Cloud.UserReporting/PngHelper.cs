using System;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud.UserReporting;

public static class PngHelper
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Convert), Member = "FromBase64String")]
	[Calls(Type = typeof(PngHelper), Member = "Slice")]
	[Calls(Type = typeof(Array), Member = "Reverse")]
	[Calls(Type = typeof(BitConverter), Member = "ToInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int GetPngHeightFromBase64Data(string data)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Convert), Member = "FromBase64String")]
	[Calls(Type = typeof(PngHelper), Member = "Slice")]
	[Calls(Type = typeof(Array), Member = "Reverse")]
	[Calls(Type = typeof(BitConverter), Member = "ToInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int GetPngWidthFromBase64Data(string data)
	{
		return 0;
	}

	[CalledBy(Type = typeof(PngHelper), Member = "GetPngHeightFromBase64Data")]
	[CalledBy(Type = typeof(PngHelper), Member = "GetPngWidthFromBase64Data")]
	[CalledBy(Type = typeof(UserReportScreenshot), Member = "get_Height")]
	[CalledBy(Type = typeof(UserReportScreenshot), Member = "get_Width")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static byte[] Slice(byte[] source, int start, int end)
	{
		return null;
	}
}
