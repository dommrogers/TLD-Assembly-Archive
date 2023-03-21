using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.News;

public class NewsItem
{
	public string m_Name;

	public NewsType m_NewsType;

	public string m_BackgroundImageUrl;

	public Texture2D m_CachedBackgroundImage;

	public string m_StartDate;

	public string m_EndDate;

	public string m_LocalizedTitle;

	public string m_LocalizedBody;

	public string m_FallbackTitle;

	public string m_FallbackBody;

	public string m_Url;

	[CallerCount(Count = 0)]
	public string GetTitle()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public string GetBody()
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public NewsItem()
	{
	}
}
