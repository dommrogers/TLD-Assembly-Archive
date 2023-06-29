using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class ButtonIcon
{
	public string m_ButtonName;

	public string m_IconName;

	public UIAtlas m_Atlas;

	[DeduplicatedMethod]
	[CallerCount(Count = 234)]
	public ButtonIcon(string name, string icon)
	{
	}
}
