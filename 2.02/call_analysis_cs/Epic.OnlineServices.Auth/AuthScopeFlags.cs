namespace Epic.OnlineServices.Auth;

public enum AuthScopeFlags : ulong
{
	NoFlags = 0uL,
	BasicProfile = 1uL,
	FriendsList = 2uL,
	Presence = 4uL,
	FriendsManagement = 8uL
}
