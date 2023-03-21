using Cpp2ILInjected.CallAnalysis;

public class GunItemSaveDataProxy
{
	public int m_RoundsInClipProxy;

	public bool m_IsJammed;

	public int[] m_Clip;

	public int m_SpentCasingsInClip;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public GunItemSaveDataProxy()
	{
	}
}
