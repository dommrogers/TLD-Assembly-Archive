using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
using TLD.Stats;

public abstract class StatsView
{
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 2)]
	public string GetFormattedValue(StatInfo.Format format, float value)
	{
		return null;
	}

	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	public string GetFormattedTitle(string locId)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected StatsView()
	{
	}
}
