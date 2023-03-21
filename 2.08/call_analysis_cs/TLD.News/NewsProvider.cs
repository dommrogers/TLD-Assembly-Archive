using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.News;

public class NewsProvider
{
	private class NewsResult
	{
		public NewsItem[] result;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public NewsResult()
		{
		}
	}

	private const string SERVER_URL = "https://hza1e5qt.apicdn.sanity.io/v2022-10-25/data/query/production?query=";

	private const string CHANNEL = "live";

	private const string QUERY_FORMAT = "*[_type == 'sku' && sku_reference_name == '{sku}'][0] {\n\t\t\t\t\t\t\t\t\t\t\t\t\tposts[@->channel == '{channel}' && @->platform.{platform} == true && dateTime(@->startDate) <= dateTime(now()) && dateTime(@->endDate) >= dateTime(now())]-> {\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_Name': post_reference_name,\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_NewsType': customNotificationType,\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_BackgroundImageUrl': imageUrl,\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_StartDate': startDate,\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_EndDate': endDate,\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_LocalizedTitle': language.{lang}.title,\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_LocalizedBody': language.{lang}.body,\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_FallbackTitle': language.en.title,\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_FallbackBody': language.en.body,\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_Url': tellMeMoreUrl,\n\t\t\t\t\t\t\t\t\t\t\t\t\t}\n\t\t\t\t\t\t\t\t\t\t\t\t}.posts";

	private const int REFRESH_TIME_MIN = 360;

	private const int FAIL_REFRESH_TIME_MIN = 10;

	private List<NewsItem> _003CItems_003Ek__BackingField;

	private DateTime m_NextRefreshTime;

	private string m_LastLanguage;

	public List<NewsItem> Items
	{
		[CallerCount(Count = 80)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 279)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	public bool NeedsRefresh()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NewsProvider), Member = "GenerateQuery")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(WebUtility), Member = "UrlEncode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GenerateNewsURL(string sku)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NewsCarousel), Member = "RetrieveNewsFromServer")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(NewsProvider), Member = "GenerateNewsURL")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	private string GenerateQuery(string sku)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	private string TrimQuery(string query)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private string GetPlatformCode()
	{
		return null;
	}

	[CalledBy(Type = typeof(NewsCarousel), Member = "FinishNewsFetching")]
	[Calls(Type = typeof(TimeSpan), Member = "Interval")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(DateTime), Member = "op_Addition")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeSpan), Member = "FromMinutes")]
	public void ParseJson(string newsJson)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public NewsProvider()
	{
	}
}
