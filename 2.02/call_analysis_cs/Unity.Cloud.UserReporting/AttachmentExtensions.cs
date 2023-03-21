using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud.UserReporting;

public static class AttachmentExtensions
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(UserReportAttachment), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void AddJson(this List<UserReportAttachment> instance, string name, string fileName, string contents)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(UserReportAttachment), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void AddText(this List<UserReportAttachment> instance, string name, string fileName, string contents)
	{
	}
}
