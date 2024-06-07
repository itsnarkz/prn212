using BusinessObjects;


namespace DataAccessLayer
{
    public class AccountDAO
    {
        public static AccountMember GetAccountById(string accountID)
        {
            AccountMember accountMember = new AccountMember();
            if(accountID.Equals("username"))
            {
                accountMember.memberID = accountID;
                accountMember.memberPassword = "123";
                accountMember.role = 1;
                return accountMember;
            }
            return null;
        }
    }
}
