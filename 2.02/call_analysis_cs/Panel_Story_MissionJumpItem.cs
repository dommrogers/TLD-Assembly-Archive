using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Story_MissionJumpItem : MonoBehaviour
{
	public UILabel m_Label_Mission;

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Panel_Story_MissionJumpItem()
	{
	}
}
