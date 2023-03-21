namespace Marketplace;

public enum PrivilegeCheckResult
{
	NoIssue = 0,
	PurchaseRequired = 1,
	Aborted = 2,
	Banned = 4,
	Restricted = 8
}
