namespace MeetingApp.Models
{
  public static class Repository
  {
    private static List<UserInfo> _users = new();

    static Repository()
    {
      _users = new List<UserInfo>
      {
        new UserInfo { Id=1,Name = "Ali", Email = "aa@abc.com", Phone = "123456", WillAttend = true },
        new UserInfo { Id=2,Name = "Ayşe", Email = "aa@abc.com", Phone = "123456", WillAttend = false },
        new UserInfo { Id=3,Name = "Fatma", Email = "aa@abc.com", Phone = "123456", WillAttend = true },

          };
    }
    public static List<UserInfo> Users
    {
      get
      {
        return _users;
      }
    }

    public static void AddUser(UserInfo user)
    {
      user.Id = _users.Max(u => u.Id) + 1;
      _users.Add(user);
    }
    public static UserInfo? GetUserById(int id)
    {
      return _users.FirstOrDefault(u => u.Id == id);
    }
  }

}