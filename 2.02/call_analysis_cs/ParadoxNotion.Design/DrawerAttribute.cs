using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public abstract class DrawerAttribute : Attribute
{
	public virtual int priority
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected DrawerAttribute()
	{
	}
}
