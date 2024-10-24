

namespace Assets.Script.Pattern.Builder
{
    public class User
    {
        private int UsersId;
        private string UsersName;
        private string UsersType;

        private User(UserBuilder userBuilder)
        {
            //UsersId = userBuilder.
        }

        public class UserBuilder
        {
            private int UserId;
            private string UserName;
            private string UserType;

            public UserBuilder SetUserID(int userId)
            {
                UserId = userId;
                return this;
            }

            public UserBuilder SetUserName(string userName)
            {
                UserName = userName;
                return this;
            }

            public UserBuilder SetUserType(string userType)
            {
                UserType = userType;
                return this;
            }
        }
    }
}