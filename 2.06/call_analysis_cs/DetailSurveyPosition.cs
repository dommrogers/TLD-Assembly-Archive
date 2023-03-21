using Cpp2ILInjected.CallAnalysis;

public class DetailSurveyPosition
{
	public int x;

	public int y;

	public int h;

	public int r;

	public float m_Time;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public DetailSurveyPosition()
	{
	}
}
