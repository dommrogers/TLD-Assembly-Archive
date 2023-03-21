using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InvDatabase : MonoBehaviour
{
	private static InvDatabase[] mList;

	private static bool mIsDirty;

	public int databaseID;

	public List<InvBaseItem> items;

	public UIAtlas iconAtlas;

	public static InvDatabase[] list
	{
		[CalledBy(Type = typeof(EquipRandomItem), Member = "OnClick")]
		[CalledBy(Type = typeof(InvDatabase), Member = "GetDatabase")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByID")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindByName")]
		[CalledBy(Type = typeof(InvDatabase), Member = "FindItemID")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(NGUITools), Member = "FindActive")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private InvBaseItem GetItem(int id16)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[CallsUnknownMethods(Count = 2)]
	private static InvDatabase GetDatabase(int dbID)
	{
		return null;
	}

	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[CalledBy(Type = typeof(InvGameItem), Member = "get_baseItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static InvBaseItem FindByID(int id32)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	public static InvBaseItem FindByName(string exact)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvDatabase), Member = "get_list")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int FindItemID(InvBaseItem item)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public InvDatabase()
	{
	}
}
