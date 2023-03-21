using System;
using Cpp2ILInjected.CallAnalysis;

public class ActionPickerItemData
{
	public string m_SpriteName;

	public string m_LocID;

	public Action m_Callback;

	[CallerCount(Count = 54)]
	[DeduplicatedMethod]
	public ActionPickerItemData(string spriteName, string locID, Action callback)
	{
	}
}
