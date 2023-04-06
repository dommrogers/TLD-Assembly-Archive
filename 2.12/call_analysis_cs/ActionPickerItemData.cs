using System;
using Cpp2ILInjected.CallAnalysis;

public class ActionPickerItemData
{
	public string m_SpriteName;

	public string m_LocID;

	public Action m_Callback;

	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	public ActionPickerItemData(string spriteName, string locID, Action callback)
	{
	}
}
