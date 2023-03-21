using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class ButtonIcon
{
	public string m_ButtonName;

	public string m_IconName;

	public UIAtlas m_Atlas;

	[CallerCount(Count = 83)]
	[DeduplicatedMethod]
	public ButtonIcon(string name, string icon)
	{
	}
}
