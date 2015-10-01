/***************************************************************************************************
 * PROJECT : Monies
 * 
 * 
 * DISCLAIMER : This code is licensed under CPOL. You are free to use this in your project.
 * The author takes no liabilities for any damage caused because of this code. Use at your own risk.
****************************************************************************************************/

namespace Monies.Shared
{
    /// <summary>
    /// An enum depicting the role of user.
    /// </summary>
    public enum UserRole
    {
        Admin = 0,
        Normal
    };

    /// <summary>
    /// An enumeration for the flow of transaction.
    /// </summary>
    public enum TransactionFlowType
    {
        Income = 0,
        Expenditure
    };

    /// <summary>
    /// Anenum for purpose of transaction.
    /// </summary>
    public enum TransactionPurposeType
    {
        Need = 0,
        Want
    };
}
